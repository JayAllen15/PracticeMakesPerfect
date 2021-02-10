using System;
namespace practiceMakesPerfect.PracticeProjects.DoctorsApp
{
    public class Doctors
    {
        public Doctors(string firstName,string lastName,string sex,int age)
        {
            _firstName = firstName;
            _lastName = lastName;
            _sex = sex;
            _age = age;
        }
        public string _firstName;
        public string _lastName;
        public string _sex;
        public int _age;

        public Patiant[] patiants;
        

        
            
            
    }
}
