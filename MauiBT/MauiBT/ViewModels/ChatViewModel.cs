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
