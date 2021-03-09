using System;
using System.Collections.Generic;

namespace practiceMakesPerfect.PracticeProjects.Challenges
{
    public class PropertyChallenge
    {
        public List<int> shoppingList;
        public int Shoppinglists()
        {
            shoppingList = new List<int>();
            {
                shoppingList.Add(7);
                shoppingList.Add(17);
                shoppingList.Add(27);
                shoppingList.Add(37);
            }
            return shoppingList[3];
        }
         
        
        

      
        public int age;
        public int UserAge
        {
            get
            {
                if (age < 30)
                {
                    Console.WriteLine("STILL I RISE");
                }
                return age;
            }
            set
            {
                age = value;
            }
        }

        public PropertyChallenge(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);

        }
        
        public int[] _numbers;
        public PropertyChallenge()
        {
            _numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
        
        public void Remainder()
        {
            Console.WriteLine(100 % 50);
        }

        public string _name;
        public void GetName()
        {
            Console.WriteLine(_name);
        }
        
        public void SetName(string value)
        {

            _name = value;
        }

        public string Name { get; set; }
        public string Birthplace { get; set; }
        public string Music { get; set; }
        public string Album { get; set; }
        public int Age { get; set; }













    }  
    
}
/*
private int age;
public int userAge
{
    get
    {
        if (age < 40)
        {
            Console.WriteLine("STILL I RISE");
        }

        return age;
    }
    set
    {
        age = value;
    }
}

public PropertyChallenge(int number1, int number2)
{
    Console.WriteLine(number1 * number2);
}

public int[] numbers;
public PropertyChallenge()
{
   numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 
}

public void Remainder()
{
    Console.WriteLine(100 % 20);
}
private string name;
public void GetName()
{
    Console.WriteLine(name);
}

public void SetName(string value)
{
    name = value;
}

public string Name { get; set; }
public string Car { get; set; }
public string Team { get; set; }
public string Birthplace { get; set; }
public int Age { get; set; }
*/
