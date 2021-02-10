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
                PlayingWithMethods playingWithMethods2 = new PlayingWithMethods(7,17);
                Console.WriteLine(playingWithMethods2.RandomNumber());
                Console.ReadLine();
                
            }
        }
    }
}
