using System;
using practiceMakesPerfect.Lesson;
using practiceMakesPerfect.PracticeProjects.DoctorsApp;
using practiceMakesPerfect.PracticeProjects.MultiplicationGameApp;

namespace practiceMakesPerfect
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] names = new string[10] { "Nortz", "Paul", "Peter", "Alex", "John", "Lee", "Betty", "Sally", "Lisa", "Jane" };
           

            int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8 ,9 ,10};
            

            bool[] trueOrFalse = new bool[10] { true,true,true,true,true,false,false,false,false,false};


            Console.WriteLine( names[0] + " " + numbers[6] + " " + trueOrFalse[3] +"\n"+
                               names[8] + " " + numbers[3] + " " + trueOrFalse[8]);



            

        }


    }
 
}
 
           

        


    






       



    

  
