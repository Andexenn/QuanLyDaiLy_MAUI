using CommunityToolkit.Maui.Views;
using QuanLyDaiLy_MAUI.ViewModels.PhieuThuViewModels;

namespace QuanLyDaiLy_MAUI.Views.PhieuThuViews;

public partial class LapPhieuThuModal : Popup
{
	public LapPhieuThuModal(LapPhieuThuModalViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		vm.SetCurrentPopup(this);
    }
}