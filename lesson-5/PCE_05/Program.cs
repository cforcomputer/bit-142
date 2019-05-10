using System;
using System.Linq;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic_Class_With_Instance_Method bcwim = new Basic_Class_With_Instance_Method();
            // bcwim.RunExercise();

            // Instance_Variables iv = new Instance_Variables();
            // iv.RunExercise();

            // More_Methods mm = new More_Methods();
            // mm.RunExercise();

            //Access_Control ac = new Access_Control();
            //ac.RunExercise();

            // Overloading_Create_Your_Own ocyo = new Overloading_Create_Your_Own();
            // ocyo.RunExercise();

            //Constructors_Exercise ce = new Constructors_Exercise();
            //ce.RunExercise();

            //Scope_Of_Variables sov = new Scope_Of_Variables();
            //sov.RunExercise();

            //Television_Definition td = new Television_Definition();
            //td.RunExercise();

            //Basic_Array_Of_Objects baoc = new Basic_Array_Of_Objects();
            //baoc.RunExercise();

            Array_Of_Possibly_Null_Objects aopno = new Array_Of_Possibly_Null_Objects();
            aopno.RunExercise();
        }
    }
    class Basic_Class_With_Instance_Method
    {
        public void RunExercise()
        {
            Toaster burntToast = new Toaster();
            Console.WriteLine(burntToast);
        }
    }
    // You should define the Toaster class (and it's Print() method) in the space below //
    //////////////////////////////////////////////////////////////////////////////////////
    class Toaster
    {
        public void Print()
        {
            Console.WriteLine("Hello, World, from the Instance Method Exercise!");
        }
    }

    //////////////////////////////////////////////////////////////////////////////////////
    // You should define the Toaster class (and it's Print() method) in the space above //

    class Instance_Variables
    {
        public void RunExercise()
        {
        }
    }
    // You should define the Refrigerator class in the space below //
    /////////////////////////////////////////////////////////////////

    /////////////////////////////////////////////////////////////////
    // You should define the Refrigerator class in the space above //


    class More_Methods
    {
        public void RunExercise()
        {
            //Oven o = new Oven();
            //Oven theOtherOven = new Oven();

            //// What does the ovens start out at?
            //Console.WriteLine("Oven o:");
            //o.Print();
            //Console.WriteLine("Oven theOtherOven:");
            //theOtherOven.Print();

            //// We want the over to be about 125 degrees...
            //// If it's close enough, we'll just use the current
            //// temperature.

            //// We'll check that it's close enough (+/- 5 degrees away from 125)
            //if( o.GetCurrentTemp() < 120 ||
            //    o.GetCurrentTemp() > 130)
            //{
            //    // The temperature is too far away, so
            //    // set it to be what we want, here
            //    o.SetCurrentTemp(125.7);
            //}

            //Console.WriteLine("Oven o:");
            //o.Print();
            //Console.WriteLine("Oven theOtherOven:");
            //theOtherOven.Print();

            //theOtherOven.SetCurrentTemp(200);


            //Console.WriteLine("Oven o:");
            //o.Print();
            //Console.WriteLine("Oven theOtherOven:");
            //theOtherOven.Print();
        }
    }

    class Oven
    {
        // Put your instance variables here:



        //public /*????? */ SetCurrentTemp( /*  ????  */ )
        //{
        //}

        //public /*????? */ GetCurrentTemp( /*  ????  */ )
        //{
        //}

        //public /*????? */ Print( /*  ????  */ )
        //{
        //}
    }


    class Access_Control
    {
        public void RunExercise()
        {
            // New blender object
            Blender blend = new Blender();

            Console.WriteLine("Please enter an integer 0-7");
            int userInput = Convert.ToInt32(Console.ReadLine());
            // 1. Call SetSpeed method and give user input
            blend.SetSpeed(userInput);
            
            // 2. Print the result
            if (Enumerable.Range(0,8).Contains(userInput))
            {
                blend.GetSpeed();
                blend.Print();
            }            
        }
    }

    /// <summary>
    /// Add the blender class to call from access control
    /// 
    /// </summary>

    class Blender
    {
        private int currentSpeed;

        public void SetSpeed(int newSpeed)
        {
            if (Enumerable.Range(0,8).Contains(newSpeed))
            {
                currentSpeed = newSpeed;
            } else
            {
                return;
            }
        }

        public int GetSpeed()
        {
            return currentSpeed;
        }

        public void Print()
        {
            Console.WriteLine("Blender's current speed: {0}", GetSpeed());
        }
    }

    class Overloading_Create_Your_Own
    {
        public void RunExercise()
        {
        }
    }



    class Constructors_Exercise
    {
        public void RunExercise()
        {
            Dishwasher wash = new Dishwasher();
            Dishwasher washTwo = new Dishwasher(0, 10, 1, 5, 3, 7);
            wash.Print();
            washTwo.Print();
        }
    }

    /// <summary>
    /// Create a class named Dishwasher belore the Constructors_Exercise
    /// </summary>
    
    public class Dishwasher
    {
        private int minGlass, minPlate, minBowl;
        private int maxGlass, maxPlate, maxBowl;
        
        // Part 2
        public Dishwasher()
        {
            this.minGlass = 0;
            this.minPlate = 0;
            this.minBowl = 0;

            this.maxGlass = 10;
            this.maxPlate = 10;
            this.maxBowl = 10;
        }

        // Part 3
        public Dishwasher(int minGlass_2, int maxGlass_2, int minPlate_2, int maxPlate_2, int minBowl_2, int maxBowl_2)
        {
            this.minGlass = minGlass_2;
            this.minPlate = minPlate_2;
            this.minBowl = minBowl_2;

            this.maxGlass = maxGlass_2;
            this.maxPlate = maxPlate_2;
            this.maxBowl = maxBowl_2;
        }

        public void Print()
        {
            Console.WriteLine("Holding {0} of {1} glasses", minGlass, maxGlass);
            Console.WriteLine("Holding {0} of {1} plates", minPlate, maxPlate);
            Console.WriteLine("Holding {0} of {1} bowls", minBowl, maxBowl);
        }
    }

    class Scope_Of_Variables
    {
        // Put your comment here:
        /// <summary>
        /// INSTANCE VARIABLES
        /// Instance variables are variables that are declared outside of a method.
        /// They can be set to private or public. Private instance variables are accessible
        /// from any method in the class. Public instance variables are accessible from
        /// anywhere in the program. Both private and public instance variables exist for
        /// as long as the program is running.
        /// 
        /// LOCAL VARIABLES
        /// Local variables are declared inside a method, and are only accessible from within that method.
        /// Local variables exist for as long as the method is running. Their stored values are temporary.
        /// 
        /// PARAMETERS
        /// Parameters are similar to to local variable in that they can only be accessed
        /// from within the method that they are called. Their values however can be from either
        /// an instance variable, or from a local variable.
        /// </summary>

        public void RunExercise()
        {
            NumberPrinter np = new NumberPrinter();

            np.SetLowest(3.14159);
            np.SetHighest(12);
            np.Print(true);
            np.SetHighest(17.1);
            np.Print(false);
            np.SetLowest(17); // note that lo == hi
            np.Print(false);  // no output
            np.SetLowest(22); // note that lo > hi
            np.Print(false);  // no output
        }
    }

    class NumberPrinter
    {
        private int lowestNumber;
        private int highestNumber;

        // Default constructor to set highest and lowest = 0
        public NumberPrinter()
        {
            this.lowestNumber = 0;
            this.highestNumber = 0;
        }

        public void SetLowest(double lowest)
        {
            lowestNumber = Convert.ToInt32(lowest);
        }

        public void SetHighest(double highest)
        {
            highestNumber = Convert.ToInt32(highest);
        }

        public void Print(bool even)
        {
            if (even)
            {
                // Print only even numbers
                for (int i = lowestNumber; i <= highestNumber; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }                   
                }

            }else
            {
                // If false, print out all numbers in specified range
                for (int i = 0; lowestNumber < highestNumber; i++)
                {
                    // Print numbers from test case to --> 3-17                    
                    Console.WriteLine( lowestNumber += 1);
                }                
            }            
        }
    }

    public class Television_Definition
    {
        public void RunExercise()
        {
            Television teli = new Television();

            Television teli_2 = new Television("Sony", (decimal)1000.17, 10.5);
        }
    }

    // We need a class to pass as a parameter for this exercises, so
    // we've whipped up the 'Television' class
    public class Television
    {
        private string brand;
        private decimal price;
        private double size;

        public Television()
        {
            this.price = 0;
            this.size = 0;
            this.brand = "";
        }
        public Television(string br, decimal pr, double si)
        {
            if (pr >= 0 && si >= 0)
            {
                price = pr;
                size = si;
                brand = br;
            } else
            {
                return;
            }

            Print();
        }

        public string GetBrand()
        {
            return brand;
        }
        public void SetBrand(string newValue)
        {
            brand = newValue;
        }

        public void Print()
        {
            Console.WriteLine("Brand: {0}\nPrice: {1}\nSize: {2}", brand, price, size);
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class Basic_Array_Of_Objects
    {
        public void RunExercise()
        {
            TelevisionHandler th = new TelevisionHandler();

            th.PrintArrayOfTVs();
        }
    }

    // This is the "user interface" for the Objects-As-Parameters exercise
    public class TelevisionHandler
    {
        public void PrintArrayOfTVs()
        {
            Television[] aBunchOfTVs = new Television[5];
            // Television object for each slot in array
            aBunchOfTVs[0] = new Television("alpha", 10, 42);
            aBunchOfTVs[1] = new Television("beta", 11, 42);
            aBunchOfTVs[2] = new Television("charlie", 12, 42);
            aBunchOfTVs[3] = new Television("doger", 13, 42);
            aBunchOfTVs[4] = new Television("echo", 14, 42);

            for (int i = 0; i < aBunchOfTVs.Length; i++)
            {
                Console.WriteLine(aBunchOfTVs[i]);
            }            
        }

        public void PrintArrayOfPossiblyNullTVs()
        {
            
            Television[] tvArray = new Television[10];

            for (int i = 0; i < 9; i++)
            {
                tvArray[i] = new Television("Tv model " + i, 10 + i, 42);
                Console.WriteLine("\n");
            }

            
            for (int i = 0; i < tvArray.Length; i++)
            {
                if (tvArray[i] == null)
                {
                    Console.WriteLine("Slot {0} is null.\n", i);
                }                
            }
            // ANSWER TO QUESTION FOR B.
            // I get the answer: 
            // Brand: Tv model 14
            //Price: 17
            //Size: 42
            //Brand: Tv model 16
            //Price: 18
            //Size: 42
            //Slot 9 is null.

            // Because slot 9 is the slot before 10, which is the last slot in the array before overflow.
            // The rest is filler and working correctly. Using a printing loop on the array may be useful for
            // checking to see if an input is missing for an important calculation.

            // PART C
            for (int i = 0; i < tvArray.Length; i++)
            {
                if (i == 0 || i == 1 || i == 5 || i == 9)
                {
                    tvArray[i] = null;
                }
                else
                {
                    tvArray[i] = new Television("Tv model X", 10 + i, 42);
                    Console.WriteLine("\n");
                }
            }

            // PART D
            for (int i = 0; i < tvArray.Length; i++)
            {
                if (tvArray[i] == null)
                {
                    Console.WriteLine("Slot {0} is null.\n", i);
                }
            }
            // I get the results I do because I am filling the slots 0, 1, 5, and 9 with the value of null.
            // Otherwise I am filling the array with the traditional "Tv model X" and the corresponding values.
            // the for loop runs after filling the array, and identifies which are null, and which are filled.

            //PART E
            for (int i = 0; i < tvArray.Length; i++)
            {
                if (tvArray[i] == null)
                {
                    tvArray[i] = new Television("TV model X (filled)", 10 + i, 42);
                    Console.WriteLine("\n");
                }
            }
            // I get the results I do because the loop executes after the others so the results are at the end.
            // The price is 10, 11, 15, 19 because those are the corresponding slots that were filled.

            //PART F
            for (int i = 0; i < tvArray.Length; i++)
            {
                tvArray[i] = new Television("Tv model " + i, 10 + i, 42);
                Console.WriteLine("\n");
            }


            for (int i = 0; i < tvArray.Length; i++)
            {
                if (tvArray[i] == null)
                {
                    Console.WriteLine("Slot {0} is null.\n", i);
                }
            }
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    class Array_Of_Possibly_Null_Objects 
    {
        public void RunExercise()
        {
            TelevisionHandler th = new TelevisionHandler();

            th.PrintArrayOfPossiblyNullTVs();
        }
    }
}