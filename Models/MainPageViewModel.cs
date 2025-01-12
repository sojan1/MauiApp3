
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
namespace MauiApp3.Models
{
    public class MainPageViewModel 
    {
        public ObservableCollection<Item> Items { get; set; }
        public ICommand CommandAddItem { get; set; }

        public ICommand CommandEditItem { get; set; }

        public MainPageViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item { ItemId = "61a6235c-227c-4b33-8a91-5ee42e0b297c", ItemName = "Item 1", Description = "Books" },
                new Item { ItemId = "eb7a1b26-f733-4ab5-8858-d1a4f8e3bc42", ItemName = "Item 2", Description = "Bags" },
                new Item { ItemId = "040a9110-6254-4abb-a93e-a91a39107a94", ItemName = "Item 3", Description = "Television" },
                new Item { ItemId = "2ead75e5-8c11-4e16-a5ba-19e920a82a2f", ItemName = "Item 4", Description = "Washing Machine" },
                new Item { ItemId = "8376d412-f9d9-4fa6-a70c-181ea966c6bb", ItemName = "Item 5", Description = "Clock" }
            };

            CommandAddItem = new Command(GotoAddItem);
            CommandEditItem = new Command<Item>(GotoEditItem);
        }

        private async void GotoEditItem(Item item)
        {
            try
            {
                var nav = new Dictionary<string, object> {
                 { "item", item }
            };
                await Shell.Current.GoToAsync(nameof(frmEditItem), nav);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
        }
 
        private async void GotoAddItem()
        {
            try
            {
                await Shell.Current.GoToAsync(nameof(frmAddItem));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
