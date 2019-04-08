using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello!");
            // This code is used by the first exercise
            // It is left here, uncommented, so that it's easy for you to run
            // Once you complete it, feel free to comment these lines out
            // That way, you won't have every single exercise being run, each and
            // every time :)

            // Basic_Console_IO bcio = new Basic_Console_IO();
            // bcio.RunExercise(); // you will need to uncomment this line!

            // The two lines of code below are used by the next exercise.
            // When you decide to do that exercise, you'll need to uncomment
            // these two lines.
            // Basic_Arithmetic_Operators bao = new Basic_Arithmetic_Operators();
            // bao.RunExercise();

            // Similarly, you'll need to uncomment these lines...
            // Comparison_Operators co = new Comparison_Operators();
            // co.RunExercise();

            Define_An_Instance_Method daim = new Define_An_Instance_Method();
            daim.RunExercise();

            NumberPrinter printTwo = new NumberPrinter();
            printTwo.printTwoNumbers();
        }
    }

    class Basic_Console_IO
    {
        public void RunExercise()
        {
            Console.WriteLine("Hello World");
        }
    }

    class Basic_Arithmetic_Operators
    {
        public void RunExercise()
        {
            {
                int x = 2, y = 8, z;

                Console.WriteLine("2 times 8 equals " + x * y);	// multiply
                Console.WriteLine("8 divided by 2 equals " + y / x);	// divide
                Console.WriteLine("8 mod 2 equals " + y % x);		// modulus
                Console.WriteLine("2 plus 8 equals " + (x + y));	// add
                Console.WriteLine("8 minus 2 equals " + (y - x));	// subtract

                z = ((y - (2 * x)) * 6) / 12;
                Console.WriteLine("z now equals " + z);
            }
        }
    }

    class Comparison_Operators
    {
        public void RunExercise()
        {
            Console.WriteLine("Get 2 integers & store them, then compare them using <, <=, etc, etc");
        }
    }

    class Define_An_Instance_Method
    {
        public void RunExercise()
        {
            Console.WriteLine("Hello, World, from the Instance Method Exercise!");

            HelloPrinter hello = new HelloPrinter();
            hello.printHello();
            hello.printHello();
            hello.printHello();
        }
    }

    // 2
    class HelloPrinter
    {
        public void printHello()
        {
            Console.WriteLine("Reminder?");
        }
    }

    class NumberPrinter
    {
        public void printTwoNumbers()
        {
            string numInput;
            int x;
            int y;
            

            Console.WriteLine("Please enter integer number 1: ");
            numInput = Console.ReadLine();
            Int32.TryParse(numInput, out x);
            

            Console.WriteLine("Please enter integer number 2: ");
            numInput = Console.ReadLine();
            Int32.TryParse(numInput, out y);
            Console.WriteLine("Number 1 is: " + x);
            Console.WriteLine("Number 2 is: " + y);
        }
    }

    // Put the Data_Type_Explanations stuff here

    // Don't forget the following (detailed in the Word .DOC that describes this exercise):

    //answers here on what values can be stored in the given data types:

    //answer for what the u prefix means:

    //answer for what the difference between float/double/decimal are:
    // What is a typical usage of decimal instead of float/double?

    //answers for the 5 questions:
}
