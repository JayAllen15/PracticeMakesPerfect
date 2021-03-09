using System;
namespace practiceMakesPerfect.PracticeProjects.QuestionaireApp
{
    public class SignUp
    {
        public string[] userEmails;
        public void EmailSorage()
        {
            userEmails = new string[10];//array set to store useremails maximum of 10
        }

        public string[] userPasswords;
        public void PasswordStorage()
        {
            userPasswords = new string[10];//array set to store 10 user passwords
        }

        //storing whatever user types as firstname
        //public string firstname = "";//storing what user types as surname
        //public string email = "";//storing what user types as email
        //public string password = "";// storing what user types as password
        //public bool passwords = true;//condition set to start as true
        //public int count = 0;//count set to start as zero in the while loop
        //public bool emails = true;//set as emails are always true
        public void UserLogin()
        {
            bool passwords = true;
            bool emails = true;
            int count = 0;
            while (emails || passwords && count <= 10)//while email or passwords and count is less then or equal to 10 keep looping
            {
                Console.WriteLine("please complete registration in order to take part in quiz, press enter after each answer");//instruction for user to register              
                Console.WriteLine("what is your first name ?");//first instruction
                string firstname = "";
                firstname = Console.ReadLine();//users first name
                Console.WriteLine("what is your surname");//second instruction
                string surname = "";
                surname = Console.ReadLine();//users second name
                string email = "";
                Console.WriteLine("please enter your email");//third instruction
                
                email = Console.ReadLine();//users email address
                for (int i = 0; i < userEmails.Length; i++)//forloop set to loop through email array
                {
                    if (userEmails[i] == email)//if useremails and email are the same 
                    {
                        Console.WriteLine("please enter a new email");//if the same will print this message
                        email = Console.ReadLine();//user re enter email
                        i = 0;//this will reset i back to zero for the start of new loop
                    }

                }
                string password = "";
                Console.WriteLine("please make a password");//fourth instruction
                password = Console.ReadLine();//users password
                userPasswords[count] = password;// set to store password in the array and change with the count
                userEmails[count] = email;//set to store email in the array and change with the count
                Console.Clear();//clearing all inputs before this point
                Console.WriteLine("Congratulations you are now signed up");//message to user on being signed up
                Console.WriteLine("would you like to sign up anybody else , type no if you dont or anything else if you do?");//message to user
                string signupamount = Console.ReadLine();//user input
                if (signupamount == "no")//if signupamount is NO 
                {
                    emails = false;//emails set to false if this is met it will break out of loop
                }
                count++;//count starts at zero this will add 1 onto the count everytime it gos round the while loop
            }
        }

        public void SignUpWinner()
        {

            foreach (var userEmail in userEmails)//set to store a user email from the list of emails in array
            {
                Console.WriteLine(userEmail);//message to user
            }
            var random = new Random();//a random number array has been set
            var randomNumber = random.Next(0, 6);//asking for a random number between 0 and 6 digits long
            Console.WriteLine("The winner of the comp is");//message to user
            Console.WriteLine(userEmails[randomNumber]);//a random email from the email array will be printed
        }

    }
}
