using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace MauiApp3.Models
{
    public class EditItemViewModel : INotifyPropertyChanged
    {
        private  MainPageViewModel _mainPageViewModel;
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public EditItemViewModel(MainPageViewModel mainPageViewModel)
        {
            _mainPageViewModel = mainPageViewModel;
            SaveCommand = new Command(SaveItem);
            CancelCommand = new Command(CancelEditItem);
        }


        private void SaveItem()
        {
            try
            {
                var index = _mainPageViewModel.Items.IndexOf(_mainPageViewModel.Items.FirstOrDefault(x => x.ItemId == ItemId));
                if (index >= 0)
                {
                    _mainPageViewModel.Items[index] = new Item
                    {
                        ItemId = this.ItemId,
                        ItemName = this.ItemName,
                        Description = this.Description
                    };
                }
                Shell.Current.GoToAsync("..");
            } 
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
            }
}


        private void CancelEditItem()
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

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
