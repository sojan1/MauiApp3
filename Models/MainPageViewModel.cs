
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.ComponentModel;
using Microsoft.Maui.Controls;
namespace MauiApp3.Models
{
    public class MainPageViewModel  
    {
        // Observable collection for binding
        public ObservableCollection<Item> Items { get; set; }
        public ICommand GotoCommandPage { get; set; }

        public ICommand LoadItemCommand { get; set; }

        public MainPageViewModel()
        {
            // Initialize the collection with 5 items
            Items = new ObservableCollection<Item>
            {
                new Item { ItemId = "61a6235c-227c-4b33-8a91-5ee42e0b297c", ItemName = "Item 1", Description = "first item" },
                new Item { ItemId = "eb7a1b26-f733-4ab5-8858-d1a4f8e3bc42", ItemName = "Item 2", Description = "second item" },
                new Item { ItemId = "040a9110-6254-4abb-a93e-a91a39107a94", ItemName = "Item 3", Description = "third item" },
                new Item { ItemId = "2ead75e5-8c11-4e16-a5ba-19e920a82a2f", ItemName = "Item 4", Description = "fourth item" },
                new Item { ItemId = "8376d412-f9d9-4fa6-a70c-181ea966c6bb", ItemName = "Item 5", Description = "fifth item" }
            };

            GotoCommandPage = new Command(GotoCommand);
            LoadItemCommand = new Command<Item>(LoadItemData);
        }

         private async void LoadItemData(Item item)
        {
             var nav = new Dictionary <string, object > {
                 { "Edit",  "Edit"  },
                 { "item", item }
             };
             await Shell.Current.GoToAsync(nameof(EditItem), nav);
        }
 
        private async void GotoCommand()
        {
            await Shell.Current.GoToAsync(nameof(AddItem));
        }

    }
}
