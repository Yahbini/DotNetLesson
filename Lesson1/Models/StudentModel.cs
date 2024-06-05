namespace Lesson1.Models;

public class StudentModel
{
    private List<Student> students;

    public StudentModel()
    {
        students = new List<Student>()
        {
            new Student()
            {
                Id = 1,
                Name = "Name 1",
                courses = new List<Course>
                {
                    new Course()
                    {
                        Id=1,
                        Name ="Math",
                        Score=8
                    },
                    new Course()
                    {
                        Id=2,
                        Name="Geography",
                        Score=9.5
                    }
                }
            },
            new Student()
            {
                Id = 2,
                Name = "Name 2",
                courses = new List<Course>
                {
                    new Course()
                    {
                        Id=1,
                        Name="Math",
                        Score=6.5
                    },
                    new Course()
                    {
                        Id=2,
                        Name="Geography",
                        Score=5
                    }
                }
            },
            new Student()
            {
                Id = 3,
                Name = "Name 3",
                courses = new List<Course>
                {
                    new Course()
                    {
                        Id=1,
                        Name="Math",
                        Score=8.5
                    },
                    new Course()
                    {
                        Id=2,
                        Name="Geography",
                        Score=6
                    },
                    new Course()
                    {
                        Id=3,
                        Name="Biography",
                        Score=4
                    }
                }
            }
        };
    }

    public List<Student> findAll()
    {
        return students;
    }

    public Student find(int id)
    {
        return students.SingleOrDefault(s => s.Id == id);
    }
}
