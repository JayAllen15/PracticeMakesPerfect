using System;
namespace practiceMakesPerfect.PracticeProjects.QuestionaireApp
{
    public class Questinaire
    {
        //make a questionaire that functions with the different statements that we have learnt.
        //make sure there are no bugs in the programe when the programe is run.
        //create console register/login and a guessing game 
        static void Questionaire()
        {

            var random = new Random();//a random number array has been set
            var randomNumber = random.Next(0, 6);//asking for a random number between 0 and 6 digits long

            Console.WriteLine(); //message to user

            string[] useremails = new string[10];//array set to store useremails maximum of 10
            {

            }
            bool emails = true;//set as emails are always true
            bool quiz1 = true;//quiz1 set to always start as true until broken by a false statement
            int w = 3;//second while loop w = 3
            bool tries1 = true;//condition set to tries1=true so tries1 will always start as true
            int p = 3; //setting condition for tries in the while loop
            bool tries = true;//setting condition so tries will always start as true
            bool quiz = true;//setting condition as quiz always sats as true
            string firstname = "";//storing whatever user types as firstname
            string email = "";//storing what user types as email
            string surname = "";//storing what user types as surname
            string password = "";// storing what user types as password
            int count = 0;//count set to start as zero in the while loop

            string[] userpasswords = new string[10];//array set to store 10 user passwords
            {

            }
            bool passwords = true;//condition set to start as true

            while (emails || passwords && count <= 10)//while email or passwords and count is less then or equal to 10 keep looping
            {
                Console.WriteLine("please complete registration in order to take part in quiz, press enter after each answer");//instruction for user to register              
                Console.WriteLine("what is your first name ?");//first instruction
                firstname = Console.ReadLine();//users first name
                Console.WriteLine("what is your surname");//second instruction
                surname = Console.ReadLine();//users second name
                Console.WriteLine("please enter your email");//third instruction
                email = Console.ReadLine();//users email address
                for (int i = 0; i < useremails.Length; i++)//forloop set to loop through email array
                {
                    if (useremails[i] == email)//if useremails and email are the same 
                    {
                        Console.WriteLine("please enter a new email");//if the same will print this message
                        email = Console.ReadLine();//user re enter email
                        i = 0;//this will reset i back to zero for the start of new loop
                    }

                }

                Console.WriteLine("please make a password");//fourth instruction
                password = Console.ReadLine();//users password
                userpasswords[count] = password;// set to store password in the array and change with the count
                useremails[count] = email;//set to store email in the array and change with the count
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

            foreach (var userEmail in useremails)//set to store a user email from the list of emails in array
            {
                Console.WriteLine(userEmail);//message to user
            }
            Console.WriteLine("The winner of the comp is");//message to user
            Console.WriteLine(useremails[randomNumber]);//a random email from the email array will be printed

            Console.WriteLine("Please log in by entering your password");//instruction to user to enter password to login
            string password1 = Console.ReadLine();//users first attempt to match password with the password they made

            while (tries)//setting while loop as tries which has already been set to true
            {
                if (password != password1)//statement set for if password and password1 are different
                {

                    p--;//p set to 3 statement set to minus 1 everytime it comes round in the loop
                    Console.Clear();//will clear all text before this point
                    Console.WriteLine($"sorry passwords dont match,tries remaining {p}");//message to user if password and password1 are different

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


                }
                else//if passwords match will come to this else statement
                {
                    Console.WriteLine("password correct");//correct password message
                    tries = false;//if statemnt met will break out of loop
                }

            }

            if (quiz)//if quiz == false statement met will break application from this point
            {
                Console.Clear();//will clear all text before this point
                Console.WriteLine("please log in by entering email");//enter email message
                string email1 = Console.ReadLine();//users first attempt to match passwords

                while (tries1)//loop set for email attempts 
                {

                    if (email != email1)//if emails are different
                    {
                        w--;//this will minus 1 from the 3 that w represents
                        Console.Clear();//clears all teaxt before this point
                        Console.WriteLine($"sorry emails dont match,tries remaining {w}");//message that passwords dont match


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


                    }
                    else//else if passwords are the same will move here
                    {
                        Console.Clear();//clears all text before this point
                        Console.WriteLine("Thank you for entering password and email");//thank you message for correct password and email
                        tries1 = false;//if condition met will break out of while loop

                    }
                }



                if (quiz1)//condition set as if email fails 3 times will break application from this point
                {


                    Console.WriteLine("you may now start the questionaire");//messagee to user that they may start



                    string[] PremierLeagueTeams = new string[20]; //array set to list all premier league teams,20 different choice options for applicants input
                    {
                        PremierLeagueTeams[0] = "liverpool";
                        PremierLeagueTeams[1] = "manchester city";
                        PremierLeagueTeams[2] = "chelsea";
                        PremierLeagueTeams[3] = "tottenham";
                        PremierLeagueTeams[4] = "arsenal";
                        PremierLeagueTeams[5] = "everton";
                        PremierLeagueTeams[6] = "west brom";
                        PremierLeagueTeams[7] = "wolves";
                        PremierLeagueTeams[8] = "burnley";
                        PremierLeagueTeams[9] = "fulham";
                        PremierLeagueTeams[10] = "southampton";
                        PremierLeagueTeams[11] = "cristal palace";
                        PremierLeagueTeams[12] = "west ham";
                        PremierLeagueTeams[13] = "newcastle";
                        PremierLeagueTeams[14] = "leeds";
                        PremierLeagueTeams[15] = "leicester";
                        PremierLeagueTeams[16] = "aston villa";
                        PremierLeagueTeams[17] = "brighton";
                        PremierLeagueTeams[18] = "sheffield united";
                        PremierLeagueTeams[19] = "manchester united";


                    }

                    //Tell the user u have to be registered and signed in before they can start

                    //Ask user for there first name

                    //Ask user for there surname

                    //Ask user for there email

                    //Ask user for there password

                    //Ask user to repeat there password

                    /*Verify the two password matches if it dont tell user it dont match and make them re enter passoword twice again and check they match give the user
                     3 chances if they dont end the quiz */

                    //Make user log in and give them 3 chances to enter password and user name correct if they log in successful give them a successful login message and begin the quiz


                    Console.WriteLine("Whats your name? please press enter once you have typed your answers!");//first question 
                    string name = Console.ReadLine(); //applicants answer
                    string team = "";        //declaring veriable so we can use team more then once 
                    string compsupports = PremierLeagueTeams[0]; //set the team that the computer supports
                    string lowerCaseTeam = ""; //declaring veriable so we can use team more then once
                    bool matchTeam = false;   //set to false so has to enter while loop

                    int t = 1;  //condition set so we can count upwards
                    int i = 3;  //condition set so the maximum chances is 3 in the while loop
                    bool count2 = true; //condition set to true so will automatically move into foreach loop
                    while (count2) //condition set to count thru prem teams
                    {
                        Console.WriteLine("What football team do you support " + name + " ?"); // second question
                        team = Console.ReadLine(); //applicants answer
                        lowerCaseTeam = team.ToLower(); //will turn applicants input into lower case letters
                        foreach (var premTeam in PremierLeagueTeams) //condition set to go thru all 20 teams in arrey
                        {
                            if (premTeam == lowerCaseTeam) //if prem team is same as computer team it will move to matchteam
                            {

                                matchTeam = true;  //if premteam and lowercaseteam is the same condition would be true and go down to break
                                break;      //if premteam and lowercaseteam are the same = true then will break out of foreach loop
                            }
                        }


                        if (matchTeam == false)   //if matchteam = false will move to the else statement 
                        {
                            i--; // 3 take away 1

                            if (i == 0) //when 3 go's down to zero will print this if statement
                            {
                                Console.WriteLine(team + " is not a premier league team but lets move on");//message to user
                            }
                            else//else statement set incase if statement not met
                            {
                                Console.WriteLine($"this is not a premier league team, tries remaining {i}");//message to user
                            }

                        }

                        if (matchTeam || t == 3) //if the matchteam or 1 is equal to 3 then condition will be false
                        {
                            count2 = false; // set to false to continue to count thru while loop chances
                        }

                        t++; // will add 1 onto the chances to complete correct answer because its in the while loop


                    }

                    if (matchTeam) //next condition set incase all other if statements are not met
                    {
                        if (lowerCaseTeam == compsupports) //if applicants team is the same as liverpool then will print this if statment
                        {
                            Console.WriteLine("looks like we both support the best team " + name);//message to user
                        }
                        else // if a team from the array is chosen will print this else statement
                        {
                            Console.WriteLine(team + " are not better than liverpool " + name);//message to user
                        }
                    }


                    Console.WriteLine("to continue with questionaire type yes then enter or just press enter to end");//message to user
                    string f = "no"; // storing veriable
                    string k = "yes";  //storing veriable
                    string answer = Console.ReadLine(); // applicants answer
                    string yesorno = answer.ToLower();// set so whatever letters are input will convert to lowercase letters
                    if (yesorno == k) // if input is yes will ask next question
                    {
                        Console.WriteLine("who do you think will win the world cup ?");//message to user
                    }
                    else if (answer == f || answer != k)//if input is NO or input is different to yes will print this else if statement
                    {
                        Console.WriteLine("thank you " + name);//message to user
                    }

                    string[] register = new string[10]; // new array set with 10 different countries 
                    {
                        register[0] = "brazil";
                        register[1] = "spain";
                        register[2] = "holland";
                        register[3] = "france";
                        register[4] = "belgium";
                        register[5] = "england";
                        register[6] = "argentina";
                        register[7] = "italy";
                        register[8] = "croatia";
                        register[9] = "germany";
                    }
                    string worldcupwinners = Console.ReadLine(); //whoever they think will win worldcup
                    string lowercountry = worldcupwinners.ToLower(); //turns input into lower case letters
                    if (lowercountry == register[0] || lowercountry == register[3] || lowercountry == register[9])//if answer is brazil,france or germany will print nxt if statement
                    {
                        Console.WriteLine("i agree " + name + " they have a good chance");

                    }
                    else if (lowercountry == register[5]) //if input is the same as england print this else if statement
                    {
                        Console.WriteLine("wow " + name + " you must be english");

                    }
                    else if (lowercountry == register[1]) //if input is the same as spain print this else if statement
                    {

                        Console.WriteLine("would you put your house on that ? " + name);
                    }
                    else //if input is different to all countries in array print this else statement 
                    {

                        Console.WriteLine("you must know something i dont " + name);
                    }
                    string[] sports = new string[10]; //new array set
                    {
                        sports[0] = "basketball";
                        sports[1] = "american football";
                        sports[2] = "baseball";
                        sports[3] = "boxing";
                        sports[4] = "mma";
                        sports[5] = "rugby";
                        sports[6] = "tennis";
                        sports[7] = "athletics";
                        sports[8] = "cricket";
                        sports[9] = "badminton";
                    }
                    Console.WriteLine("is football your fav sport yes or no ?"); // next question
                    string answer1 = Console.ReadLine(); // applicants answer
                    string loweranswer1 = answer1.ToLower(); //will turn the input into lowercase letters
                    if (loweranswer1 == k) // if answer is YES will print this if statment
                    {
                        Console.WriteLine("i agree " + name + " best sport in the world");//message to user
                        Console.WriteLine("who do you think is the better player MESSI or RONALDO ?");//question to user
                        string bestplayer = Console.ReadLine();//user reply to question
                        string lowerbestplayer = bestplayer.ToLower();//turn user reply to all lower case 
                        if (lowerbestplayer == "messi")//if statement set for if =
                        {
                            Console.WriteLine("i agree " + name + " i think messi is a more gifted player");//message to user 
                        }
                        else if (lowerbestplayer == "ronaldo")//else if = statement set
                        {
                            Console.WriteLine("ronaldo is amazing but i think he has had to work harder to be were he is, i think it comes more natural to messi");//message to user
                        }
                        else if (lowerbestplayer != "messi" || lowerbestplayer != "ronaldo")//else if different and differnet statement set
                        {
                            Console.WriteLine("think you miss read the question or spelt something wrong lets just move on " + name);//message to user 
                        }

                    }
                    else if (answer1 == f) //if answer is NO will print this else if statement
                    {
                        Console.WriteLine("so what is your favourite sport ?");
                        string favsport = Console.ReadLine(); //aplicants answer
                        string lowerfavsport = favsport.ToLower(); //will turn input into lower case letter
                        if (lowerfavsport == sports[3] || lowerfavsport == sports[4]) //if answer is the same as boxing or mma will print this if statement
                        {
                            Console.WriteLine("you like abit of blood " + name);
                        }
                        else if (lowerfavsport == sports[1] || lowerfavsport == sports[5]) //if answer is same as american football or rugby will print this else if statement
                        {
                            Console.WriteLine("that is a rough tackling sport " + name);
                        }
                        else if (lowerfavsport == sports[0]) //if answer is the same as basketball will print this else if statement
                        {
                            Console.WriteLine("yeah basketball is alright rest in peace kobe");
                        }
                        else if (lowerfavsport == sports[6]) //if answer is the same as tennis will print this else if statement
                        {
                            Console.WriteLine(" fair enough " + name + " i dont mind tennis");
                        }
                        else //if the answer is not the same as any of the above statements will print this
                        {
                            Console.WriteLine("each to there own " + name);
                        }
                    }
                    Console.WriteLine("ok " + name + " last question, where will chelsea finish this season 1st-20th ?"); //last question
                    string reply = Console.ReadLine(); //applicants answer
                    string lowerreply = reply.ToLower(); //turns answer into lowercase letters
                    string a = "first"; // storing veriable
                    string b = "second"; // storing veriable
                    if (lowerreply == a || lowerreply == "1" || lowerreply == "top" || lowerreply == "1st" || lowerreply == "top of the league" || lowerreply == "top of the table" || lowerreply == "1st in the league" || lowerreply == "champions") //if answer is first,1,top,1st,top of the league or top of the table will print this if statement
                    {
                        Console.WriteLine("i hope your right " + name + " thank you for taking part");//message to user 

                    }
                    else if (lowerreply == b || lowerreply == "2" || lowerreply == "2nd" || lowerreply == "runners up" || lowerreply == "2nd in the league") //if answer is second,2,2nd or runners up will print this else if statement
                    {
                        Console.WriteLine("well i was hoping for 1 place better to be honest but thank you for taking part " + name);//message to user
                    }
                    else if (lowerreply != a || lowerreply != b) //if answer is different from first or different from second will print this else if statement
                    {
                        Console.WriteLine("i only wanted to see 1st so im done with you now bye " + name + " the joker");//message to user
                    }

                }
            }
        }
    }
              
}
