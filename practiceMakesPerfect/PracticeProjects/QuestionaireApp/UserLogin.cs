using System;
namespace practiceMakesPerfect.PracticeProjects.QuestionaireApp
{
    public class UserLogin
    {
        public string password;
        public void PassWordLogin()
        {

            Console.WriteLine("Please log in by entering your password");//instruction to user to enter password to login
            string password1 = Console.ReadLine();//users first attempt to match password with the password they made
            bool quiz = true;//setting condition as quiz always sats as true
            bool tries = true;//setting condition so tries will always start as true
            int p = 3; //setting condition for tries in the while loop
            while (tries)//setting while loop as tries which has already been set to true
            {

                if (password != password1)//statement set for if password and password1 are different
                {
                    p--;//p set to 3 statement set to minus 1 everytime it comes round in the loop
                    Console.Clear();//will clear all text before this point
                    Console.WriteLine($"sorry passwords dont match,tries remaining {p}");//message to user if password and password1 are different

                    var passwordTries = p != 0 ? "Please log in by entering your password" : "sorry you have had the maximum amount of tries ";
                    /*
                    if (p != 0)//statement set for if passwords are different and tries different to 0
                    {
                        Console.WriteLine("Please log in by entering your password");//message to user if conditions met
                        password1 = Console.ReadLine();//users password
                    }
                    else//if tries reaches 0 will move to this statement
                    {
                        Console.WriteLine("sorry you have had the maximum amount of tries ");//message for tries reaching 0
                        tries = false;//if if comes to this else statement tries will = false and breack loop
                        quiz = false;//if it comes to this else statement quiz will = false and break out of application
                    }
                    */
                }
                else//if passwords match will come to this else statement
                {
                    Console.WriteLine("password correct");//correct password message
                    tries = false;//if statemnt met will break out of loop
                }
            }
        }

        public string email;
        int w = 3;//second while loop w = 3
        bool tries1 = true;//condition set to tries1=true so tries1 will always start as true
        public void EmailLogin()
        {
            Console.Clear();//will clear all text before this point
            Console.WriteLine("please log in by entering email");//enter email message
            string email1 = Console.ReadLine();//users first attempt to match passwords

            while (tries1)//loop set for email attempts 
            {
                var emailsMatch = email != email1 ? "sorry emails dont match,tries remaining {w}" : "Thank you for entering password and email";
                if (email != email1)//if emails are different
                {
                    w--;//this will minus 1 from the 3 that w represents
                    Console.Clear();//clears all teaxt before this point
                    Console.WriteLine($"sorry emails dont match,tries remaining {w}");//message that passwords dont match
                    var emailTries = w != 0 ? "please enter email" : "sorry you have had the maximum amount of tries ";
                    /*
                    if (w != 0)//statement set for if w is different then 0
                    {
                        Console.WriteLine("please enter email");//message to user
                        email1 = Console.ReadLine();//users email
                    }
                    else//statement set for anything other then w being different from 0 which would mean to many tries1
                    {
                        Console.WriteLine("sorry you have had the maximum amount of tries ");//message telling user that there tries have run out
                        tries1 = false;//if condition met will break out of while loop (tries1 started at true this would make it false)
                        quiz1 = false;//will break out of appliction if condition meets false as it started as true(will break from if quiz1)
                    }
                    */
                }
                else//else if passwords are the same will move here
                {
                    Console.Clear();//clears all text before this point
                    Console.WriteLine("Thank you for entering password and email");//thank you message for correct password and email
                    tries1 = false;//if condition met will break out of while loop
                }
                
            }
            Console.WriteLine("you may now start the questionaire");//messagee to user that they may start

        }


        







    }
}
