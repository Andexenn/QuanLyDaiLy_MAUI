using CommunityToolkit.Maui.Views;
using QuanLyDaiLy_MAUI.ViewModels;
namespace QuanLyDaiLy_MAUI.Views;

public partial class AddAgent : Popup
{

    public AddAgent(AddAgentViewModel vm)
    {
        InitializeComponent();
        this.BindingContext = vm;
    }

    //public AddAgent(AddAgentViewModel viewModel)
    //{
    //    InitializeComponent();
    //    this.BindingContext = viewModel;
    //}

    private async void OnCloseClicked(object sender, EventArgs e)
    {
        await this.CloseAsync();
    }

    // Remove the override and async from OnAppearing, and make it a regular method.
    // There is no OnAppearing method to override in Popup or its base classes.

    
}