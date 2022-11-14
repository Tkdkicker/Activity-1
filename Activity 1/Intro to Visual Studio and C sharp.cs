using System;

namespace Activity_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Activity 1:");
            Activity1();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Activity 2:");
            Activity2();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Activity 3:");
            Activity3();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Activity 4:");
            Activity4();
        }

        public static void Activity1()
        {
            Console.WriteLine("Hello Gemma");
            Console.ReadKey();
        }

        public static void Activity2()
        {
            string name;
            int age;
            string occupation;

            name = "Steve";
            age = 25;
            occupation = "Teacher";

            Console.WriteLine("Hello " + name + ", you are " + age + " years old and your occupation is " + occupation);
            Console.ReadKey();
        }

        public static void Activity3()
        {
            string name;
            int age;
            string currentLocation;

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("What is your current location");
            currentLocation = Console.ReadLine();

            Console.WriteLine("Hello " + name + ", you are " + age + " years old and your current location is " + currentLocation);
            Console.ReadKey();
        }

        public static void Activity4()
        {
            string userInput;
            string IceCream = "Ice cream";
            string Cake = "Cake";

            Console.WriteLine("Welcome to the quiz, you have two options to choose from: " + "\n" + "Ice cream" + "\n" + "Cake");
            userInput = Console.ReadLine();

            if (userInput == IceCream)
            {
                string IceCreamInput;
                string chocolateChip = "Choc chip";
                int score = 0;

                Console.WriteLine("What flavour of ice cream do you like?" + "\n" + "Choc chip" + "\n" + "Mint" + "\n" + "Vanilla" + "\n" + "Strawberry");
                IceCreamInput = Console.ReadLine();

                if (IceCreamInput == chocolateChip)
                {
                    Console.WriteLine("Correct! " + "\n" + " You have found one of my favourite flavours");
                    score += 1;
                    Console.WriteLine("Your score has gone up to: " + score);
                }

                else
                {
                    Console.WriteLine("Incorrect " + "\n" + " Sorry, you haven't guessed one of my favourite flavours");
                    score -= 1;
                    Console.WriteLine("Your score has gone down to: " + score);
                }

                Console.WriteLine("Your overall score is: " + score + "\n" + "Press enter to exit");
                Console.ReadKey();
            }

            if (userInput == Cake)
            {
                string CakeUserInput;
                string ChocolateCake = "Chocolate";
                int score = 0;

                Console.WriteLine("What flavour of cake do you like?" + "\n" + "Gingerbread" + "\n" + "Chocolate" + "\n" + "Plain" + "\n" + "Vanilla cheesecake");
                CakeUserInput = Console.ReadLine();

                if (CakeUserInput == ChocolateCake)
                {
                    Console.WriteLine("Correct! " + "\n" + " You have found one of my favourite flavours");
                    score += 1;
                    Console.WriteLine("Your score has gone up to: " + score);
                }

                else
                {
                    Console.WriteLine("Incorrect " + "\n" + " Sorry, you haven't guessed one of my favourite flavours");
                    score -= 1;
                    Console.WriteLine("Your score has gone down to: " + score);
                }

                Console.WriteLine("Your overall score is: " + score + "\n" + "Press enter to exit");
                Console.ReadKey();
            }
        }
    }
}