using CommunityToolkit.Maui.Views;
using QuanLyDaiLy_MAUI.ViewModels.PhieuXuatViewModels;

namespace QuanLyDaiLy_MAUI.Views.DaiLyViews;

public partial class LapPhieuXuatModal : Popup
{
	public LapPhieuXuatModal(LapPhieuXuatModalViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
		vm.SetCurrentPopup(this);

	}


}