using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple_Loops sl = new Simple_Loops();
            // sl.RunExercise();

            // Break_Continue_Keywords bck = new Break_Continue_Keywords();
            // bck.RunExercise();

            // Compound_Operators co = new Compound_Operators();
            // co.RunExercise();

            // Increment_Decrement id = new Increment_Decrement();
            // id.RunExercise();

            // Integer_Vs_Real_Division ivrd = new Integer_Vs_Real_Division();
            // ivrd.RunExercise();

            // Modulus_Operator mo = new Modulus_Operator();
            // mo.RunExercise();

            // Fahrenheit_To_Celsius ftc = new Fahrenheit_To_Celsius();
            // ftc.RunExercise();

            RandomNumbersBasic rnb = new RandomNumbersBasic();
            rnb.RunExercise();

            // Sentinel_Controlled_Loop scl = new Sentinel_Controlled_Loop();
            // scl.RunExercise();

            // Print_A_Range_Of_Numbers paron = new Print_A_Range_Of_Numbers();
            // paron.RunExercise();

            // Nested_Loops_Rectangles nlr = new Nested_Loops_Rectangles();
            // nlr.RunExercise();

            Nested_Loops_Hollow_Rectangles nlhr = new Nested_Loops_Hollow_Rectangles();
            nlhr.RunExercise();

            // Built_In_Math_Functions bimf = new Built_In_Math_Functions();
            // bimf.RunExercise();
        }
    }


    class Simple_Loops
    {
        public void RunExercise()
        {
        }
    }

    class Break_Continue_Keywords
    {
        public void RunExercise()
        {

        }
    }

    class Compound_Operators
    {
        public void RunExercise()
        {
        }
    }

    class Increment_Decrement
    {
        public void RunExercise()
        {
            int num = 0;
            // ++ before num is 'prefix' 
            while (++num < 10)
                Console.WriteLine("Num: {0}", num);

            num = 0;
            // ++ after num is 'postfix' 
            while (num++ < 10)
                Console.WriteLine("Num: {0}", num);

            num = 10;
            // -- before num is 'prefix' 
            while (--num > 0)
                Console.WriteLine("Num: {0}", num);

            num = 10;
            // -- after num is 'postfix' 
            while (num-- < 10)
                Console.WriteLine("Num: {0}", num);
        }
    }

    class Integer_Vs_Real_Division
    {
        public void RunExercise()
        {
        }
    }

    class Modulus_Operator
    {
        public void RunExercise()
        {
        }
    }

    class Fahrenheit_To_Celsius
    {
        public void RunExercise()
        {
        }
    }

    class RandomNumbersBasic
    {
        Random dieToRoll = new Random();
        public void RunExercise()
        {            
            // First, generate (and print) a random number between 1 & 6
            // (including, potentially, 1 or 6 as possible output)

            Console.WriteLine(dieToRoll.Next(1, 6));

            // Now, call dieToRoll.Next() lots of times,
            // as described in the exercise
            //for (int i = 0; i < 10000; i++)
            //{
            //    Console.WriteLine(dieToRoll.Next());
            // It repeats a number and then ticks over to a new number after repeating the same number for a short duration.
            // The reason for this is that the loop loops so fast that the clock hasn't told Random to generate a new random number.
            //}

            int[] randomArray = new int[10000];            
            int[] countArray = new int[6];

            foreach (int r in randomArray)
            {
                int randomNum = dieToRoll.Next(1, 6);
                countArray[randomNum]++;
            }
            for (int x = 0; x < countArray.Length; x++)
            {
                Console.WriteLine(" " + x + "occurs " + countArray[x] + " times");
            }
        }
    }

    class Sentinel_Controlled_Loop
    {
        public void RunExercise()
        {
        }
    }

    class Print_A_Range_Of_Numbers
    {
        public void RunExercise()
        {
            for(; ; ) // repeat forever
            {
                int pref = 0;
                Console.WriteLine("Greetings, User! \n Welcome to NumberPrinter! \n Do you want to quit (1), or print number (2) ?");
                pref = Convert.ToInt32(Console.ReadLine());

                switch (pref)
                {
                    // Exit the program
                    case 1:
                        Console.WriteLine("Have a nice day!");
                        Environment.Exit(0);
                        break;
                    case 2:
                        pref = 1;
                        break;
                    default:
                        Console.WriteLine("Please enter either 1 or 2");
                        break;
                }

                // Resource efficient storage with arrays
                int []answer = new int[2];
                // for(int i = 0; i < answer.Length; i++)
                // {
                //   answer[i] = Convert.ToInt32(Console.ReadLine());
                // }
                // Gather highest and lowest number
                do { 
                    switch (pref)
                    {
                        case 1:
                            Console.WriteLine("Lowest number?");
                            answer[0] = Convert.ToInt32(Console.ReadLine());
                            pref += 1;
                            break;
                        case 2:
                            Console.WriteLine("Highest number?");
                            answer[1] = Convert.ToInt32(Console.ReadLine());
                            pref += 1;
                            break;
                        default:
                            Console.WriteLine("Please choose either 1 or 2");
                            break;
                    }
                } while (pref != 3) ;

                // Print the numbers from array
                foreach(var item in answer)
                {
                    Console.WriteLine(item.ToString());
                }
            } // end for loop - repeat
        }
    }

    class Nested_Loops_Rectangles
    {
        public void RunExercise()
        {
        }
    }

    class Nested_Loops_Hollow_Rectangles
    {
        public void RunExercise()
        {
            Console.WriteLine("Welcome to HollowRectanglePrinter!");
            Console.WriteLine("How many columns wide should the rectangle be?");
            int rectColumns = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many rows tall should the rectangle be?");
            int rectRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here you go: ");
            // rectRows = 4
            // rectColumns = 6
            // Move down and print *
            // for (int i = 0; i < rectRows; i++)
            // {
                // Vertical
            //    Console.Write("*");

            //    for (int r = 1; r < rectColumns; r++)
            //    {
            //        // Horizontal
            //       Console.Write("*");
            //    }
            //    Console.Write("\n");
           // }

            for (int i = 0; i < rectRows; i++)
            {
                for (int x = 0; x < rectColumns; x++)
                {
                    if (i > 0 && x > 0)
                    {
                        if (i < rectRows - 1 && x < rectColumns - 1)
                        {
                            Console.Write(" ");
                        }
                        else
                            Console.Write('*');
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }

    class Built_In_Math_Functions
    {
        //Pow()   // ask the user for a base, and an exponent
        // and raise the base to that exponent
        //Sqrt()  // Ask the user for a number to take
        // the square root of
        //Sin()   // Print out the values of sin(x)
        // where x = 0...2Pi, increasing x by
        // .1Pi (i.e., print sin(0), sin(0.1* Pi),
        // sin(0.2* Pi), ... , sin(2*Pi) )
        //Cos()   // Print out the values of cosine from 0...2Pi,
        // by .1Pi (i.e., 0, 0.1* Pi, 0.2* Pi,..., 2*Pi
        // Note that you should use Math.PI rather than
        // making your own "Pi".
        public void RunExercise()
        {
            Console.WriteLine("Please enter a base");
            double baseNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter an exponent");
            double exponent = Convert.ToDouble(Console.ReadLine());

            // Print the base raised to the exponent
            Console.WriteLine(Math.Pow(baseNumber, exponent));

            Console.WriteLine("Please enter a number to take the square root of");
            double squareRoot = Convert.ToDouble(Console.ReadLine());

            // Print the square root
            Console.WriteLine(Math.Sqrt(squareRoot));

            // Demonstrate Sign
            double counter = 0;
            Console.WriteLine("Now demonstrating the use of Sin(x) where x = 0 --> 2Pi");
            for (int x = 0; counter < (2 * Math.PI); x++)
            {
                counter += Math.Sin(0.1 * Math.PI);
            }

            // Demonstrate Cos
            counter = 0;
            Console.WriteLine("Now demonstrating the use of Cos(x) where x = 0 --> 2Pi");
            for (int x = 0; counter < (2 * Math.PI); x++)
            {
                counter += Math.Cos(0.1 * Math.PI);
            }
        }
    }
}
