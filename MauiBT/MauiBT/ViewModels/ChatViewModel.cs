using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiBT.ViewModel
{
	public class ChatViewModel : INotifyPropertyChanged
	{
		public ObservableCollection<ChatMessage> Messages { get; set; } = new();
		public ObservableCollection<User> Users { get; set; }
		public ICommand SendMessageCommand { get; }

		private string _newMessage;
		public string NewMessage
		{
			get => _newMessage;
			set
			{
				_newMessage = value;
				OnPropertyChanged(nameof(NewMessage));
			}
		}

		public ChatViewModel()
		{
			SendMessageCommand = new Command(SendMessage);

			Users = new ObservableCollection<User>
			{
				new User("Helena", "Hills", "email@figmasfakedomain.net", "image.png", "Will head to the Help Center"),
				new User("Oscar","Emilio", "email@figmasfakedomain.net", "oscar.jpg", "Let's go"),
				new User("Daniel","Davis", "email@figmasfakedomain.net", "daniel.jpg", "Trueeeeeee"),
				new User("Daniel","Jay Park", "email@figmasfakedomain.net", "daniel_jay_park.jpg", "lol yeah"),
				new User("Mark","Rojas", "email@figmasfakedomain.net", "mark_rojas.jpg", "great catching"),
			};
		}

		private void Seed()
		{
			Messages.Add(new ChatMessage { Text = "Oh?", IsMine = false });
			Messages.Add(new ChatMessage { Text = "Cool", IsMine = false });
			Messages.Add(new ChatMessage { Text = "This is the main chat template", IsMine = true });
		}

		private void SendMessage()
		{
			if (!string.IsNullOrEmpty(NewMessage))
			{
				Messages.Add(new ChatMessage { Text = NewMessage, IsMine = true });
				NewMessage = string.Empty;
			}
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}
