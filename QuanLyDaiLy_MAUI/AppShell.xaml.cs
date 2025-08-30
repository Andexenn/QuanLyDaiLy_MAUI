namespace QuanLyDaiLy_MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.AddAgent), typeof(Views.AddAgent));
        }
    }
}
