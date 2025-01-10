using MauiApp3.Models;
namespace MauiApp3
{
	[QueryProperty("item", "item")]
	public partial class frmEditItem : ContentPage
    {
        private Item _item;
        public Item item { get => _item; set => _item = value; }

        public frmEditItem(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = new EditItemViewModel(mainPageViewModel);
        }
        protected override async void OnAppearing()
        {
            txtItemId.Text = _item.ItemId;
            txtItemName.Text = _item.ItemName;
            txtItemDescription.Text = _item.Description;
        }

    }
}