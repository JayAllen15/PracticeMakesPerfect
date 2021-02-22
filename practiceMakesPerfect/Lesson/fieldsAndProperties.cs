using System;
namespace practiceMakesPerfect.Lesson
{
    public class FieldsAndProperties
    {
        /*
        FIELDS & PROPERTIES     -  ONE OF THE MAIN REASONS FOR PROPERTIES IS SO WE CAN HAVE MORE CONTROL OVER OUR FEILDS,IF EVER WE HAVE A FEILD THAT IS EXPOSED
                              WE WOULD PUT THAT IN A PROPERTY AS A MAIN RULE IN PROGRAMMING IS NOT HAVE FEILDS/VERIABALS EXPOSED.A PROPERTY IS A FEILD ON
                              STERIODS AND ALSO ACTS LIKE A METHOD, IT GIVES US CONTROL OVER WHAT CAN BE ACCESSED AND CHANGED FROM OUTSIDE A CLASS.
                              A PROPERTY ALLOWS US TO GET A FEILD AND SET IT OR GET IT AND NOT SET IT WHERE A FEILD ONLY ALLOWS US TO GET IT AND SET IT FROM
                              OUTSIDE A CLASS IF IT IS SET TO PUBLIC, IF THE FIELD IS SET TO PRIVATE WE CAN NOT GET OR SET FROM OUTSIDE THE CLASS.prop code snippit
                              IF YOU TYPE PROP AND PRESS THE TAB KEY TWICE VISUAL STUDIOS WILL GENERATE THE STARTER CODE FOR A NEW PROPERTY YOU THEN USE THE TAB KEY
                              TO MOVE THROUGH EACH PART OF THE PROPERTY SO YOU CAN FILL IN WHAT YOU NEED, YOU CAN ONLY DO THIS IF YOU ARE USING BOTH THE GET AND SET
                              YOU CAN NOT DO THIS FOR JUST GET OR JUST SET AS IT WILL THROW A ERROR, THIS IS CALLED A AUTOMATIC PROPERTY. TO CALL A PROPERTY IN THE
                              APPLICATION YOU CALL THE NAMESPACE FOLLOWED BY ACCESS MEMBER/DOT NOTATION THEN THE NAME OF THE PROPERTY, IF WE ARE ADDING A VALUE
                              WE NEED THE EQUALS SIGN FOLLOWED BY OUR VALUE.
                              */
        private int speed;
        public int DriversSpeed
        {
            get
            {
                
                if (speed < 30)
                {
                    Console.WriteLine("YOU ARE UNDER THE SPEED LIMIT HAVE A NICE DAY");
                }
                else if (speed > 30 && speed <= 35)
                {
                    Console.WriteLine("YOU ARE ABOVE SPEED LIMIT BUT I WILL LET YOU OFF WITH NO TICKET THIS TIME");
                }
                else if (speed > 35 && speed <= 50)
                {
                    Console.WriteLine("SPEED TO HIGH £100 FINE AND 3 POINTS");
                }
                else if (speed > 50 && speed <= 70)
                {
                    Console.WriteLine("SPEED IS DANGEROUS 6 POINTS AND A 6 MONTH BAN");
                }
                else
                {
                    Console.WriteLine("YOU HAVE EARNT YOURSELF A £1000 FINE AND A 1 YEAR BAN");
                }
                return speed;
            }
            set
            {
               
                speed = value;
            }          
        }
        public void FieldsAndProperties1(string name,string car,string team,string birthplace)
        {
            Name = name;
            Car = car;
            Team = team;
            Birthplace = birthplace;           
        }

        public string Name { get; private set; }
        public string Car { get; private set; }
        public string Team { get; private set; }
        public string Birthplace { get; private set; }

        private int age;
        public int UserAge
        {
            get
            {                              
                if (age < 18)
                {
                  Console.WriteLine("SORRY USER TO YOUNG");
                }
                return age;                                  
            }
            set
            {
                age = value;
            }

        }
       
        
    }

}
           /*
           FieldsAndProperties fieldsAndProperties = new FieldsAndProperties();
           fieldsAndProperties.DriversSpeed = 45;
           Console.WriteLine(fieldsAndProperties.DriversSpeed);
           */
/*
FieldsAndProperties fieldsAndProperties = new FieldsAndProperties();
fieldsAndProperties.UserAge = 15;
if (fieldsAndProperties.UserAge <= -1)

Console.WriteLine(fieldsAndProperties.UserAge);

fieldsAndProperties.FieldsAndProperties1("Jay", "Merc", "Chelsea", "London");
Console.WriteLine(fieldsAndProperties.Name +" "+ fieldsAndProperties.Car +" "+ fieldsAndProperties.Team +" "+ fieldsAndProperties.Birthplace);
*/
