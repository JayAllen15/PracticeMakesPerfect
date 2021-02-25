using System;
using practiceMakesPerfect.Lesson;
using practiceMakesPerfect.PracticeProjects.DoctorsApp;
using practiceMakesPerfect.PracticeProjects.MultiplicationGameApp;
using practiceMakesPerfect.PracticeProjects.Challenges;
namespace practiceMakesPerfect
{
    class Program
    {

        static void Main(string[] args)
        {
            var newPC = new PropertyChallenge();

            newPC.userAge = 37;
            Console.WriteLine(newPC.userAge);

            var newPC1 = new PropertyChallenge(10,10);

            Console.WriteLine(newPC.numbers[6]);

            newPC.Remainder();

            newPC.SetName("Nortz");
            newPC.GetName();


            


            
           

           

           

        }


    }
 
}
           /*
           string[] names = new string[10] { "Nortz", "Paul", "Peter", "Alex", "John", "Lee", "Betty", "Sally", "Lisa", "Jane" };

           int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8 ,9 ,10};

           bool[] trueOrFalse = new bool[10] { true,true,true,true,true,false,false,false,false,false};

           Console.WriteLine($"{names[0]} {numbers[6]} {trueOrFalse[3]}\n{names[8]} {numbers[3]} {trueOrFalse[8]}");

           Doctors[] doctors = new Doctors[2] { new Doctors() { FirstName = "Larry", LastName = "Littlez", Sex = "?", Age = 46}, new Doctors() { FirstName = "James", LastName = "Allen", Sex = "male",Age = 37 } };

           foreach(var doctor in doctors)
           {
               Console.WriteLine($"Doctor Name = ({doctor.FirstName} {doctor.LastName}) Doctors Gender = ({doctor.Sex}) Doctors Age = ({doctor.Age})");
           }
           */


   /*
   for (int i = 1;i <= 100;i++)
   {
       if(i % 3 == 0 && i % 5 == 0)
       {
           Console.WriteLine("FIZZ BUZZ");
       }
       else if(i % 3 == 0 )
       {
           Console.WriteLine("FIZZ");
       }
       else if(i % 5 == 0)
       {
           Console.WriteLine("BUZZ");
       }
       else
       {
           Console.WriteLine(i);
       }
   }
   */
















