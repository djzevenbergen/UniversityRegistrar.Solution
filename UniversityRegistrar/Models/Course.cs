using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public Course()
    {
      this.Students = new HashSet<CourseStudent>(); // Hashset is an unordered collection of unique elements (more performant than a List but doesnt allow duplicates)
    }

    public int CourseId { get; set; }
    public string Name { get; set; }
    public ICollection<CourseStudent> Students { get; set; } // generic interface - collection of method signatures bundled together.
                  // ICollection required by Entity to outline methods for querying and changing data.
                  // <CourseStudent> is a collection navigation property for many to many relationship
  }
}