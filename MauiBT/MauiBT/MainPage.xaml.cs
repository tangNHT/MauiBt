using Telerik.Maui.Controls.Compatibility;
namespace MauiBT
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

		private void ResetCountBtn_Clicked(object sender, EventArgs e)
		{
            count = 0;
            CounterBtn.Text = $"Click me";
		}

		private void CreateNewWindow(object sender, EventArgs e)
		{
			var page = new ContentPage
			{
				Content = new Label { Text = "Hello from new window" }
			};

			var page2 = new MusicApp();

			var newwindow = new Window(page2)
			{
				Title = "Sercond window"
			};

			Application.Current.OpenWindow(newwindow);
		}
		private void CreateNewWindowDashboradApp(object sender, EventArgs e)
		{
			var page = new ContentPage
			{
				Content = new Label { Text = "Hello from new window" }
			};

			var page2 = new DashboardApp();

			var newwindow = new Window(page2)
			{
				Title = "Sercond window"
			};

			Application.Current.OpenWindow(newwindow);
		}
	}
}
