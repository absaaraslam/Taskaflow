using System.ComponentModel.DataAnnotations;

namespace TaskManagementProject.Models;

public class Category
{
	public int CategoryId { get; set; }
	public string CategoryName { get; set; }
	//public List<Tasks> Tasks { get; set; }
	public ICollection<Tasks> Tasks { get; set; }
}

