namespace EventEaseProject.Models;

public class Registration(int id, int eventId, string name, int age, string email)
{
    public int Id { get; set; } = id;
    public int EventId { get; set; } = eventId;
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public string Email { get; set; } = email;
}