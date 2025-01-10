
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace MauiApp3.Models
{
    public class Item : INotifyPropertyChanged
    {
        private string _itemName;
        private string _description;
        private string _itemId;

        public string ItemId { get; set; }

        public string ItemName
        {
            get => _itemName;
            set
            {
                if (_itemName != value)
                {
                    _itemName = value;
                    OnPropertyChanged();  
                }
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;
                    OnPropertyChanged();  
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
