namespace EFHW1_CRUDWpfApp.Data.Models;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public int GroupId { get; set; }
    public Group Group { get; set; }
}