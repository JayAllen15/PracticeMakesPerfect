using System;
namespace practiceMakesPerfect.PracticeProjects.DoctorsApp
{
    public class Patiant
    {
        public string firstname;
        public string lastname;
        public string dob;
        public int bmi;
        public int weight;
        public int height;
        public Doctors doctor;


        public void PatiantDetails()
        {


            Console.WriteLine(firstname +"\n"+ lastname +"\n"+ dob +"\n"+ weight +"\n"
                              + height +"\n"+ doctor.firstName +" "+doctor.lastName);
        }

        
        public void BmiStatus()
        {
            
         
            if(bmi < 18)
            {
                Console.WriteLine("YOU ARE UNDERWEIGHT AS YOUR BMI IS BELOW 18");
            }
            else if(bmi>18 && bmi<24)
            {
                Console.WriteLine("YOUR WEIGHT IS NORMAL AS ITS BETWEEN 18 AND 24");
            }
            else if(bmi>24.1 && bmi<29)
            {
                Console.WriteLine("YOUR OVERWEIGHT AS YOUR WEIGHT IS ABOVE 24 TRY GETTING IT BELOW 18 AND 24");
            }
            else if(bmi>29.1 && bmi<34)
            {
                Console.WriteLine("YOUR WEIGHT IS CLASSED AS OBEASE YOU REALLY NEED TO GET IT DOWN, A NORMAL WEIGHT IS BETWEEN 18 AND 24");
            }
            else
            {
                Console.WriteLine("YOU ARE IN THE CATORGRY OF EXTREMALLY OBEASE ABOVE 35 IS WORRING");
            }

           

        }
        public int TempratureStatus()
        {
            var random = new Random();
            var Temp = random.Next(91, 101);
            return Temp;
        }
    }
}
