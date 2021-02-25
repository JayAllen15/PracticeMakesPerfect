using System;
namespace practiceMakesPerfect.PracticeProjects.Challenges
{
    public class PropertyChallenge
    {
        private int age;
        public int userAge
        {
            get
            {
                if(age<40)
                {
                    Console.WriteLine("STILL I RISE");
                }

                return age;
            }
            set
            {
                age = value;
            }
        }
        
        public PropertyChallenge(int number1,int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        public int[] numbers;
        public PropertyChallenge()
        {
             numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        public void Remainder()
        {
            Console.WriteLine(100% 20);
        }
        private string name;
        public void GetName()
        {
            Console.WriteLine(name);
        }

        public void SetName(string value)
        {
            name = value;
        }



    }  
    
}
