using MauiBT.ViewModel;

namespace MauiBT;

public partial class ChatApp : ContentPage
{
	public ChatApp()
	{
		InitializeComponent();

		BindingContext = new ChatViewModel();
		//BindingContext = new MainViewModel();
	}

	private void OnEntryCompleted(object sender, EventArgs e)
	{
		if (BindingContext is ChatViewModel vm)
		{
			if (vm.SendMessageCommand?.CanExecute(null) == true)
			{
				vm.SendMessageCommand.Execute(null);
			}
		}
	}
}