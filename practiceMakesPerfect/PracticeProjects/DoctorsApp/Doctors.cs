using System;
namespace practiceMakesPerfect.PracticeProjects.DoctorsApp
{
    public class Doctors
    {
        public Doctors(string firstName, string lastName, string sex, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Sex = sex;
            Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }

        public Patiant[] patiants;




    }        
  
}
           /*
           WellBeingCheck newCheck = new WellBeingCheck();

           Doctors dr1 = new Doctors("Dr Harry","Wright","Male",36);

           Doctors dr2 = new Doctors("Dr Sally","Hilson","Female",55);

           Doctors dr3 = new Doctors("Dr Ralph","Davies","Male",60);

           Doctors dr4 = new Doctors("Dr Alice","Daley","Female",59);

           Doctors dr5 = new Doctors("Dr Elvis","Crow","Male",60);


           Patiant patiant1 = new Patiant("Tony","Harrison","07/07/75",83,6,dr1);

           Patiant patiant2 = new Patiant("Alex","Harrison","01/03/80",99,6,dr1);

           Patiant patiant3 = new Patiant("Lucy","Lashley","22/12/79",60,5,dr2);

           Patiant patiant4 = new Patiant("Tracy","Lashley","22/12/79",67,5,dr2);

           Patiant patiant5 = new Patiant("Derrick","Armstrong","09/11/88",102,5,dr3);

           Patiant patiant6 = new Patiant("Sarah","Prince","05/05/69",71,5,dr3);

           Patiant patiant7 = new Patiant("Lee","Crow","28/08/90",86,6,dr4);

           Patiant patiant8 = new Patiant("Dean","Ali","02/03/77",105,6,dr4);

           Patiant patiant9 = new Patiant("Lin","hoy","01/12/85",93,6,dr5);

           Patiant patiant10 = new Patiant("Derrick","Whiteman","15/07/82",63,5,dr5);


           dr1.patiants = new Patiant[2];
           dr1.patiants[0] = patiant1;
           dr1.patiants[1] = patiant2;

           dr2.patiants = new Patiant[2];
           dr2.patiants[0] = patiant3;
           dr2.patiants[1] = patiant4;

           dr3.patiants = new Patiant[2];
           dr3.patiants[0] = patiant5;
           dr3.patiants[1] = patiant6;

           dr4.patiants = new Patiant[2];
           dr4.patiants[0] = patiant7;
           dr4.patiants[1] = patiant8;

           dr5.patiants = new Patiant[2];
           dr5.patiants[0] = patiant9;
           dr5.patiants[1] = patiant10;



           patiant1.PatiantDetails();
           patiant1.BmiStatus();

           patiant1.TempratureStatus();

           patiant1.HeartRateStatus();
           */
