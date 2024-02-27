using System.ComponentModel.Design;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNums1000() 
        {
            for (int i = 1000; i >=-1000; i--) 
            {
                Console.WriteLine(i);
            }  
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void UpByThree()
        {
            for (int i = 3; i <= 999; i += 3) 
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void TwoNumsSame(int num1, int num2) 
        {
            if (num1 == num2) 
            {
                Console.WriteLine("the numbers are the same");
            }
            else 
            {
                Console.WriteLine("numbers are not the same");
            }
                
                
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num) 
        {
        if (num % 2 == 0) 
            {
                Console.WriteLine($"{num} is even!");
            }
            else 
            {
                Console.WriteLine($"{num} is odd!");
            }
        } 
        
        //Write a method to check whether a given number is positive or negative
        public static bool IsPositive(int num) 
        {
            if(num > 0) 
            {
                Console.WriteLine($"{num} is positive");
                return true;
            }
            else 
            {
                Console.WriteLine($"{num} is negative");
                return false;
            }
        }
        
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool CanVote() 
        {
            Console.WriteLine("Enter your age");
            //var userAge = int.Parse(Console.ReadLine()); 
            var canParse = int.TryParse( Console.ReadLine(), out var userAge);

            while (canParse = false) 
            {
                Console.WriteLine("This age does not match");
                canParse = int.TryParse(Console.ReadLine(), out userAge);
            }
            if(userAge >=18) 
            {
                Console.WriteLine($"congrats! is old enough to vote!");
                return true;
            }
            else 
            {
                Console.WriteLine($"sorry, {userAge} is old enough to vote..");
                return false;
            }
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void IsInTenRange(int num) 
        {
            if(num<= 10 && num >= -10) 
            {
                Console.WriteLine($"{num} is in the ten range!");
            }
            else 
            {
                Console.WriteLine($"{num} is not in the ten range");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultThru12(int num) 
        {
            for(int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} x {num} = {i * num}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintNums1000();
            //UpByThree();
            //TwoNumsSame(1, 2);
            //EvenOrOdd(8);
            //IsPositive(-15);
            //var canIvote = CanVote();
            //Console.WriteLine("Enter a number to see if it is in the range of 10 through -10");
            //var number = int.Parse(Console.ReadLine());
            //IsInTenRange(number);
            MultThru12(3);
        }
    }
}
