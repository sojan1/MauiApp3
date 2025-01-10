using MauiApp3.Models;
using System.Windows.Input;

namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = mainPageViewModel;
        }

 

    }

}
