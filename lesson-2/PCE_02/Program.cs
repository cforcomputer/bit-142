using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Conditional_Statements cs = new Conditional_Statements();
            cs.RunExercise();

            // Comparison_Operators co = new Comparison_Operators();
            // co.RunExercise();

             IO_Operators ioo = new IO_Operators();
             ioo.RunExercise();

             Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
             ivrd.RunExercise();
                        
            // Modulus_Operator mo = new Modulus_Operator();
            // mo.RunExercise();

           Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
           ftc.RunExercise();
        }
    }

    class Conditional_Statements
    {
        public void RunExercise()
        {
            Console.WriteLine("About to do the \"Conditional Statements\" exercise");
            Conditional_Methods cm = new Conditional_Methods();
            cm.UsingIf();
            cm.UsingIfElse();
            cm.UsingSwitch();
        }
    }

    class Comparison_Operators
    {
        public void RunExercise()
        {

            Console.WriteLine("Get 2 integers & store them, then compare them using <, <=, etc, etc");
        }
    }


    class IO_Operators
    {
    // For example, if the user types in 20 and 24, your program might print:
    //20 and 24 are within 5 integers of each other.

    //For example, if the user types in 20 and 26, your program might print:
    //20 and 26 are NOT within 5 integers of each other.

    //For example, if the user types in 20 and 25, your program might print:
    //20 and 25 are within 5 integers of each other.

    //For example, if the user types in 24 and 20, your program might print:
    //24 and 20 are within 5 integers of each other.

    //For example, if the user types in 26 and 20, your program might print:
    //26 and 20 are NOT within 5 integers of each other.

    //For example, if the user types in 25 and 20, your program might print:
    //25 and 20 are within 5 integers of each other.
        public void RunExercise()
        {
            string numberInputOne;
            string numberInputTwo;
            int numberOutputOne;
            int numberOutputTwo;

            // collect user data
            Console.WriteLine("Enter first int");
            numberInputOne = Console.ReadLine();
            Int32.TryParse(numberInputOne, out numberOutputOne);

            Console.WriteLine("Enter second int");
            numberInputTwo = Console.ReadLine();
            Int32.TryParse(numberInputTwo, out numberOutputTwo);

            if ((numberOutputOne % numberOutputTwo) <= 5)
            {
                Console.WriteLine("i:{0} and ui:{1} are within 5 integers of each other.", numberOutputOne, numberOutputTwo);
            }
            //else if ((numberOutputOne % numberOutputTwo) == 5)
            //{
            //    Console.WriteLine("i:{0} and ui:{1} are within 5 integers of each other.", numberOutputTwo, numberOutputOne);
            //}
            else
            {
                Console.WriteLine("i:{0} and ui:{1} are NOT within 5 integers of each other.", numberOutputOne, numberOutputTwo);
            }
         }
    }

    class Conditional_Methods
    {
        private string numberInput;
        private int numberOutput;

        public void UsingIf()
        {
            numberInput = Console.ReadLine();
            Int32.TryParse(numberInput, out numberOutput);

            if (numberOutput < 0)
            {
                Console.WriteLine("Negative numbers aren't allowed.");
            }
            if (numberOutput == 0)
            {
                Console.WriteLine("You need to talk to the professor immediately!");
            }
            if (numberOutput > 0 && numberOutput <= 1)
            {
                Console.WriteLine("You need to study a lot more!");
            }
            if (numberOutput >= 2 && numberOutput <= 4)
            {
                Console.WriteLine("If you keep working at this, you'll do better!");
            }
            if (numberOutput >= 5 && numberOutput <= 6)
            {
                Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
            }
            if (numberOutput >= 7 && numberOutput <= 8)
            {
                Console.WriteLine("Nice job, but don't let yourself slack!");
            }
            if (numberOutput > 8 && numberOutput <= 9)
            {
                Console.WriteLine("Very nice job – keep up the good work!");
            }
            if (numberOutput > 9 && numberOutput <= 10)
            {
                Console.WriteLine("Perfect!");
            }
            if (numberOutput > 10)
            {
                Console.WriteLine("Number is too high!");
            }
        }

        public void UsingIfElse()
        {
            numberInput = Console.ReadLine();
            Int32.TryParse(numberInput, out numberOutput);

            if (numberOutput < 0)
            {
                Console.WriteLine("Negative numbers aren't allowed.");
            }
            else if (numberOutput == 0)
            {
                Console.WriteLine("You need to talk to the professor immediately!");
            }
            else if (numberOutput > 0 && numberOutput <= 1)
            {
                Console.WriteLine("You need to study a lot more!");
            }
            else if (numberOutput >= 2 && numberOutput <= 4)
            {
                Console.WriteLine("If you keep working at this, you'll do better!");
            }
            else if (numberOutput >= 5 && numberOutput <= 6)
            {
                Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
            }
            else if (numberOutput >= 7 && numberOutput <= 8)
            {
                Console.WriteLine("Nice job, but don't let yourself slack!");
            }
            else if (numberOutput > 8 && numberOutput <= 9)
            {
                Console.WriteLine("Very nice job – keep up the good work!");
            }
            else if (numberOutput > 9 && numberOutput <= 10)
            {
                Console.WriteLine("Perfect!");
            }
            else
            {
                Console.WriteLine("Number is too high!");
            }
        }
        public void UsingSwitch()
        {
            numberInput = Console.ReadLine();
            Int32.TryParse(numberInput, out numberOutput);

            switch (numberOutput)
            {
                case 0:
                    Console.WriteLine("You need to talk to the professor immediately!");
                    break;
                case 1:
                    Console.WriteLine("You need to study a lot more!");
                    break;
                case 2:
                    
                case 3:
                    Console.WriteLine("If you keep working at this, you'll do better!");
                    break;
                case 4:
                    Console.WriteLine("If you keep working at this, you'll do better!");
                    break;
                case 5:
                    Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
                    break;
                case 6:
                    Console.WriteLine("You've gotten the hang of this, but with practice, I'm sure you can do even better!");
                    break;
                case 7:
                    Console.WriteLine("Nice job, but don't let yourself slack!");
                    break;
                case 8:
                    Console.WriteLine("Nice job, but don't let yourself slack!");
                    break;
                case 9:
                    Console.WriteLine("Very nice job – keep up the good work!");
                    break;
                case 10:
                    Console.WriteLine("Perfect!");
                    break;
                default:
                    Console.WriteLine("Decimals not recognized \n");
                    if (numberOutput < 0)
                    {
                        Console.WriteLine("Negative numbers aren't allowed.");
                    }
                    else if (numberOutput > 10)
                    {
                        Console.WriteLine("Number is too high!");
                    }

                    break;
            }
        }
    }

    class Integer_Vs_Real_Division
    {
        public void RunExercise()
        {
            // the result is exact
            int exact = 6 / 3;
            Console.WriteLine(exact);

            // the result will drop the remainder
            int real = 7 / 3;
            Console.WriteLine(real);

            // exact float
            float exactFloat = 6 / 3;
            Console.WriteLine(exactFloat);

            // real float
            float realFloat = 7 / 3;
            Console.WriteLine(realFloat);

            // exact double
            double exactDouble = 6 / 3;
            Console.WriteLine(exactDouble);

            // real double
            double realDouble = 7 / 3;
            Console.WriteLine(realDouble);

            // Include a short comment explaining why your code doesn’t always generate an exact 
            // answer(e.g., why does 7 / 3 not produce a number like 2.3333, but 7.0 / 3.0 does ?).
            // Focus your answer on explaining why(syntactically) C# decides to give you the rounded-off answer.
            // A: 7 / 3 is a whole number/int -> putting .0 tells it to be handled as double. divide 2 ints == int

            // Include a short comment explaining why using the float doesn’t get you exactly the same answer
            // as using the double data type.
            // A: float is not as accurate as double, so it approximates the decimal places and leads to slightly
            // different answer.
        }
    }

    class Modulus_Operator
    {
        public void RunExercise()
        {            
            double exact = 6 / 3;
            Console.WriteLine(exact);
            double mod = 6 % 3;
            Console.WriteLine(mod);

            // user
            string numberInput = Console.ReadLine();
            Int32.TryParse(numberInput, out int numberOutputOne);
            numberInput = Console.ReadLine();
            Int32.TryParse(numberInput, out int numberOutputTwo);

            exact = numberOutputOne / numberOutputTwo;
            Console.WriteLine(exact);
            mod = numberOutputOne % numberOutputTwo;
            Console.WriteLine(mod);
        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
            Console.ReadLine();

            double fahrenheit;

            double celsius = 36;
            Console.WriteLine("Celsius: " + celsius);

            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);                        
        }
    }

    class Logical_Operators
    {
        // Your answer goes here,in a comment like this one
        // y< 1 || y> 1

        // If y is an integer, can you find a better way to express the above?
        // A: y != 1 

        // When looking for a different/better way to express this, think when the expression will be true, and when it won't.
        // Once you've got that figured out, think about how you might explain it to a friend – what's a quick, 1 sentence summary 
        // of when the expression evaluates to true? Lastly, think about how you would write that in C#.
        // When handing your answer to this part, put in something that clearly states what your new, simplified expression(in C# is)

        // A: != is the equivalent to greater than or less than one, since it includes all numbers and does not include 1.

        // y < 2 || x > 4
        // A: A different way to express this would be (2 > y || 4 < x). True when y = 1 and x = 5

        // z > 8 || y< 3
        // A: 8 < z || y > 3. True when z is 9 and y is 4.

        // !(z > 8)
        // A: (z > 8) == false. True when z is 7.

        // !(z > 8 || y< 3)
        // A: (8 < z || y > 3) == false. True when y = 3 and z = 8.

        // !(z > 4 && y == 2) || (z ==10 && y <= 3)
        // A: (z < 4 && y == 2) || (z == 10 && y <= 3) == false. True when z = 2 and y = 2 or z = 10 and y = 3

        // y < z ^ z < x
        // A: ((y < z) || (z < x)) || ((y < z) && (z < x)). True XOR and/or --> when y = 3 and z = 5 and x = 10. One can be false or both can be true.

        // z<x ^ y<z
        // A: ((z < x) || (y < z)) || ((z < x) && (y < z)). True XOR and/or --> when z = 3 and x = 5 and y = 2. One can be false or both can be true.

        // 10 < 20 ^ 20 < 30
        // A: Entire line can be replaced with a boolean (True) since 10 is always less than 20 and 20 is always less than 30. 

        // 20 == 10 ^ 20 < 10
        // A: 
        // Side-Note: Notice that this class has NO methods, and that it still compiles :)
    }
}