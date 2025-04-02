namespace YStore.Models;

public class Customer
{
    public int CustomerId { get; set; }
    public int? UserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string? Address { get; set; }
    public User? User { get; set; }
    public List<Order> Orders { get; set; } = new();
}
