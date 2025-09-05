using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Views.DaiLyViews;

namespace QuanLyDaiLy_MAUI.ViewModels;

public partial class BaseViewModel : ObservableObject
{

    public BaseViewModel()
    {
    }


    [ObservableProperty]
	[NotifyPropertyChangedFor(nameof(IsNotLoading))]
	private bool isLoading = false;

	public bool IsNotLoading => !IsLoading;

	[ObservableProperty]
	private string title = string.Empty;

}