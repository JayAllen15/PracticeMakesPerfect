using System;
namespace practiceMakesPerfect.PracticeProjects.MultiplicationGameApp
{
    
    public class Sums
    {
        
      
        public Sums()
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
        private string[] _sums;

        public string[] SumsQuestions { get {return _sums;} }  
    }    
}       


    

