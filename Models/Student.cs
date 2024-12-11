using CRUD_School.Services;

namespace CRUD_School.Models;

public class Student
{
    public Guid Id { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Email { get; set; }
    
    public int PhoneNumber { get; set; }
    
    public int Age { get; set; }
    
    public string Degree { get; set; }
    
    public string Gender { get; set; }
    
    // public List<int> Grades { get; set; }
}