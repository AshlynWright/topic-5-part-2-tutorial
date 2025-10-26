using System.Diagnostics.CodeAnalysis;

namespace topic_5_part_2_tutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int grade;
            Console.WriteLine("What was your grade?");
            int.TryParse(Console.ReadLine(), out grade);

            if (grade >= 50)
            {
                Console.WriteLine("You passed!");
            }
            else
            {
                Console.WriteLine("You failed.");
            }



            Console.WriteLine("What was your grade?");
            int.TryParse(Console.ReadLine(), out grade);

            if (grade < 50)
            {
                Console.WriteLine("That is an F!");
            }
            else if (grade <= 65)
            {
                Console.WriteLine("That is a D!");
            }
            else if (grade <= 75)
            {
                Console.WriteLine("That is a C!");
            }
            else if (grade <= 85)
            {
                Console.WriteLine("That is a B!");
            }
            else if (grade > 85)
            {
                Console.WriteLine("That is a A!");
            }


            if (grade >= 50)
                Console.WriteLine("That is an F!");
            else if (grade >= 65)
                Console.WriteLine("That is a D!");
            else if (grade >= 75)
                Console.WriteLine("That is a C!");
            else if (grade >= 85)
                Console.WriteLine("That is a B!");
            else
                Console.WriteLine("That is a A!");




            string choice;
            Console.WriteLine("what is 4 + 4?");
            Console.WriteLine("A - 8      B - 4");
            Console.WriteLine("C - 9      D - 7");
            Console.WriteLine();
            Console.Write("=");
            choice = Console.ReadLine().ToUpper();
            Console.WriteLine();

            if (choice == "A")
            {
                Console.WriteLine("Correct!");
            }
            if (choice == "B")
            {
                Console.WriteLine("Wrong!");
            }
            if (choice == "C")
            {
                Console.WriteLine("Wrong!");
            }
            if (choice == "D")
            {
                Console.WriteLine("Wrong!");
            }




            int temp;
            Console.WriteLine("Enter the temperature of the H2O: ");
            if (int.TryParse(Console.ReadLine(), out temp))
            {
                if (temp <= 0)
                    Console.WriteLine("You have a solid!");
                else if (temp < 100)
                    Console.WriteLine("You have liquid!");
                else
                    Console.WriteLine("You have gas!");
            }



            string name;
            int age;
            Console.Write("Hello, what's your name? ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ok, " + name + ", how old are you?  ");
            if (int.TryParse(Console.ReadLine(), out age)) ;
            {
                Console.WriteLine();
                if (age <= 2)
                {
                    Console.WriteLine("you are a baby!");
                }
                else if (age <= 16)
                {
                    Console.WriteLine("You can't drive.");
                }
                else if (age <= 18)
                {
                    Console.WriteLine("You can drive but you can't vote.");
                }
                else if (age <= 25)
                {
                    Console.WriteLine("You can vote but can't rent a car.");
                }
                else
                {
                    Console.WriteLine("You can do anything that is legal.");
                }

            }
        }
    }
}

