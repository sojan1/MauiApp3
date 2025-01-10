using MauiApp3.Models;
using System.Xml.Linq;

namespace MauiApp3
{
    [QueryProperty("item", "item")]
    public partial class EditItem : ContentPage
    {
        private Item _item;
        public Item item { get => _item; set => _item = value; }

        public EditItem(MainPageViewModel mainPageViewModel)
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