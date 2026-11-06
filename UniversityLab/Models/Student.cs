using System;

namespace UniversityLab
{
    // Student from Week 6: inherits from Person.
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Course { get; set; }

        // In the class this is a Department object; in the table it is a DepartmentId.
        public Department Department { get; set; }

        public Student(string nationalId, string name, DateTime dateOfBirth,
                       string phoneNumber, string address, string studentId, string course)
            : base(nationalId, name, dateOfBirth, phoneNumber, address)
        {
            StudentId = studentId;
            Course = course;
        }

        public override string GetRole()
        {
            return "Student";
        }
    }
}
