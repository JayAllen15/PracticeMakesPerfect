using System;
namespace practiceMakesPerfect.PracticeProjects.QuestionaireApp
{
    public class PremTeams
    {
        public string[] AllPreamTeams { get { return PremierLeagueTeams; } }
        private string[] PremierLeagueTeams;
        public PremTeams()
        {
          string[] PremierLeagueTeams = new string[20]; //array set to list all premier league teams,20 different choice options for applicants input
       
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

        public void UsersTeam()
        {

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
                    i--;
                    var matchteamFalse = i == 0 ? team + " is not a premier league team but lets move on" : $"this is not a premier league team, tries remaining {i}";
                    // 3 take away 1
                    /*
                   if (i == 0) //when 3 go's down to zero will print this if statement
                   {
                       Console.WriteLine(team + " is not a premier league team but lets move on");//message to user
                   }
                   else//else statement set incase if statement not met
                   {
                       Console.WriteLine($"this is not a premier league team, tries remaining {i}");//message to user
                   }
                   */
                }

                if (matchTeam || t == 3) //if the matchteam or 1 is equal to 3 then condition will be false
                {
                    count2 = false; // set to false to continue to count thru while loop chances
                }
                t++; // will add 1 onto the chances to complete correct answer because its in the while loop
            }

            if (matchTeam) //next condition set incase all other if statements are not met
            {
                var urTeamMyTeam = lowerCaseTeam == compsupports ? "looks like we both support the best team " + name : team + " are not better than liverpool " + name;
                /*
                if (lowerCaseTeam == compsupports) //if applicants team is the same as liverpool then will print this if statment
                {
                    Console.WriteLine("looks like we both support the best team " + name);//message to user
                }
                else // if a team from the array is chosen will print this else statement
                {
                    Console.WriteLine(team + " are not better than liverpool " + name);//message to user
                }
                */
            }

        }






    }
}
