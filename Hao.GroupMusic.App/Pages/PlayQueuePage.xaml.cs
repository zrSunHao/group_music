using Hao.GroupMusic.App.Business.ViewModels;

namespace Hao.GroupMusic.App.Pages;

public partial class PlayQueuePage : ContentPage
{
	public PlayQueuePage()
	{
		InitializeComponent();
		this.BindingContext = new PlayQueuePageViewModel();

    }
}