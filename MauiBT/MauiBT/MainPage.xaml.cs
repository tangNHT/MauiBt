﻿using Telerik.Maui.Controls.Compatibility;
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
			var page2 = new MusicApp();

			var newwindow = new Window(page2)
			{
				Title = "Mussic App"
			};

			Application.Current.OpenWindow(newwindow);
		}
		private void CreateNewWindowDashboradApp(object sender, EventArgs e)
		{
			var page2 = new DashboardApp();

			var newwindow = new Window(page2)
			{
				Title = "Dashboard App"
			};

			Application.Current.OpenWindow(newwindow);
		}
		private void CreateNewWindowChatApp(object sender, EventArgs e)
		{
			var page2 = new ChatApp();

			var newwindow = new Window(page2)
			{
				Title = "Chat App"
			};

			Application.Current.OpenWindow(newwindow);
		}
		private void CreateNewWindowTaskApp(object sender, EventArgs e)
		{
			var page2 = new TaskApp();

			var newwindow = new Window(page2)
			{
				Title = "Task App"
			};

			Application.Current.OpenWindow(newwindow);
		}
	}
}
