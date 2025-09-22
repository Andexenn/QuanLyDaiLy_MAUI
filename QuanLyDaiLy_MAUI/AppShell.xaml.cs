namespace QuanLyDaiLy_MAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.DaiLyViews.ThemDaiLyModal), typeof(Views.DaiLyViews.ThemDaiLyModal));
            Routing.RegisterRoute(nameof(Views.DaiLyViews.LapPhieuXuatModal), typeof(Views.DaiLyViews.LapPhieuXuatModal));
            Routing.RegisterRoute(nameof(Views.DaiLyViews.TraCuuDaiLyPage), typeof(Views.DaiLyViews.TraCuuDaiLyPage));
            Routing.RegisterRoute(nameof(Views.PhieuThuViews.LapPhieuThuModal), typeof(Views.PhieuThuViews.LapPhieuThuModal));
            Routing.RegisterRoute(nameof(Views.DaiLyViews.LapBaoCaoDoanhSoTheoThangPage), typeof(Views.DaiLyViews.LapBaoCaoDoanhSoTheoThangPage));
        }
    }
}
