using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Hello!");
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

            bool check = true;
            while (check == true)
            {
                Console.WriteLine("Select a class to run: ");
                Console.WriteLine("1. Define_An_Instance_Method \n 2. NumberPrinter \n 3. Data_Type_Explanations \n 4. Basic Arithmetic Operators" +
                    "\n 5. Basic Console IO \n 6. Comparison Operators \n 7. Hello Printer \n 8. Quit");

                string gather = Console.ReadLine();
                Int32.TryParse(gather, out int select);
                

                switch (select)
                {
                    case 1:
                        Define_An_Instance_Method daim = new Define_An_Instance_Method();
                        daim.RunExercise();
                        break;
                    case 2:
                        NumberPrinter printTwo = new NumberPrinter();
                        printTwo.printTwoNumbers();
                        break;
                    case 3:
                        Data_Type_Explanations dataExplain = new Data_Type_Explanations();
                        dataExplain.RunExercise();
                        break;
                    case 4:
                        Basic_Arithmetic_Operators basic_Arithmetic = new Basic_Arithmetic_Operators();
                        basic_Arithmetic.RunExercise();
                        break;
                    case 5:
                        Basic_Console_IO basicIO = new Basic_Console_IO();
                        basicIO.RunExercise();
                        break;
                    case 6:
                        Comparison_Operators comparison = new Comparison_Operators();
                        comparison.RunExercise();
                        break;
                    case 7:
                        HelloPrinter printer = new HelloPrinter();
                        printer.printHello();
                        break;
                    case 8:                        
                        check = false;
                        break;
                    default:
                        check = true;
                        Console.WriteLine("Please select one of the listed options.");
                        break;
                }
            }
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

    class Data_Type_Explanations
    {
        public void RunExercise()
        {
            string yeet = "This is a string";
            Console.WriteLine(yeet.ToUpper());
            Console.WriteLine(yeet.ToLower());

            // u is a non-CLS-compliant integral type literal declaration. Fixed value literals cannot be modified
            // once they have been declared. The Microsoft docs say not to use them unless absolutely necessary.
            // The types of data that can be stored include:
            // uint, ushort, ulong --> Includes Hexidecimal, binary literal, and integer literals.
            // "If the integer literal is outside the range of uint (that is, if it is less than 
            // UInt32.MinValue or greater than UInt32.MaxValue), a compilation error occurs."

            // Differences between float, double, and decimal.
            // `float` and `double` are floating binary point types. ex: 10001.10010110011
            // The binary number and the location of the binary point are both encoded within the value.
            // `decimal` is a floating decimal point type. ex: 12345.65789
            // float and double are approximations, while decimal is exact. For accuracy you should use decimal, for values that aren't
            // required to be as exact, it is better to use float or double.

            // -------------------------------------------------------------------------------------------------------------------------

            float f = 1.117f;
            double d = 1.217;
            decimal de = 1.314m;
            Console.WriteLine("f:{0:0.00} d:{1:0.00} de:{2:0.00}", f, d, de);

            sbyte x = 2;
            byte b = 8;
            // The short data type is a 16-bit signed two's complement integer.
            short s = 8900;
            Console.WriteLine("x:{0} b:{1} s:{2}", x, b, s);

            int i = 14;
            uint ui = 100;
            long l = 456708;
            Console.WriteLine("i:{0} ui:{1} l:{2}", i, ui, l);

            ulong ul = 45000;
            char c = 'a';
            string str = "hello, I'm a string!";
            Console.WriteLine("ul:{0} c:{1} str:{2}", ul, c, str);


            // Question 1:
            // What variable type(s) would you use to store the number of students enrolled in a class at Cascadia Community College?
            // Keep in mind that classes are limited to 30 students(48 for a ‘learning community’ class).
            // A: I would use an int because it is accurate and there are no decimal places.
            
            // Question 2:
            // What variable type(s) would you use to store a student’s current tuition balance? Keep in mind that a student may 
            // not have paid their tuition yet(in which case the balance is a positive number), or they may have overpaid
            // (in which case the balance will be a negative number), and that the balance is always in US dollars.
            // A: I would use a decimal because I am dealing with decimal places and financial systems.

            // Question 3:
            // What variable type(s) would you use to store the result of a scientific computation? Keep in mind that having
            // extremely precise results is very important, and that occasionally having to deal with round-off errors is ok,
            // as long as the data has the maximum number of digits of precision in other cases.
            // A: Double, due to the high accuracy for over a dozen decimal places. 

            // Question 4:
            // What variable type(s) would you use to store a Cascadia Student ID (SID)? If you need an example of a SID, you
            // can check the back of your Cascadia student ID card – it’s the number that starts with “9600…”, and is 9 digits long.
            // A: I would use an int, it is accurate, and can fit all 9 digits, unlike a short.

            // Question 5:
            // Let’s say you’ve written a program that will send email to all of the students in a given class at Cascadia.
            // What variable type(s) would you use to store, in memory, one of two values: one value will mean that your 
            // program’s attempt at emailing all of the students in a class succeeded, the other value will mean that at 
            // least one of the emails was not successfully sent.
            // A: A bool as it is either true (success) or false (failure)

            //Question 6:
            // Let’s say you’ve written a program that will send email to all of the students in a given class at Cascadia.
            // Let’s say that you want to reuse this program for multiple classes, so you decide to store the full name of the
            // class in a variable.What variable type(s) would you use to store this information?
            // Some examples of class names :

            // BIT 142
            // ENG 101
            // MATH 141
            // etc
            // A: I would use a string to store the class names, as strings store letters.
        }
    }
}
