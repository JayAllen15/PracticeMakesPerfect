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


        public int HeartRateStatus()
        {
            var random = new Random();
            var bpm = random.Next(60,100);
            return bpm;
        }


        public double TempratureStatus()
        {
            var random = new Random();
            var Temp = random.Next(91,101);
            return Temp;
        }

    }
}
