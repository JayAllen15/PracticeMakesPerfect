using System;
using practiceMakesPerfect.Lesson;
using practiceMakesPerfect.PracticeProjects.DoctorsApp;
using practiceMakesPerfect.PracticeProjects.MultiplicationGameApp;

namespace practiceMakesPerfect
{
    class Program
    {
       
       static void Main(string[] args)
       {
            
            PlayingWithMethods playingWithMethods1 = new PlayingWithMethods(7,17);
            Console.WriteLine( playingWithMethods1.RandomNumber());

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

             
            patiant10.PatiantDetails();

            /*
            Sums newSums = new Sums();
            Answers newAnswers = new Answers();
            GameMethod newGameMethod = new GameMethod();

            newGameMethod.TheGame();
            */
            



        }


    }
 
}

           

        


    






        /*
        ***************************************************************
        ***                   RANDOM NUMBER METHOD                  ***
        ***************************************************************
        public static void RandomNumber()
        {           
            TimesTables();
            TimesTablesAnswers();
            var random = new Random();
            var randomNumber = random.Next(0, 145);
            Console.Write(_sums[randomNumber] + " = ");
            var userAnswer = Console.ReadLine();
            if (userAnswer == _answers[randomNumber])
            {
                _finalScore++;
                Console.WriteLine($"CORRECT \n{_answers[randomNumber]}");
            }
            else
            {              
                Console.WriteLine($"WRONG \n{_answers[randomNumber]}");
            }
           
            
        }
        public static void TimesTables()
        {
            _sums = new string[144];

            _sums[0] = "1 x 1";
            _sums[1] = "1 x 2";
            _sums[2] = "1 x 3";
            _sums[3] = "1 x 4";
            _sums[4] = "1 x 5";
            _sums[5] = "1 x 6";
            _sums[6] = "1 x 7";
            _sums[7] = "1 x 8";
            _sums[8] = "1 x 9";
            _sums[9] = "1 x 10";
            _sums[10] = "1 x 11";
            _sums[11] = "1 x 12";
            _sums[12] = "2 x 1";
            _sums[13] = "2 x 2";
            _sums[14] = "2 x 3";
            _sums[15] = "2 x 4";
            _sums[16] = "2 x 5";
            _sums[17] = "2 x 6";
            _sums[18] = "2 x 7";
            _sums[19] = "2 x 8";
            _sums[20] = "2 x 9";
            _sums[21] = "2 x 10";
            _sums[22] = "2 x 11";
            _sums[23] = "2 x 12";
            _sums[24] = "3 x 1";
            _sums[25] = "3 x 2";
            _sums[26] = "3 x 3";
            _sums[27] = "3 x 4";
            _sums[28] = "3 x 5";
            _sums[29] = "3 x 6";
            _sums[30] = "3 x 7";
            _sums[31] = "3 x 8";
            _sums[32] = "3 x 9";
            _sums[33] = "3 x 10";
            _sums[34] = "3 x 11";
            _sums[35] = "3 x 12";
            _sums[36] = "4 x 1";
            _sums[37] = "4 x 2";
            _sums[38] = "4 x 3";
            _sums[39] = "4 x 4";
            _sums[40] = "4 x 5";
            _sums[41] = "4 x 6";
            _sums[42] = "4 x 7";
            _sums[43] = "4 x 8";
            _sums[44] = "4 x 9";
            _sums[45] = "4 x 10";
            _sums[46] = "4 x 11";
            _sums[47] = "4 x 12";
            _sums[48] = "5 x 1";
            _sums[49] = "5 x 2";
            _sums[50] = "5 x 3";
            _sums[51] = "5 x 4";
            _sums[52] = "5 x 5";
            _sums[53] = "5 x 6";
            _sums[54] = "5 x 7";
            _sums[55] = "5 x 8";
            _sums[56] = "5 x 9";
            _sums[57] = "5 x 10";
            _sums[58] = "5 x 11";
            _sums[59] = "5 x 12";
            _sums[60] = "6 x 1";
            _sums[61] = "6 x 2";
            _sums[62] = "6 x 3";
            _sums[63] = "6 x 4";
            _sums[64] = "6 x 5";
            _sums[65] = "6 x 6";
            _sums[66] = "6 x 7";
            _sums[67] = "6 x 8";
            _sums[68] = "6 x 9";
            _sums[69] = "6 x 10";
            _sums[70] = "6 x 11";
            _sums[71] = "6 x 12";
            _sums[72] = "7 x 1";
            _sums[73] = "7 x 2";
            _sums[74] = "7 x 3";
            _sums[75] = "7 x 4";
            _sums[76] = "7 x 5";
            _sums[77] = "7 x 6";
            _sums[78] = "7 x 7";
            _sums[79] = "7 x 8";
            _sums[80] = "7 x 9";
            _sums[81] = "7 x 10";
            _sums[82] = "7 x 11";
            _sums[83] = "7 x 12";
            _sums[84] = "8 x 1";
            _sums[85] = "8 x 2";
            _sums[86] = "8 x 3";
            _sums[87] = "8 x 4";
            _sums[88] = "8 x 5";
            _sums[89] = "8 x 6";
            _sums[90] = "8 x 7";
            _sums[91] = "8 x 8";
            _sums[92] = "8 x 9";
            _sums[93] = "8 x 10";
            _sums[94] = "8 x 11";
            _sums[95] = "8 x 12";
            _sums[96] = "9 x 1";
            _sums[97] = "9 x 2";
            _sums[98] = "9 x 3";
            _sums[99] = "9 x 4";
            _sums[100] = "9 x 5";
            _sums[101] = "9 x 6";
            _sums[102] = "9 x 7";
            _sums[103] = "9 x 8";
            _sums[104] = "9 x 9";
            _sums[105] = "9 x 10";
            _sums[106] = "9 x 11";
            _sums[107] = "9 x 12";
            _sums[108] = "10 x 1";
            _sums[109] = "10 x 2";
            _sums[110] = "10 x 3";
            _sums[111] = "10 x 4";
            _sums[112] = "10 x 5";
            _sums[113] = "10 x 6";
            _sums[114] = "10 x 7";
            _sums[115] = "10 x 8";
            _sums[116] = "10 x 9";
            _sums[117] = "10 x 10";
            _sums[118] = "10 x 11";
            _sums[119] = "10 x 12";
            _sums[120] = "11 x 1";
            _sums[121] = "11 x 2";
            _sums[122] = "11 x 3";
            _sums[123] = "11 x 4";
            _sums[124] = "11 x 5";
            _sums[125] = "11 x 6";
            _sums[126] = "11 x 7";
            _sums[127] = "11 x 8";
            _sums[128] = "11 x 9";
            _sums[129] = "11 x 10";
            _sums[130] = "11 x 11";
            _sums[131] = "11 x 12";
            _sums[132] = "12 x 1";
            _sums[133] = "12 x 2";
            _sums[134] = "12 x 3";
            _sums[135] = "12 x 4";
            _sums[136] = "12 x 5";
            _sums[137] = "12 x 6";
            _sums[138] = "12 x 7";
            _sums[139] = "12 x 8";
            _sums[140] = "12 x 9";
            _sums[141] = "12 x 10";
            _sums[142] = "12 x 11";
            _sums[143] = "12 x 12";
        }
        public static void TimesTablesAnswers()
        {
            _answers = new string[144];

            _answers[0] = "1";
            _answers[1] = "2";
            _answers[2] = "3";
            _answers[3] = "4";
            _answers[4] = "5";
            _answers[5] = "6";
            _answers[6] = "7";
            _answers[7] = "8";
            _answers[8] = "9";
            _answers[9] = "10";
            _answers[10] = "11";
            _answers[11] = "12";
            _answers[12] = "2";
            _answers[13] = "4";
            _answers[14] = "6";
            _answers[15] = "8";
            _answers[16] = "10";
            _answers[17] = "12";
            _answers[18] = "14";
            _answers[19] = "16";
            _answers[20] = "18";
            _answers[21] = "20";
            _answers[22] = "22";
            _answers[23] = "24";
            _answers[24] = "3";
            _answers[25] = "6";
            _answers[26] = "9";
            _answers[27] = "12";
            _answers[28] = "15";
            _answers[29] = "18";
            _answers[30] = "21";
            _answers[31] = "24";
            _answers[32] = "27";
            _answers[33] = "30";
            _answers[34] = "33";
            _answers[35] = "36";
            _answers[36] = "4";
            _answers[37] = "8";
            _answers[38] = "12";
            _answers[39] = "16";
            _answers[40] = "20";
            _answers[41] = "24";
            _answers[42] = "28";
            _answers[43] = "32";
            _answers[44] = "36";
            _answers[45] = "40";
            _answers[46] = "44";
            _answers[47] = "48";
            _answers[48] = "5";
            _answers[49] = "10";
            _answers[50] = "15";
            _answers[51] = "20";
            _answers[52] = "25";
            _answers[53] = "30";
            _answers[54] = "35";
            _answers[55] = "40";
            _answers[56] = "45";
            _answers[57] = "50";
            _answers[58] = "55";
            _answers[59] = "60";
            _answers[60] = "6";
            _answers[61] = "12";
            _answers[62] = "18";
            _answers[63] = "24";
            _answers[64] = "30";
            _answers[65] = "36";
            _answers[66] = "42";
            _answers[67] = "48";
            _answers[68] = "54";
            _answers[69] = "60";
            _answers[70] = "66";
            _answers[71] = "72";
            _answers[72] = "7";
            _answers[73] = "14";
            _answers[74] = "21";
            _answers[75] = "28";
            _answers[76] = "35";
            _answers[77] = "42";
            _answers[78] = "49";
            _answers[79] = "56";
            _answers[80] = "63";
            _answers[81] = "70";
            _answers[82] = "77";
            _answers[83] = "84";
            _answers[84] = "8";
            _answers[85] = "16";
            _answers[86] = "24";
            _answers[87] = "32";
            _answers[88] = "40";
            _answers[89] = "48";
            _answers[90] = "56";
            _answers[91] = "64";
            _answers[92] = "72";
            _answers[93] = "80";
            _answers[94] = "88";
            _answers[95] = "96";
            _answers[96] = "9";
            _answers[97] = "18";
            _answers[98] = "27";
            _answers[99] = "36";
            _answers[100] = "45";
            _answers[101] = "54";
            _answers[102] = "63";
            _answers[103] = "72";
            _answers[104] = "81";
            _answers[105] = "90";
            _answers[106] = "99";
            _answers[107] = "108";
            _answers[108] = "10";
            _answers[109] = "20";
            _answers[110] = "30";
            _answers[111] = "40";
            _answers[112] = "50";
            _answers[113] = "60";
            _answers[114] = "70";
            _answers[115] = "80";
            _answers[116] = "90";
            _answers[117] = "100";
            _answers[118] = "110";
            _answers[119] = "120";
            _answers[120] = "11";
            _answers[121] = "22";
            _answers[122] = "33";
            _answers[123] = "44";
            _answers[124] = "55";
            _answers[125] = "66";
            _answers[126] = "77";
            _answers[127] = "88";
            _answers[128] = "99";
            _answers[129] = "110";
            _answers[130] = "121";
            _answers[131] = "132";
            _answers[132] = "12";
            _answers[133] = "24";
            _answers[134] = "36";
            _answers[135] = "48";
            _answers[136] = "60";
            _answers[137] = "72";
            _answers[138] = "84";
            _answers[139] = "96";
            _answers[140] = "108";
            _answers[141] = "120";
            _answers[142] = "132";
            _answers[143] = "144";
        }
        */

        /*
        ***************************************************************************************************
        ***                                   MULTIPLICTION GAME                                        ***
        ***************************************************************************************************
         
        private static string[] _sums;
        private static string[] _answers;
        private static int _finalScore = 0;
        


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
                       RandomNumber();
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
                       RandomNumber();
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
           */

        /*
       *********************************************************************
       ***               MULTIPLY 2 NUMBER METHOD                        ***
       *********************************************************************
       public static void Multiply(int number1, int number2,)
       {
           Multiply(4,5);
           Console.WriteLine(number1 * number2);

       }
       CREATED A METHOD FOR USER TO MULTIPLY ANY 2 NUMBERS OF THERE CHOICE
       THE CONCOLE WILL MULTIPLY THE 2 NUMBERS TOGETHER AND PRINT ANSWER
       IN THE WRITELINE.

       1. PUBLIC = ACCESS MODIFIER MEANS CAN BE ACCESSED OUTSIDE THE CLASS
       2. STATIC = ALLOWS US TO CALL METHOD OR VERIBAL BY ITS NAME ONLY
       3. VOID   = RETURN TYPE, VOID RETURN TYPE MEANS IT WILL RETURN NOTHING
                   THIS CAN BE REPLACED BY ANY DATA TYPE IF WE WANT TO RETURN
                   ANYTHING LIKE A STRING,INT OR BOOL.
       4. MULTIPLY = WHAT WE HAVE NAMED THE METHOD, THIS NAME WILL HAVE TO
                     BE USED IN THE MAIN TO INIALISE THE WHOLE METHOD
                     IF WE TAKE THE {MULTIPLY(4,5)} AND ADD IT TO THE MAIN
                     THE 4 AND THE 5 BECOME OUR NUMBER1 AND NUMBER2
       5.(     ) = THE BODY, WHATEVER IS IN THE BODY IS WHAT WE NEED EXECUTED
                   EXAPMPLE: INT NUMBER1 AND INT NUMBER2 IS WHAT WE ARE WANTING
                   TO KNOW.      
       6. BY PUTTING NUMBER1 * NUMBER2 IN THE CONCOLE.WRITELINE WE ARE TELLING
          THE COMPUTER TO MULTIPLY NUMBER1 WITH NUMBER2 WITH IS 4*5
          AND PRINT ANSWER.
       */
        /*
          **************************************************
          ***                  FOR Loop                  ***
          **************************************************
          for (int i = 0; i <= 10; i++)
          {

              Console.WriteLine(i);
          }
          1. THE FOR IS THE LOOP
          2. THE BRACKET IS THE CONTAINER
          3. INT IS THE data type WE ARE USING
          4. WE ARE STORING THAT i = 0, i IS A INT
          5. THE ; SIGN INDICATES WE HAVE FINISHED STORING
          6. WE ARE THEN SAYING THAT IF i IS LESS THEN OR EQUALS TO 10
          7. THE ; SIGN FINISHES THE IF i IS LESS THEN OR EQUALS STATEMENT
          8. i WILL THEN TURN TO i++ WHICH MEANS i IS NOW 1 AND NOT ZERO
          9. THE NEXT TIME IT GOES ROUND THE LOOP i WILL NOW START AT 1
          10. WHEN IT GETS TO THE END BECAUSE ITS STILL LESS AND NOT EQAUL TO 10
              i WHICH IS NOW 1 WILL BECOME ++ WHICH TURNS THE 1 INTO A 2
          11. THIS LOOP WILL CONTINUE TO GO AROUND UNTIL i IS = TO 10 THEN IT WILL BREAK
          12. THIS CODE WILL PRINT OUT 1 - 10
          */
        /*
        ******************************************************
        ***                 While Loop                     ***
        ******************************************************           
        int i = 0;
        while(i < 5)
        {
            Console.WriteLine(i++);

        }
        1. WE DECLARE THAT i = 0 AND WE STORE IT AS A INT
        2. While IS THE NAME OF THE LOOP
        3. THE BRACKETS ARE FOR OUR STATEMENT
        4. OUR STATEMENT IS WHILE i WHICH IS ZERO IS LESS THEN 5
           KEEP GOING ROUND IN THE LOOP UNTIL CONDITION MET
        5. THE ++ ON THE END OF THE i IN COMSOLE WRITELINE STANDS FOR PLUS 1
        6. SO IF i WAS 0 AND ++ ADDS 1 OUR i NOW EQUALS 1
        7. THIS WILL BE REPEATED UNTIL i EQUALS 5
        8. WHEN THE i IS EQUAL TO 5 THE LOOP WILL BREAK AS IT IS NO LONGER
           LESS THEN 5
         */
        /* 
       ********************************************************
       ***                   DATA TYPES                     ***
       ********************************************************           
       char = CHAR IS A SINGLE CHARACTER ''
              A CHAR GOES INSIDE THE SINGAL BRACKETS 'A'
       string = ANYTHING ON THE KEYPAD IS A STRING " "
               " A STRING GOES INSIDE THE SPEECH MARKS "
       bool = true or false A BOOL IS A TRUE OR FALSE STATEMENT          
       int = IS A NUMBER, ANY NUMBER WITHOUT A DECIMAL POINT 
       double = A DOUBLE IS A NUMBER WITH A DECIMAL POINT

       > MEANS MORE THAN
       < MEANS LESS THAN
       == MEANS EQUALS TOO
       { } THE BODY
       { OPEN BODY
       } CLOSE BODY

       Console.Writeline IS WHAT IS OUTPUT TO THE USER
       Console.Readline IS WHAT THE USER INPUTS
       */
        /*
        ******************************************************
        ***                FOReach Loop                    ***
        ******************************************************           
        string[] names = new string[3];
        {
            names[0] = "peter";
            names[1] = "paul";
            names[2] = "john";
        }
        foreach (var name in names )
        {
            Console.WriteLine(name);
        }

        1. STRING IS THE DATA TYPE WE ARE USING
        2. [] THIS IS DECLARING AN ARRAY,
        3. THE NAME WE ARE GIVING THE ARRAY IS NAMES
        4. THE EQUALS SIGN IS TELLING US EXACTLY THAT,
        5. THEN WE ARE SAYING THAT THE NAMES IN THE ARRAY IS
           A NEW STRING
        6. [3] THE 3 IS TELLING US THAT WE WANT 3 NAMES STORED
           IN OUR ARRAY
        7. THIS IS FINISHED WITH A SEMI COLON WHICH IS A C# FULLSTOP
        8. NOW WE HAVE SET OUR ARRAY WE NEED TO USE IT
        9. A FOREACH LOOP IS THE BEST WAY TO LOOP THROUGH AN ARRAY
       10. FOREACH IS THE NAME OF LOOP WITH THE () BRACKETS
       11. INSIDE THE BRACKETS WE TELL THE LOOP WHAT WE NEED IT TO DO
       12. THE VAR IS THE DATA TYPE WE WANT TO USE
       13. THEN WE ARE SAYING THAT WE WANT A NAME IN THE ARRAY WE CALLED NAMES
       14. WE ARE BASICALLY SAYING WE WANT A NAME IN THE NAMES ARRY
       15. WITH NAME IN THE CONSOLE.WRITELINE WE WILL PRINT NAME FROM THE NAMES ARRAY
        */



    

  
