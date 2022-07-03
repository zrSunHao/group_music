using Hao.GroupMusic.App.Business.ViewModels;

namespace Hao.GroupMusic.App.Pages;

public partial class HistoryPage : ContentPage
{
	public HistoryPage()
	{
		InitializeComponent();
        this.BindingContext = new PlayQueuePageViewModel();
    }
}