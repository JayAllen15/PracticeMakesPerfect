using System;
namespace practiceMakesPerfect.PracticeProjects.DoctorsApp
{
    public class WellBeingCheck
    {
        public int heartRate;
        public int bloodPressure;
        public int temprature;

        public int Bmi(int weight , int height)
        {

            return weight / height + height;
        }

        public int Temprature()
        {
            var random = new Random();
            var temp = random.Next(91, 101);
            return temp;
        }

        public int HeartRate()
        {
            var random = new Random();
            var bpm = random.Next(60, 104);
            return bpm;
        }


    }
}
