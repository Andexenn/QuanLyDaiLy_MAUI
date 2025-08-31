using CommunityToolkit.Maui.Extensions;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Models;
using QuanLyDaiLy_MAUI.Views;
using System.Collections.ObjectModel;
namespace QuanLyDaiLy_MAUI.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
    public AddAgentViewModel AddAgentViewModel { get; }
    public ObservableCollection<DaiLy> Agents => AddAgentViewModel.Agents;

    public MainPageViewModel(AddAgentViewModel addAgentViewModel)
    {
        AddAgentViewModel = addAgentViewModel;
    }

    [RelayCommand]
    async Task OnTapClicked()
    {
        var popup = new AddAgent(AddAgentViewModel); // Use shared instance
        Application.Current.MainPage.ShowPopup(popup);
    }

    [RelayCommand]
    async Task RefreshAsync()
    {
        await AddAgentViewModel.DeleteAllRows();
    }
}