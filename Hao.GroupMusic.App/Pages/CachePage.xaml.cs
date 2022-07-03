using Hao.GroupMusic.App.Business.ViewModels;

namespace Hao.GroupMusic.App.Pages;

public partial class CachePage : ContentPage
{
	public CachePage()
	{
		InitializeComponent();
        this.BindingContext = new PlayQueuePageViewModel();
    }
}