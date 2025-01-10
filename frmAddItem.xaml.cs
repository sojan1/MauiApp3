using MauiApp3.Models;

namespace MauiApp3
{
	public partial class frmAddItem : ContentPage
	{
        public frmAddItem(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = new AddItemViewModel(mainPageViewModel);
        }
    }
}