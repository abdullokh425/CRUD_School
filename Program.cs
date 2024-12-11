using CRUD_School.Models;
using CRUD_School.Services;

namespace CRUD_School;

class Program
{
    static void Main(string[] args)
    {
        RunFrontEnd();
    }

    public static void RunFrontEnd()
    {
        var studentService = new StudentService();

        while (true)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("1. Add Student:");
            Console.WriteLine("2. Update Student");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. Get all Student");
            Console.WriteLine("5. Get Students");
            Console.Write("Enter: ");
            
            var input = Console.ReadLine();

            if (input == "1")
            {
                var student = new Student();
                Console.Write("Enter first name: ");
                student.FirstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                student.LastName = Console.ReadLine();
                Console.Write("Enter email: ");
                student.Email = Console.ReadLine();
                Console.Write("Enter age: ");
                student.Age = int.Parse(Console.ReadLine());
                Console.Write("Enter phone number: ");
                student.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Degree: ");
                student.Degree = Console.ReadLine();
                Console.Write("Enter gender: ");
                student.Gender = Console.ReadLine();

                studentService.AddStudent(student);

            }
            else if (input == "2")
            {
                var student = new Student();
                Console.Write("Enter first name: ");
                student.FirstName = Console.ReadLine();
                Console.Write("Enter last name: ");
                student.LastName = Console.ReadLine();
                Console.Write("Enter email: ");
                student.Email = Console.ReadLine();
                Console.Write("Enter age: ");
                student.Age = int.Parse(Console.ReadLine());
                Console.Write("Enter phone number: ");
                student.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Degree: ");
                student.Degree = Console.ReadLine();
                Console.Write("Enter gender: ");
                student.Gender = Console.ReadLine();
                
                studentService.UpdateStudent(student);
            }
            else if (input == "3")
            {
                Console.Write("Enter id: ");
                var id = Guid.Parse(Console.ReadLine());
                var result = studentService.DeleteStudent(id);
                Console.WriteLine(result);
            }
            else if (input == "4")
            {
                var students = studentService.GetAllStudents();

                foreach (var student in students)
                {
                    string info = $"Id : {student.Id}, First name : {student.FirstName}, Last name : {student.LastName}," +
                                  $" Email : {student.Email}, Phone number : {student.PhoneNumber}, Age : {student.Age}," +
                                  $" Gender : {student.Gender}, degree: {student.Degree}";
                    Console.WriteLine($"{info}");
                }
            }
            else if (input == "5")
            {
                Console.Write("Enter id to get : ");
                var id = Guid.Parse(Console.ReadLine());
                
                var student = studentService.GetStudentById(id);
                string info = $"Id : {student.Id}, First name : {student.FirstName}, Last name : {student.LastName}," +
                              $" Email : {student.Email}, Phone number : {student.PhoneNumber}, Age : {student.Age}," +
                              $" Gender : {student.Gender}, degree: {student.Degree}";
                Console.WriteLine($"{info}");
            }

            Console.ReadKey();
            Console.Clear();
            
        }
    }
}