namespace Lesson1.Models;

public class Account
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Fullname { get; set; }
    public string Description { get; set; }
    public string Details { get; set; }
    public DateTime Dob { get; set; }
    public string Gender { get; set; }
    public int CertId { get; set; }
    public bool Status { get; set; }
    public List<int> LanguagesIds { get; set; }
    public int RoleId { get; set; }
    public string Email { get; set; }
    public Address Address { get; set; }
    public string Photo { get; set; }
}
