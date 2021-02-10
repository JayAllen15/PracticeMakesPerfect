using System;

namespace practiceMakesPerfect.Lesson
{
    public class PlayingWithMethods
    {
        int _min;
        int _max;

        public PlayingWithMethods(int min, int max)
        {
             _min = min;
            _max = max;
        }

        public int RandomNumber()
        {
            var random = new Random();
            var number = random.Next(_min, _max);

            return number;

        }





    }



}
