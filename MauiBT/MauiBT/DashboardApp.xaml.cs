using Telerik.Maui.Controls.Compatibility.Chart;

namespace MauiBT;

public partial class DashboardApp : ContentPage
{
	public DashboardApp()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();

		var customPalette = new ChartPalette();
		customPalette.Entries.Add(new PaletteEntry
		{
			FillColor = Colors.Black,
			StrokeColor = Colors.Black
		});

		BarChart.Palette = customPalette;
	}
}