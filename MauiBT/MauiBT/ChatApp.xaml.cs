namespace MauiBT;

public partial class ChatApp : ContentPage
{
	public ChatApp()
	{
		InitializeComponent();

		BindingContext = new MainViewModel();
	}
}