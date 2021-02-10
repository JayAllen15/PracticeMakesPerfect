using System;
namespace practiceMakesPerfect.PracticeProjects.DoctorsApp
{
    public class Patiant
    {
        public Patiant(string firstName,string lastName,string dob,int weight,int height,Doctors doctor)
        {
            _firstName = firstName;
            _lastName = lastName;
            _dob = dob;         
            _weight = weight;
            _height = height;          
            _doctor = doctor;
        }
        public string _firstName;
        public string _lastName;
        public string _dob;       
        public int _weight;
        public int _height;
        public int _bmi;
        public int _temprature;
        public int _heartRate;
        public Doctors _doctor;



        public void PatiantDetails()
        {


            Console.WriteLine(_firstName + "\n" + _lastName + "\n" + _dob + "\n" + _weight + "\n"
                              + _height + "\n" + _doctor._firstName + " " + _doctor._lastName);
        }


        public void BmiStatus()
        {

            if (_bmi < 18)
            {
                Console.WriteLine("YOU ARE UNDERWEIGHT AS YOUR BMI IS BELOW 18");
            }
            else if (_bmi > 18 && _bmi < 24)
            {
                Console.WriteLine("YOUR WEIGHT IS NORMAL AS ITS BETWEEN 18 AND 24");
            }
            else if (_bmi > 24.1 && _bmi < 29)
            {
                Console.WriteLine("YOUR OVERWEIGHT AS YOUR WEIGHT IS ABOVE 24 TRY GETTING IT BELOW 18 AND 24");
            }
            else if (_bmi > 29.1 && _bmi < 34)
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
            if(_temprature < 94)
            {
                Console.WriteLine("YOUR TEMPRATURE IS OK BUT IF IT DROPS ANYMORE WE MIGHT HAVE TO TAKE SOME TESTS");
            }
            else if(_temprature >= 94 && _temprature <= 98 )
            {
                Console.WriteLine("YOUR TEMPRATURE IS NORMAL");
            }
            else if(_temprature >= 99)
            {
                Console.WriteLine("YOU HAVE A HIGH TEMPRATURE IF ITS STILL HIGH IN A COUPLE DAYS COME BACK AND SEE ME");
            }
        }

        public void HeartRateStatus()
        {
            if(_heartRate <= 70)
            {
                Console.WriteLine("YOUR HEARTRATE IS BELOW 70 WHICH IS A VERY GOOD RATE");
            }
            else if(_heartRate > 70 && _heartRate < 90)
            {
                Console.WriteLine("YOU HAVE A NORMAL HEARTRATE");
            }
            else if(_heartRate >= 90 && _heartRate < 98)
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
