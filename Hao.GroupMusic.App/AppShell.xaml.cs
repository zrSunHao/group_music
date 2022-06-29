using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace Hao.GroupMusic.App;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        var toast = Toast.Make("this is play clicked!", ToastDuration.Short);
        await toast.Show();
    }
}
