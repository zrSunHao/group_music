using Hao.GroupMusic.App.Business.ViewModels;

namespace Hao.GroupMusic.App.Pages;

public partial class SongListPage : ContentPage
{
	public SongListPage()
	{
		InitializeComponent();
		this.BindingContext = new SongListPageViewModel();

    }
}