 using System.Windows.Input;

namespace MauiApp3.Models
{
    public class AddItemViewModel
    {
        private readonly MainPageViewModel _mainPageViewModel;

        public string ItemName { get; set; }
        public string Description { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public AddItemViewModel(MainPageViewModel mainPageViewModel)
        {
            _mainPageViewModel = mainPageViewModel;
            SaveCommand = new Command(SaveItem);
            CancelCommand = new Command(CancelAddItem);
        }

        private void SaveItem()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(ItemName) && !string.IsNullOrWhiteSpace(Description))
                {
                    var newItem = new Item
                    {
                        ItemId = Guid.NewGuid().ToString(),
                        ItemName = ItemName,
                        Description = Description
                    };

                    _mainPageViewModel.Items.Add(newItem);

                }
                Shell.Current.GoToAsync("..");
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }

        }
        private void CancelAddItem()
        {
            try
            {
                Shell.Current.GoToAsync("..");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
