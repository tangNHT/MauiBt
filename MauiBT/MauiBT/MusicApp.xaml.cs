using System.Collections.ObjectModel;
using Telerik.Maui.Controls.Compatibility;
namespace MauiBT;

public partial class MusicApp : ContentPage
{
	public ObservableCollection<Playlist> Playlists { get; set; }

	public ObservableCollection<Playlist> Artistnames { get; set; }
	public MusicApp()
	{
		InitializeComponent();

		Playlists = new ObservableCollection<Playlist>
		{
			new Playlist { Image = "playlist1.jpg", Title = "Playlist 1", Description = "Description of playlist" },
			new Playlist { Image = "playlist2.jpg", Title = "Playlist 2", Description = "Description of playlist" },
			new Playlist { Image = "playlist3.jpg", Title = "Playlist 3", Description = "Description of playlist" },
			new Playlist { Image = "playlist4.jpg", Title = "Playlist 4", Description = "Description of playlist" }
		};

		Artistnames = new ObservableCollection<Playlist>
		{
			new Playlist { Image = "artist1.jpg", Title = "Artist Name", Description = "R&B" },
			new Playlist { Image = "artist2.jpg", Title = "Artist Name", Description = "Indie pop" },
			new Playlist { Image = "artist3.jpg", Title = "Artist Name", Description = "Hip hop" },
			new Playlist { Image = "artist4.jpg", Title = "Artist Name", Description = "Electronic" },
			new Playlist { Image = "artist5.jpg", Title = "Artist Name", Description = "R&B" },
			new Playlist { Image = "artist6.png", Title = "Artist Name", Description = "Rock" }
		};

		BindingContext = this;
	}
}