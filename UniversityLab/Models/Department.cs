using System.Collections.Generic;

namespace UniversityLab
{
    // Department from Week 6: aggregates students.
    public class Department
    {
        public string Name { get; set; }
        public string School { get; set; }
        public List<Student> Students { get; } = new List<Student>();

        public Department(string name, string school)
        {
            Name = name;
            School = school;
        }

        public void AddStudent(Student s)
        {
            if (!Students.Contains(s))
            {
                Students.Add(s);
                s.Department = this;
            }
        }
    }
}
