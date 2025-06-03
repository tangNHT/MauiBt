using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBT.ViewModel
{
	public class TaskViewModel : INotifyPropertyChanged
	{
		private ObservableCollection<TaskItem> _tasks;

		public ObservableCollection<TaskItem> Tasks
		{
			get => _tasks;
			set
			{
				_tasks = value;
				OnPropertyChanged(nameof(Tasks));
			}
		}

		public TaskViewModel()
		{
			Tasks = new ObservableCollection<TaskItem>
			{
				new TaskItem { Id="FIG-123", Title="Task 1", Project="Project 1", Priority="High", Date=new DateTime(2023,12,05), OwnerImage="image.png" },
				new TaskItem { Id="FIG-122", Title="Task 2", Project="Acme GTM", Priority="Low",  Date=new DateTime(2023,12,05), OwnerImage="image.png" },
				new TaskItem { Id="FIG-121", Title="Write blog post for demo day", Project="Acme GTM", Priority="High", Date=new DateTime(2023,12,05), OwnerImage="image.png" },
				new TaskItem { Id="FIG-120", Title="Publish blog page", Project="Website launch", Priority="Low",  Date=new DateTime(2023,12,05), OwnerImage="image.png" },
				new TaskItem { Id="FIG-119", Title="Add gradients to design system", Project="Design backlog", Priority="Medium", Date=new DateTime(2023,12,05), OwnerImage="image.png" },
				new TaskItem { Id="FIG-118", Title="Responsive behavior doesn’t work on Android", Project="Bug fixes", Priority="Medium", Date=new DateTime(2023,12,05), OwnerImage="image.png" },
				new TaskItem { Id="FIG-117", Title="Confirmation states not rendering properly", Project="Bug fixes", Priority="Medium", Date=new DateTime(2023,12,05), OwnerImage="image.png" },
            };
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		protected void OnPropertyChanged(string propertyName) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
