using QuanLyDaiLy_MAUI.ViewModels.DaiLyViewModels;

namespace QuanLyDaiLy_MAUI.Views.DaiLyViews;

public partial class TraCuuDaiLyPage : ContentPage
{
	public TraCuuDaiLyPage(TraCuuDaiLyPageViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
    }


}