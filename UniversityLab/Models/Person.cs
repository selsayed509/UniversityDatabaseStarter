using System;

namespace UniversityLab
{
    // Person from Week 6: abstract, so there is no plain "Person" object.
    public abstract class Person
    {
        public string NationalId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public Person(string nationalId, string name, DateTime dateOfBirth,
                      string phoneNumber, string address)
        {
            NationalId = nationalId;
            Name = name;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public virtual string GetContactInfo()
        {
            return Name + ", " + PhoneNumber + ", " + Address;
        }

        public abstract string GetRole();
    }
}
