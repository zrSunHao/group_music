using Hao.GroupMusic.App.Business.ViewModels;

namespace Hao.GroupMusic.App.Pages;

public partial class LibraryPage : ContentPage
{
	public LibraryPage()
	{
		InitializeComponent();
		var vm = new LibraryPageViewModel();
		this.BindingContext = vm;
    }
}