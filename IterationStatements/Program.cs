namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below

        public static void PrintThru10s()
        {
            //Write a method that will print to the console all numbers 10 through - 10
            for (int i = -10; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThrees()
        {
            int num = 0 ;
            do
            {
                num += 3;
                Console.WriteLine(num);
            } while
                (num < 999);
            return;
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualOrNot(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine($"{a} and {b} are equal");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are not equal");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int num)
        {
            
            if (num % 2 == 0)
                Console.WriteLine($"{num} is an even number");
            else
            {
                Console.WriteLine($"{num} is an odd number");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void PositiveOrNegative(int num)
        {
            if (num >= 0)
            {
                Console.WriteLine($"{num} is a positive number");
            }
            else
            {
                Console.WriteLine($"{num} is a negative number");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        public static bool CanVote()
        {
            Console.WriteLine("Thanks for coming to vote. Please type in your age so we can see if you can vote");

            var canParse = int.TryParse(Console.ReadLine(), out int response);

            while (canParse == false)
            {
                Console.WriteLine("Not a valid response. Need an age NUMBER");
                canParse = int.TryParse(Console.ReadLine(), out response);
            }
            if (response >= 18)
            {
                Console.WriteLine($"You are {response}, so can vote.");
                return true;
            }
            else
            {
                Console.WriteLine($"Sorry. You are only {response}. You cannot vote.");
                return false;
            }
            
           
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool InRange()
        {
            Console.WriteLine("Pick a number between -10 and 10. Checking to see if what you type is in the range");
            var canParse = int.TryParse(Console.ReadLine(), out int userNum);

            while (canParse == false)
            {
                Console.WriteLine("That is not a valid entry. Need a number entered please.");
                canParse = int.TryParse(Console.ReadLine(), out userNum);
            }

            if (userNum <= 10 && userNum >= -10)
            {
                Console.WriteLine($"Yes. {userNum} is in the range.");
                return true;
            }
            
            else
            {
                Console.WriteLine($"Sorry. {userNum} is not in the range.");
                return false;
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        
        public static void MultTable(int a)
        {
            
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{a} * {i} = {i * a}");
            }

            
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintThru10s();
            //ByThrees();
            // EqualOrNot(2,3);
            //EvenOrOdd(6);
            //PositiveOrNegative(9);
            //CanVote();
            //InRange();
            //MultTable(9);


        }
    }
}
