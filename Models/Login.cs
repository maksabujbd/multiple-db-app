namespace MultipleDbApp.Models;

public class Login
{
    public Guid Id { get; set; }
    public DateTime LoginTime { get; set; }
    public int UserId { get; set; }
}