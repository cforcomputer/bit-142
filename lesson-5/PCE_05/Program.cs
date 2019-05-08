using System;

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

             Access_Control ac = new Access_Control();
             ac.RunExercise();

            // Overloading_Create_Your_Own ocyo = new Overloading_Create_Your_Own();
            // ocyo.RunExercise();

            // Constructors_Exercise ce = new Constructors_Exercise();
            // ce.RunExercise();

            // Scope_Of_Variables sov = new Scope_Of_Variables();
            // sov.RunExercise();

            // Television_Definition td = new Television_Definition();
            // td.RunExercise();

            // Basic_Array_Of_Objects baoc = new Basic_Array_Of_Objects();
            // baoc.RunExercise();

            // Array_Of_Possibly_Null_Objects aopno = new Array_Of_Possibly_Null_Objects();
            // aopno.RunExercise();
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
            
        }
    }

    /// <summary>
    /// Add the blender class to call from access control
    /// 
    /// </summary>

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
        }
    }

    class Scope_Of_Variables
    {
        // Put your comment here:


        public void RunExercise()
        {
            //NumberPrinter np = new NumberPrinter();
            //np.SetLowest(3.14159);
            //np.SetHighest(12);
            //np.Print(true);
            //np.SetHighest(17.1);
            //np.Print(false);
            //np.SetLowest(17); // note that lo == hi
            //np.Print(false);  // no output
            //np.SetLowest(22); // note that lo > hi
            //np.Print(false);  // no output
        }
    }

    public class Television_Definition
    {
        public void RunExercise()
        {
        }
    }

    // We need a class to pass as a parameter for this exercises, so
    // we've whipped up the 'Television' class
    public class Television
    {
        public Television()
        {
        }
        public Television(string br, decimal pr, double si)
        {
        }

        public string GetBrand()
        {
            return "YOU NEED TO IMPLEMENT THIS!";
        }
        public void SetBrand(string newValue)
        {
        }

        public void Print()
        {
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
            Console.WriteLine("You need to implement this!!");
        }

        public void PrintArrayOfPossiblyNullTVs()
        {
            Console.WriteLine("You need to implement this!!");
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