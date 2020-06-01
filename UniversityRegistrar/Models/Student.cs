using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseStudent>();
    }
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ICollection<CourseStudent> Courses { get; }
  }
}