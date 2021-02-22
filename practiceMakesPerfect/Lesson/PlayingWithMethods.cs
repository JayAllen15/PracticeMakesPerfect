using System;

namespace practiceMakesPerfect.Lesson
{
    public class PlayingWithMethods
    {
        int _number1 ;
        int _number2 ;
        string _name ;
        public PlayingWithMethods(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public PlayingWithMethods(int number1, int number2, string name)
        {
            _number1 = number1;
            _number2 = number2;
            _name = name;

        }
        public int RandomNumber()
        {
            var random = new Random();
            var number = random.Next(_number1, _number2);

            return number;

        }

        public void NameAndNumber()
        {

            Console.WriteLine();
        }

        public int Numbers(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

    }



}
