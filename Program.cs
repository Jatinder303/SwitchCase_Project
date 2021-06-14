using System;

namespace SwitchCase_Project
{
    /*
        In tis program we will use the switch case statement to find the day of a week.
        User will enter a number between 1 to 7 and then we will display the day corresponding to that number.
        We will use "Day_Number" as a user input and it will be a integer type.
    */
    class Program
    {
        static void Main(string[] args)
        {
            int Day_number;
            Console.WriteLine("Enter a number between 1 to 7, to check the day of a week");
            Day_number = Convert.ToInt32(Console.ReadLine());

            switch(Day_number)   //9
            {
                case 1: // 1 = = Day_number
                    Console.WriteLine("Sunday");
                    break;
                case 2: //   2 = = Day_number
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine(Day_number.ToString() + "th day of a week is Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thrusday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("You Entered wrong number");
                    break;
            }


            Console.WriteLine("Thank You");
        }
    }
}
