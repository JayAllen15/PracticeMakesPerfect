using System;
namespace practiceMakesPerfect.PracticeProjects.MultiplicationGameApp
{
    public class GameMethod
    {
        private static int _finalScore = 0;       
        public void RandomTimestable()
        {
            
            Sums newSums = new Sums();
            Answers newAnswers = new Answers();
            //newSums.TimesTables();
            //newAnswers.TimesTablesAnswers();
            var random = new Random();
            var randomSum = random.Next(0, 144);
            Console.Write(newSums.SumsQuestions[randomSum] + " = ");
            var userAnswer = Console.ReadLine();
            if (userAnswer == newAnswers.Answers1[randomSum])
            {
                
                Console.WriteLine($"CORRECT \n{newAnswers.Answers1[randomSum]}");
                _finalScore++;
            }
            else
            {
                Console.WriteLine($"WRONG \n{newAnswers.Answers1[randomSum]}");
            }
        }

        
        public void TheGame()
        {
           

            Console.WriteLine("********** LETS PLAY A GAME OF MULTIPLICATION ********** " + "\n"
                            + "I WILL GIVE YOU SOME QUESTION AND I WANT YOU TO ANSWER !" + "\n"
                            + "HOW MANY QUESTIONS WOULD YOU LIKE 10 or 20 ?" + "\n" + "20 IS THE LIMIT "
                            + "\n" + "\n" + "PRESS NUMBER 1 FOR 10 QUESTIONS" + "\n"
                            + "PRESS NUMBER 2 FOR 20 QUESTIONS"
                            + "\n" + "AFTER EACH ANSWER PRESS ENTER !");
            string questions10 = "1";
            string questions20 = "2";
            var questions10or20 = Console.ReadLine();
            var count = 0;
            
            while (questions10or20 != questions10 || questions10or20 != questions20)
            {
                if (questions10 == questions10or20)
                {
                    Console.Clear();
                    Console.WriteLine("OK LETS BEGIN" + "\n" + "REMEMBER TO PRESS ENTER AFTER YOUR ANSWER.");
                    while (count <= 10)
                    {
                        RandomTimestable();
                        count++;
                    }
                    Console.WriteLine($"YOU SCORED {_finalScore} OUT OF 10 " + "\n" + "THANK YOU FOR TAKING PART");
                    break;
                }
                else if (questions20 == questions10or20)
                {
                    Console.Clear();
                    Console.WriteLine("OK LETS BEGIN" + "\n" + "REMEMBER TO PRESS ENTER AFTER YOUR ANSWER.");
                    while (count <= 20)
                    {
                        RandomTimestable();
                        count++;
                    }
                    Console.WriteLine($"YOU SCORED {_finalScore} OUT OF 20 " + "\n" + "THANK YOU FOR TAKING PART");
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("DONT UNDERSTAND THAT OPTION PLEASE PRESS 1 0R 2 THEN ENTER");
                    questions10or20 = Console.ReadLine();
                }
            }
            Console.Clear();
            Console.WriteLine($"YOU SCORED {_finalScore} OUT OF 10 " + "\n" + "THANK YOU FOR TAKING PART");
        }
    }
}

           /*      
           Sums newSums = new Sums();
           Answers newAnswers = new Answers();
           GameMethod newGameMethod = new GameMethod();
           newGameMethod.TheGame();
           */
