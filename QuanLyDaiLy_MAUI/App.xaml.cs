using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.ViewModels;

namespace QuanLyDaiLy_MAUI
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}