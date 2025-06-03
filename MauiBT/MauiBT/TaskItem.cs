using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBT
{
	public class TaskItem
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string Project { get; set; }
		public string Priority { get; set; } 
		public DateTime Date { get; set; }
		public string OwnerImage { get; set; }
	}
}
