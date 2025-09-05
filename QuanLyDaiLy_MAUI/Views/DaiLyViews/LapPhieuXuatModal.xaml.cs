using CommunityToolkit.Maui.Views;
using QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

namespace QuanLyDaiLy_MAUI.Views.DaiLyViews;

public partial class LapPhieuXuatModal : Popup
{
	public LapPhieuXuatModal(LapPhieuXuatModalViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		vm.SetCurrentPopup(this);

	}


}