using System;
namespace practiceMakesPerfect.PracticeProjects.DoctorsApp
{
    public class Patiant
    {
        public Patiant(string firstName,string lastName,string dob,int weight,int height,Doctors doctor)
        {
            FirstName = firstName;
            LastName = lastName;
            Dob = dob;         
            Weight = weight;
            Height = height;          
            Doctor = doctor;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Dob { get; set; }      
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Bmi { get; set; }
        public int Temprature { get; set; }
        public int HeartRate { get; set; }
        public Doctors Doctor { get; set; }



        public void PatiantDetails()
        {


            Console.WriteLine(FirstName + "\n" + LastName + "\n" + Dob + "\n" + Weight + "\n"
                              + Height + "\n" + Doctor.FirstName + " " + Doctor.LastName);
        }


        public void BmiStatus()
        {

            if (Bmi < 18)
            {
                Console.WriteLine("YOU ARE UNDERWEIGHT AS YOUR BMI IS BELOW 18");
            }
            else if (Bmi > 18 && Bmi < 24)
            {
                Console.WriteLine("YOUR WEIGHT IS NORMAL AS ITS BETWEEN 18 AND 24");
            }
            else if (Bmi > 24.1 && Bmi < 29)
            {
                Console.WriteLine("YOUR OVERWEIGHT AS YOUR WEIGHT IS ABOVE 24 TRY GETTING IT BELOW 18 AND 24");
            }
            else if (Bmi > 29.1 && Bmi < 34)
            {
                Console.WriteLine("YOUR WEIGHT IS CLASSED AS OBEASE YOU REALLY NEED TO GET IT DOWN, A NORMAL WEIGHT IS BETWEEN 18 AND 24");
            }
            else
            {
                Console.WriteLine("YOU ARE IN THE CATORGRY OF EXTREMALLY OBEASE ABOVE 35 IS WORRING");
            }
        }

       
        public void TempratureStatus()
        {
            if(Temprature < 94)
            {
                Console.WriteLine("YOUR TEMPRATURE IS OK BUT IF IT DROPS ANYMORE WE MIGHT HAVE TO TAKE SOME TESTS");
            }
            else if(Temprature >= 94 && Temprature <= 98 )
            {
                Console.WriteLine("YOUR TEMPRATURE IS NORMAL");
            }
            else if(Temprature >= 99)
            {
                Console.WriteLine("YOU HAVE A HIGH TEMPRATURE IF ITS STILL HIGH IN A COUPLE DAYS COME BACK AND SEE ME");
            }
        }

        public void HeartRateStatus()
        {
            if(HeartRate <= 70)
            {
                Console.WriteLine("YOUR HEARTRATE IS BELOW 70 WHICH IS A VERY GOOD RATE");
            }
            else if(HeartRate > 70 && HeartRate < 90)
            {
                Console.WriteLine("YOU HAVE A NORMAL HEARTRATE");
            }
            else if(HeartRate >= 90 && HeartRate < 98)
            {
                Console.WriteLine("YOUR HEARTRATE IS ON THE HIGHSIDE I WOULD RECOMEND MORE EXERCISE");
            }
            else
            {
                Console.WriteLine("YOUR HEARTRATE IS TO HIGH YOU WILL NEED TO SEE NURSE FOR SOME TESTS");
            }
        }
    }
}
