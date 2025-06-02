using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBT
{
	public class MainViewModel
	{
		public ObservableCollection<ChartData> LineData { get; set; }
		public ObservableCollection<ChartData> BarData { get; set; }
		public ObservableCollection<User> Users { get; set; }
		public ObservableCollection<TrafficSource> Sources { get; set; }

		public MainViewModel()
		{
			LineData = new ObservableCollection<ChartData>
			{
				new ChartData("23 Nov", 24000),
				new ChartData("24", 26000),
				new ChartData("25", 28000),
				new ChartData("26", 32000),
				new ChartData("27", 35000),
				new ChartData("28", 39000),
				new ChartData("29", 46000),
			};

			BarData = new ObservableCollection<ChartData>
			{
				new ChartData("Jan", 50000),
				new ChartData("Feb", 48000),
				new ChartData("Mar", 46000),
				new ChartData("Apr", 54000),
				new ChartData("May", 79000),
				new ChartData("Jun", 45000),
				new ChartData("Jul", 69000),
				new ChartData("Aug", 63000),
				new ChartData("Sep", 54000),
				new ChartData("Oct", 47000),
				new ChartData("Nov", 42000),
				new ChartData("Dec", 12000),
			};

			Users = new ObservableCollection<User>
			{
				new User("Helena", "email@figmasfakedomain.net", "image.png", "Will head to the Help Center"),
				new User("Oscar", "email@figmasfakedomain.net", "oscar.jpg", "Let's go"),
				new User("Daniel", "email@figmasfakedomain.net", "daniel.jpg", "Trueeeeeee"),
				new User("Daniel Jay Park", "email@figmasfakedomain.net", "daniel_jay_park.jpg", "lol yeah"),
				new User("Mark Rojas", "email@figmasfakedomain.net", "mark_rojas.jpg", "great catching"),
			};

			Sources = new ObservableCollection<TrafficSource>
			{
				new TrafficSource("website.net", 4321, "+84%"),
				new TrafficSource("website.net", 4033, "-8%"),
				new TrafficSource("website.net", 3128, "+2%"),
				new TrafficSource("website.net", 2104, "+33%"),
				new TrafficSource("website.net", 2003, "+30%"),
				new TrafficSource("website.net", 1894, "+15%"),
				new TrafficSource("website.net",  405, "-12%"),
			};
		}
	}
}

public class ChartData
{
	public string Label { get; set; }
	public double Value { get; set; }
	public ChartData(string label, double value)
	{
		Label = label;
		Value = value;
	}
}

public class User
{
	public string Name { get; set; }
	public string Email { get; set; }
	public string Avatar { get; set; }
	public string Chat { get; set; }
	public User(string name, string email, string avatar, string chat)
	{
		Name = name;
		Email = email;
		Avatar = avatar;
		Chat = chat;
	}
}
public class TrafficSource
{
	public string Source { get; set; }
	public int Sessions { get; set; }
	public string Change { get; set; }

	public TrafficSource(string source, int sessions, string change)
	{
		Source = source;
		Sessions = sessions;
		Change = change;
	}
}
