using CommunityToolkit.Maui.Views;
using QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

namespace QuanLyDaiLy_MAUI.Views.DaiLyViews;

public partial class ThemDaiLyModal : Popup
{
    private LapPhieuXuatModal? lapPhieuXuatModal;

    public ThemDaiLyModal(ThemDaiLyModalViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
        vm.SetCurrentPopup(this);
    }

    public ThemDaiLyModal(LapPhieuXuatModal lapPhieuXuatModal)
    {
        this.lapPhieuXuatModal = lapPhieuXuatModal;
    }

    private async void OnCloseClicked(object sender, EventArgs e)
    {
        await this.CloseAsync();
    }
}