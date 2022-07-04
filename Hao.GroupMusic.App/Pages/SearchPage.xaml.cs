using Hao.GroupMusic.App.Business.ViewModels;

namespace Hao.GroupMusic.App.Pages;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
		this.BindingContext = new SearchPageViewModel();

    }
}