using CommunityToolkit.Maui.Views;

namespace QuanLyDaiLy_MAUI.ViewModels.PhieuThuViewModels;

public class LapPhieuThuModalViewModel : BaseViewModel
{
    private Popup? _currentPopup;
    public LapPhieuThuModalViewModel()
	{
		
	}
    public void SetCurrentPopup(Popup popup) => _currentPopup = popup;

}