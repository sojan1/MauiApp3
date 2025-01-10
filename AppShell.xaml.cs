namespace MauiApp3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddItem), typeof(AddItem));
            Routing.RegisterRoute(nameof(EditItem), typeof(EditItem));
            
        }
    }
}
