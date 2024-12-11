using CRUD_School.Models;

namespace CRUD_School.Services;

public class StudentService
{
    private List<Student> students;

    public StudentService()
    {
        students = new List<Student>();
    }

    public Student AddStudent(Student student)
    {
        student.Id = Guid.NewGuid();
        students.Add(student);

        return student;
    }

    public Student GetStudentById(Guid id)
    {
        foreach (var student in students)
        {
            if (student.Id == id)
            {
                return student;
            }
        }

        return null;
    }

    public bool UpdateStudent(Student student)
    {
        var studentFromDb = GetStudentById(student.Id);

        if (studentFromDb is null)
        {
            return false;
        }
        else
        {
            var index = students.IndexOf(studentFromDb);
            students[index] = student;
            return true;
        }
    }

    public bool DeleteStudent(Guid studentId)
    {
        var exists = false;
        foreach(var student in students)
        {
            if(student.Id == studentId)
            {
                students.Remove(student);
                exists = true;
                break;
            }
        }

        return exists;
    }

    public List<Student> GetAllStudents()
    {
        return students;
    }
}