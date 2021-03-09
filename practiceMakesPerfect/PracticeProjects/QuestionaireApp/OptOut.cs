using System;
namespace practiceMakesPerfect.PracticeProjects.QuestionaireApp
{
    public class OptOut
    {
       public void OptOutOption()
       {
            Console.WriteLine("To continue with questionaire type yes then enter or just press enter to end");//message to user
            string f = "no"; // storing veriable
            string k = "yes";  //storing veriable
            string answer = Console.ReadLine(); // applicants answer
            string yesorno = answer.ToLower();// set so whatever letters are input will convert to lowercase letters
        }
    }
}
