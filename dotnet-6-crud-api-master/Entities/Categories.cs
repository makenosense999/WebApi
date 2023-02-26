namespace WebApi.Entities;

public class Categories
{
    public int Id { get; set;}
    public string CategoryName { get; set;}
    public virtual User User { get; set;}
}