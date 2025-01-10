using MauiApp3.Models;

namespace MauiApp3
{
	public partial class AddItem : ContentPage
	{
        public AddItem(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = new AddItemViewModel(mainPageViewModel);
        }
    }
}