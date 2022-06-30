using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Hao.GroupMusic.App.Pages;

public partial class PlayerPage : ContentPage
{
    private ObservableCollection<LyricItem> LyricsList;
    private int Index = 0;

    public PlayerPage()
	{
		InitializeComponent();
	}

    public async Task<string> ReadTextFile(string filePath)
    {
        using Stream fileStream = await FileSystem.Current.OpenAppPackageFileAsync(filePath);
        using StreamReader reader = new StreamReader(fileStream);

        return await reader.ReadToEndAsync();
    }

    private async void ContentPage_Appearing(object sender, EventArgs e)
    {
        var lyric = await ReadTextFile("jingzhongbaoguo.lrc");
        var parser = new LyricParse();
        var list = parser.Parse(lyric);
        LyricsList = new ObservableCollection<LyricItem>(list);
        this.lycView.ItemsSource = LyricsList;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (Index > LyricsList.Count) Index = 0;
        var x = 0;
        foreach (var item in this.LyricsList)
        {

            if (x == Index)
            {
                item.FontAtt = FontAttributes.Bold;
                item.TextColor = Colors.LightPink;
            }
            else
            {
                if (item.FontAtt == FontAttributes.Bold)
                {
                    item.FontAtt = FontAttributes.None;
                    item.TextColor = Colors.White;
                }
            }
            x++;
        }
        this.lycView.ScrollTo(Index, position: ScrollToPosition.Center);
        Index++;
    }
}

public class LyricItem : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler PropertyChanged;

    private string _text;
    private int _time;
    private FontAttributes _fontAtt;
    private Color _textColor;

    public string Text    
    {
        get => _text; set
        {
            if (_text != value)
            {
                _text = value;
                OnPropertyChanged(); // reports this property
            }
        }
    }
    public int Time
    {
        get => _time; set
        {
            if (_time != value)
            {
                _time = value;
                OnPropertyChanged(); // reports this property
            }
        }
    }               
    public FontAttributes FontAtt
    {
        get => _fontAtt; set
        {
            if (_fontAtt != value)
            {
                _fontAtt = value;
                OnPropertyChanged(); // reports this property
            }
        }
    }

    public Color TextColor
    {
        get => _textColor; set
        {
            if (_textColor != value)
            {
                _textColor = value;
                OnPropertyChanged(); // reports this property
            }
        }
    }

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
public class LyricParse
{
    private List<LyricItem> LyricsList;         
    private string _lyricContent = "";          

    public List<LyricItem> Parse(string lyric)
    {
        if (LyricsList == null) { LyricsList = new List<LyricItem>(); }
        LyricsList.Clear();

        _lyricContent = lyric;
        if (string.IsNullOrEmpty(lyric)) { return LyricsList; }             // ¸è´ÊÎª¿Õ£¬Ö±½Ó·µ»Ø¿Õ¼¯ºÏ

        string[] arr = lyric.Split(new char[] { '\r', '\n' });              // ¸è´Ê°´»»ÐÐ·ûÇÐ·Ö³ÉÐÐ

        List<string> Timespans = new List<string>();
        Regex r = new Regex(@"\[\d{2}:\d{2}(.\d{2})*\]");                   // ÕýÔò»ñÈ¡¸è´ÊÏÔÊ¾Ê±¼ä
        if (arr != null && arr.Length > 0)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var str = arr[i].Replace("by", "")                          // »ñÈ¡Ò»ÐÐ¸è´Ê²¢È¥³ýÎÞÐ§×Ö·û
                                .Replace("all", "").Replace("ti", "").Replace("offset", "");
                var matches = r.Matches(str);                               // »ñÈ¡¸è´ÊÊ±¼ä×Ö·û
                if (matches != null && matches.Count > 0)
                {
                    for (int j = 0; j < matches.Count; j++) { Timespans.Add(matches[j].Value); }
                }
            }
        }
        Timespans.Sort();           // ¸è´ÊÊ±¼ä×Ö·ûÅÅÐò
        Timespans.Distinct();       // ¸è´ÊÊ±¼ä×Ö·ûÈ¥ÖØ

        for (int i = 0; i < Timespans.Count; i++)               // ¸è´ÊÊ±¼äÐÐÊý
        {
            for (int j = 0; j < arr.Length; j++)                // ¸è´ÊÐÐÊý
            {
                var index = arr[j].IndexOf(Timespans[i]);       // »ñÈ¡¸è´ÊÊ±¼äÔÚÄ³Ò»ÐÐ³öÏÖµÄÎ»ÖÃ
                if (index > -1)                                 // Èô¸ÃÐÐ¸è´ÊÓë¸è´ÊÊ±¼äÎÇºÏ£¬Ìí¼Ó
                {
                    LyricsList.Add(new LyricItem
                    {
                        Text = arr[j].Substring(arr[j].LastIndexOf(']') + 1).TrimEnd('\r').Trim(),
                        Time = GetSeconds(Timespans[i]),
                        TextColor = Colors.White,
                        FontAtt = FontAttributes.None
                    });
                    break;
                }
            }
        }
        return LyricsList;
    }

    public int GetSeconds(string value)
    {
        if (string.IsNullOrEmpty(value)) return 0;
        TimeSpan.TryParse(value, out var span);
        return span.Seconds;
    }
}