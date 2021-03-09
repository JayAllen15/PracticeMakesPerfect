using System;
using System.Collections.Generic;
using practiceMakesPerfect.Lesson;
using practiceMakesPerfect.PracticeProjects.DoctorsApp;
using practiceMakesPerfect.PracticeProjects.MultiplicationGameApp;
using practiceMakesPerfect.PracticeProjects.Challenges;
using practiceMakesPerfect.PracticeProjects.QuestionaireApp;
namespace practiceMakesPerfect
{
   

    class Program
    {
        public enum Direction
        {
            North = 1,
            East = 2,
            South = 3,
            West = 4,

        }

        static void Main(string[] args)
        {
           

            
            var pc = new PropertyChallenge(10,10);
            var pc1 = new PropertyChallenge();
            Console.WriteLine(pc1.Shoppinglists());
            


            /*
            List<string> shoppingList = new List<string>();
            shoppingList.Add("Eggs");
            shoppingList.Add("Bread");
            shoppingList.Add("Milk");
            shoppingList.Add("Cake");
            shoppingList.Add("Pizza");

            foreach(var shopping in shoppingList)
            {
                Console.WriteLine(shopping);
                
            }
            Console.WriteLine(shoppingList[4]);
            /*

            PropertyChallenge pc = new PropertyChallenge(10,10);

            pc.age = 17;
            Console.WriteLine(pc.UserAge);

           

            pc.Remainder();

            pc.SetName("Nortz");
            pc.GetName();

            Console.WriteLine($"{pc.Name = "Forty"} {pc.Birthplace = "London"} {pc.Music = "Rap"} {pc.Album = "Still I Rise"} {pc.Age = 37}");


            PropertyChallenge[] pc2 = new PropertyChallenge[3]
            {
                new PropertyChallenge(){Name = "2PAC",Music = "HIP HOP",Album = "ALL EYEZ ON ME"},
                new PropertyChallenge(){Name = "BOOSIE",Music = "RAP",Album = "BOOPAC"},
                new PropertyChallenge(){Name = "C-MURDER",Music = "GANGSTA RAP",Album = "TRAPPED IN CRIME"}
            };

            for(int i = 0; i < pc2.Length; i++)
            {
                Console.WriteLine($"{pc2[i].Name} {pc2[i].Music} {pc2[i].Album}");
            }

            for(int i = 0; i<=100;i++)
            {
                i++;
                Console.WriteLine(i++);
            }

            Direction direction = Direction.North;
            switch(direction)
            {
                case Direction.North:
                    Console.WriteLine("Northside");
                    break;

                case Direction.East:
                    Console.WriteLine("TrashTown");
                    break;

                case Direction.South:
                    Console.WriteLine("DirtySouth");
                    break;

                case Direction.West:
                    Console.WriteLine("WestSide");
                    break;
                
            }









            /*
            2 - Write a program and continuously ask the user to enter a number or "ok" to exit.
            Calculate the sum of all the previously entered numbers and display it on the console.
            */


            /*
            var number = "0";
            while (true)
            {
                Console.WriteLine("PLEASE ENTER A NUMBER OR PRESS OK TO EXIT");
                
                var userNumbers = Console.ReadLine();
                number += userNumbers;

                if (userNumbers == "ok")
                {                  
                    Console.WriteLine(number);
                    break;
                }
                
            }
            */

            /*
             3- Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console.
             For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            */
            /*
             Console.WriteLine("PLEASE ENTER A NUMBER BETWEEN 1 AND 10");
             var number = Console.ReadLine();
             for(int i = 0; i < number.Length;i)
             */







            /*       
           var random = new Random();
           var compNumber = random.Next(1,10);
           Console.WriteLine("I HAVE PICKED A NUMBER BETWEEN 1 AND 10 \n I WILL GIVE YOU 4 TRIES TO GUESS IT");
           int userNumber = Convert.ToInt16(Console.ReadLine());
           int numberOfGuesses = 3;          
           while (true)
           {
               if (compNumber == userNumber)
               {
                   Console.WriteLine("YOU WON");
                   break;
               }
               else if (numberOfGuesses == 0)
               {
                   Console.WriteLine("YOU LOST");
                   break;
               }
               else
               {
                   Console.WriteLine($"YOU HAVE {numberOfGuesses} MORE TRIES");
                   userNumber = Convert.ToInt16(Console.ReadLine());
               }
               numberOfGuesses--;
           }
           Console.WriteLine("MY NUMBER WAS" + "\n" + compNumber);
           */
        }


    }
 
}

/*
string[] names = new string[10] { "Nortz", "Paul", "Peter", "Alex", "John", "Lee", "Betty", "Sally", "Lisa", "Jane" };

int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8 ,9 ,10};

bool[] trueOrFalse = new bool[10] { true,true,true,true,true,false,false,false,false,false};

Console.WriteLine($"{names[0]} {numbers[6]} {trueOrFalse[3]}\n{names[8]} {numbers[3]} {trueOrFalse[8]}");

Doctors[] doctors = new Doctors[2] { new Doctors() { FirstName = "Larry", LastName = "Littlez", Sex = "?", Age = 46}, new Doctors() { FirstName = "James", LastName = "Allen", Sex = "male",Age = 37 } };

foreach(var doctor in doctors)
{
    Console.WriteLine($"Doctor Name = ({doctor.FirstName} {doctor.LastName}) Doctors Gender = ({doctor.Sex}) Doctors Age = ({doctor.Age})");
}
*/
/*
int numbers = 3;
            switch(numbers)
            {
                case 1:
                    Console.WriteLine($"Only{1} goal");
                    break;

                case 2:
                    Console.WriteLine($"Chelsea score{2}goals");
                    break;

                case 3:
                    Console.WriteLine($"Chelsea {3} liverpool 1");
                    break;

                case 4:
                    Console.WriteLine($"Goal number {4}");
                    break;

                case 5:
                    Console.WriteLine($"i cant remember last time chelsea scored {5}");
                    break;
                    
            }
*/
/*
for (int i = 1;i <= 100;i++)
{
    if(i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FIZZ BUZZ");
    }
    else if(i % 3 == 0 )
    {
        Console.WriteLine("FIZZ");
    }
    else if(i % 5 == 0)
    {
        Console.WriteLine("BUZZ");
    }
    else
    {
        Console.WriteLine(i);
    }
}
*/

/*

            Console.WriteLine("What is your favourite day of the week ?");

            string favDay = Console.ReadLine();
string yourFavDay = favDay.ToLower().Equals("friday") ? "Party" : "Chill";

Console.WriteLine($"{yourFavDay} on {favDay}");

            string lowerCaseTeam = "Chelsea";
string compsupports = "Liverpool";
var yourTeamMyteam = lowerCaseTeam == compsupports ? "looks like we both support the best team " + name : team + " are not better than liverpool " + name;
*/

/*
var newSignUp = new SignUp();
var newUserLogin = new UserLogin();
var newPreamTeams = new PremTeams();

newSignUp.EmailSorage();
            newSignUp.PasswordStorage();
            newSignUp.UserLogin();
            newSignUp.SignUpWinner();
            newUserLogin.PassWordLogin();
            newUserLogin.EmailLogin();
            newPreamTeams.AllPreamTeams
*/



