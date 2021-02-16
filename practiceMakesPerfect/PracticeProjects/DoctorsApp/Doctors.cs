using System;
namespace practiceMakesPerfect.PracticeProjects.DoctorsApp
{
    public class Doctors
    {
        public Doctors(string firstName, string lastName, string sex, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public Patiant[] patiants;




    }        
  
}
