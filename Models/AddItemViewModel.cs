 using System.Windows.Input;

namespace MauiApp3.Models
{
    public class AddItemViewModel
    {
        private readonly MainPageViewModel _mainPageViewModel;

        // Properties bound to the UI
        public string ItemName { get; set; }
        public string Description { get; set; }

        // Command to save the new item
        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public AddItemViewModel(MainPageViewModel mainPageViewModel)
        {
            _mainPageViewModel = mainPageViewModel;
            SaveCommand = new Command(SaveItem);
            CancelCommand = new Command(CancelAddItem);
        }
        private void CancelAddItem()
        {
            Shell.Current.GoToAsync("..");
        }
            
        private void SaveItem()
        {
            if (!string.IsNullOrWhiteSpace(ItemName) && !string.IsNullOrWhiteSpace(Description))
            {
                // Create a new item and add it to the collection in MainPageViewModel
                var newItem = new Item
                {
                    ItemId = Guid.NewGuid().ToString(),
                    ItemName = ItemName,
                    Description = Description
                };

                _mainPageViewModel.Items.Add(newItem);

                // Optionally reset the form
                ItemName = string.Empty;
                Description = string.Empty;
            }
            Shell.Current.GoToAsync("..");
        }

    }
}
