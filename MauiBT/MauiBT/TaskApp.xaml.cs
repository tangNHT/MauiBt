using MauiBT.ViewModel;

namespace MauiBT;

public partial class TaskApp : ContentPage
{
	public TaskApp()
	{
		InitializeComponent();
		BindingContext = new TaskViewModel();
	}
}