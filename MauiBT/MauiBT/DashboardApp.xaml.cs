namespace MauiBT;

public partial class DashboardApp : ContentPage
{
	public DashboardApp()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}