using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp3.Models
{
    public class EditItemViewModel
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
                var itemToUpdate = _mainPageViewModel.Items.FirstOrDefault(x => x.ItemId == ItemId);
                if (itemToUpdate != null)
                {
                    itemToUpdate.ItemName = ItemName;
                    itemToUpdate.Description = Description;
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
    }
}
