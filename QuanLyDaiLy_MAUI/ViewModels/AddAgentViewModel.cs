using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuanLyDaiLy_MAUI.Data;
using QuanLyDaiLy_MAUI.Models;
using System.Collections.ObjectModel;

namespace QuanLyDaiLy_MAUI.ViewModels;

public partial class AddAgentViewModel : ObservableObject
{
	private readonly DataContext _context;
    public AddAgentViewModel(DataContext context)
	{
		_context = context;
	}

	[ObservableProperty]
	private ObservableCollection<DaiLy> _agents = new();

	[ObservableProperty]
	private DaiLy _newAgent = new();

	[ObservableProperty]
	private bool _isBusy;

	[ObservableProperty]
	private string _busyText;

	
    public async Task LoadAgentAsync()
	{
		await ExecuteAsync(async () =>
		{
            var agents = await _context.GetAllAsync<DaiLy>();
            if (agents is not null && agents.Any())
            {
                Agents ??= new ObservableCollection<DaiLy>();

                foreach (var agent in agents)
                {
                    Agents.Add(agent);
                }
            }
        }, "Đang nạp dữ liệu");
    }

	[RelayCommand]
    private void SetNewAgent(DaiLy? agent) => NewAgent = agent ?? new();


	[RelayCommand]	
    private async Task SaveAgentAsync()
	{
		if (NewAgent is null)
			return;

		var busyText = NewAgent.MaDaiLy == 0 ? "Đang thêm đại lý..." : "Đang cập nhật đại lý...";

        await ExecuteAsync(async () =>
		{
            if (NewAgent.MaDaiLy == 0)
            {
                // create new
                await _context.AddItemAsync<DaiLy>(NewAgent);
                Agents.Add(NewAgent);
            }
            else
            {
                // update existing
                await _context.UpdateItemAsync<DaiLy>(NewAgent);
                var agentCopy = NewAgent.Clone();
                var index = Agents.IndexOf(Agents.FirstOrDefault(a => a.MaDaiLy == NewAgent.MaDaiLy));
                Agents.RemoveAt(index);

                Agents.Insert(index, agentCopy);
            }
            SetNewAgentCommand.Execute(new());
        }, busyText);
    }

    private bool IsValidAgent()
    {
        if (NewAgent.TenDaiLy is null or "" ||
           NewAgent.DiaChi is null or "" ||
           NewAgent.SoDienThoai is null or "" ||
           NewAgent.Email is null or "")
            return false;
        return true;
    }

    [RelayCommand]
    private async Task AddNewAgentAsync()
	{
		await ExecuteAsync(async () =>
		{
            if (!IsValidAgent())
            {
                await Shell.Current.DisplayAlert("Lỗi", "Vui lòng điền đầy đủ thông tin đại lý!", "OK");
                return;
            }

            try
            {
                // Attempt to add to database
                var success = await _context.AddItemAsync<DaiLy>(NewAgent);
                if (success)
                {
                    // Add to Agents collection
                    Agents.Add(NewAgent);

                    await Shell.Current.DisplayAlert(
                        "Thành công",
                        $"Đã thêm đại lý mới: {NewAgent.TenDaiLy}",
                        "OK"
                    );

                    // Optionally reset NewAgent for next entry
                    //NewAgent = new DaiLy();
                }
                else
                {
                    await Shell.Current.DisplayAlert("Lỗi", "Không thể thêm đại lý mới vào cơ sở dữ liệu.", "OK");
                }
            }
            catch (Exception ex)
            {
                await Shell.Current.DisplayAlert("Lỗi", $"Thêm đại lý thất bại! {ex.Message}", "OK");
            }


        }, "Đang thêm đại lý mới...");
    } //Todo Ma Dai Ly tu dong tang, bit cai ma dai ly khong cho dien.


    [RelayCommand]
	private async Task DeleteAgentAsync(int id)
	{
		await ExecuteAsync(async () =>
		{
            if (await _context.DeleteItemByKeyAsync<DaiLy>(id))
            {
                Agents.Remove(Agents.FirstOrDefault(a => a.MaDaiLy == id));
            }
            else
            {
                await Shell.Current.DisplayAlert("Lỗi", "Xóa đại lý thất bại!", "OK");
            }
        }, "Đang xoá");
    }

	private async Task ExecuteAsync(Func<Task> action, string? busyText = null)
	{
		IsBusy = true;
		BusyText = busyText ?? "Đang xử lý...";
        try
		{
			await action?.Invoke();
		}
		finally
		{
            IsBusy = false;
            BusyText = string.Empty;
        }
	}



    [RelayCommand]
    async Task Announce()
	{
		await Shell.Current.DisplayAlert("Thông báo", "Thêm đại lý thành công!", "OK");
    }
}