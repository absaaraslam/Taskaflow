using System.ComponentModel.DataAnnotations;

namespace TaskManagementProject.Models;

public class Category
{
	public int ID { get; set; }
	[Required(ErrorMessage = "Name is required!")]
	public string? Name { get; set; }
	[Required(ErrorMessage = "Description is required!")]
	public string? Description { get; set; }
	[Required(ErrorMessage = "No of tasks required!"),
	Range(0, int.MaxValue, ErrorMessage = "Atleast initialize a task!")]
	public int NoOfTasks { get; set; }
}

