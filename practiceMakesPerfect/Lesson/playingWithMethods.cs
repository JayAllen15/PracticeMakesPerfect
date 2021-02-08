using System;

namespace practiceMakesPerfect.Lesson
{
    public class playingWithMethods
    {

        public int RandomNumber()
        {
            var random = new Random();
            var number = random.Next(0, 100);

            return number;

        }





    }



}
