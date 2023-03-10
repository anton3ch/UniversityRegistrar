
using System.Collections.Generic;

namespace Registrar.Models
{
  public class Course
  {
    public int CourseId { get; set; }
    public string Name { get; set; }
    public string Number { get; set; }
    public List<CourseStudent> JoinEntities { get; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
  }
}