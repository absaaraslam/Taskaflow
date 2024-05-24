namespace TaskManagementProject.Models
{
	public class Tasks
	{
		public int TaskId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateTime? DueDate { get; set; }
		public bool Completed { get; set; }

		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
