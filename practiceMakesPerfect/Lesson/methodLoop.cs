using System;
namespace practiceMakesPerfect.Lesson
{
    public class methodLoop
    {
        int i = 5;
        public void Attemtps()
        {
            //var i = 5;
            while(i == 5)
            {
                playingWithMethods playingWithMethods2 = new playingWithMethods();
                Console.WriteLine(playingWithMethods2.RandomNumber());
                Console.ReadLine();
                
            }
        }
    }
}
