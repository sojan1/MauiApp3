namespace MauiApp3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(frmAddItem), typeof(frmAddItem));
            Routing.RegisterRoute(nameof(frmEditItem), typeof(frmEditItem));
            
        }
    }
}
