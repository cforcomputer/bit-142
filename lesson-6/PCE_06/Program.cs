using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic_Array_Of_Objects baoc = new Basic_Array_Of_Objects();
            // baoc.RunExercise();

            // Array_Of_Possibly_Null_Objects aopno = new Array_Of_Possibly_Null_Objects();
            // aopno.RunExercise();

            // Television_Definition td = new Television_Definition();
            // td.RunExercise();

            // Objects_As_Parameters oap = new Objects_As_Parameters();
            // oap.RunExercise();

            //Objects_As_Return_Values oarp = new Objects_As_Return_Values();
            //oarp.RunExercise();

            //Objects_As_Parameters_And_Return_Values oasarv = new Objects_As_Parameters_And_Return_Values();
            //oasarv.RunExercise();

            // Even though these are no longer part of this PCE they're being left here:
            BarChart_Demonstration bcd = new BarChart_Demonstration();
            bcd.RunExercise();

            // TVStorage_Demonstration tvsd_d = new TVStorage_Demonstration();
            // tvsd_d.RunExercise();
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
        // 1. Add new method named PickMoreExpensiveTV
        // Given as 2 parameters (Television objects)
        public Television PickMoreExpensiveTV(Television tvOne, Television tvTwo)
        {
            // Figure out which object costs more using getting methods in Television class
            if (tvOne == tvTwo)
            {
                return tvOne;
            }
            // if the method is given one null parameter and one non-null parameter,
            // then the method should return the non-null parameter.
            else if (tvOne == null && tvTwo != null)
            {
                return tvTwo;
            }
            else if (tvOne != null && tvTwo == null)
            {
                return tvOne;
            }
            // If both parameters are null, then the method should return null.
            else
            {
                return null;
            }
        }

        public void PrintArrayOfTVs()
        {
            Console.WriteLine("You need to implement this!!");
        }

        public void PrintArrayOfPossiblyNullTVs()
        {
            Console.WriteLine("You need to implement this!!");
        }

        public void PrintMyTV(Television theTV)
        {
            // if theTV is null, then print nothing

            // else call the .Print() method on it

            // Example of a 'meaningful' message:
            // Television:
            //     Brand = Zenith
            //     Price = 300.75
            //     Size = 17.5
        }

        public void PrintMyTVUsingGetters(Television theTV)
        {
            // if theTV is null, then print nothing

            // else use getter methods (GetBrand, GetPrice, GetSize)
            // to print out a message here.
        }

        public Television CreateATV()
        {
            return null; // note that you can do this
            // note that this is NOT what you should do for this exercise! :)
        }

        // CreateATVFromUserInput goes here

        // PickMoreExpensiveTV goes here
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

    /////////////////////////////////////////////////////////////////////////////////

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

    class Objects_As_Parameters
    {
        public void RunExercise()
        {
            TelevisionHandler tvh = new TelevisionHandler();

            Television tv = new Television("Sony", 2000.0m, 50);

            Console.WriteLine("Printing using the Print method: ");
            tvh.PrintMyTV(tv);

            Console.WriteLine("Printing using getters: ");
            tvh.PrintMyTVUsingGetters(tv);
        }
    }


    /////////////////////////////////////////////////////////////////////////////////

    class Objects_As_Return_Values
    {
        public void RunExercise()
        {
            TelevisionHandler tvh = new TelevisionHandler();

            Television tv1;

            tv1 = tvh.CreateATV();
            tv1.Print();

            // you MUST call CreateATVFromUserInput, then print out the result

        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    class Objects_As_Parameters_And_Return_Values
    {
        public void RunExercise()
        {
            TelevisionHandler tvh = new TelevisionHandler();
            Television tvOne;
            Television tvTwo;
            Television moreExpensiveTV;

            // Get tvh to create the first TV object
            tvOne = new Television("Brand X", 1000, 42);

            // Get tvh to create the second TV object
            tvTwo = new Television("Brand 7", 50, 40);

            // Next, call the PickMoreExpensiveTV method, saving
            // that more expensive TV into a third local variable, named moreExpensiveTV
            moreExpensiveTV = tvh.PickMoreExpensiveTV(tvOne, tvTwo);

            // Get tvh to figure out which TV is more expensive

            // Print out both TVs
            tvh.PrintMyTV(moreExpensiveTV);
            // Announce which TV is more expensive

            // Print out the moreExpensiveTV

        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class BarChart
    {
        int[] m_numbers;

        public BarChart()
        {
            m_numbers = new int[5];
        }

        public int GetSize()
        {
            return m_numbers.Length;
        }

        public void SetValue(int newVal, int idx)
        {
            if (idx >= 0 && idx < m_numbers.Length)
                m_numbers[idx] = newVal;

            // Interesting point: note the silent failure
            // if idx is out of range
        }

        public int GetValue(int idx)
        {
            if (idx >= 0 && idx < m_numbers.Length)
                return m_numbers[idx];

            // Is this a good value to return here?
            return 0;
        }

        // 1. Implement GetAverage method
        public double GetAverage()
        {
            double sum = 0.0;            
            
            //GetSize() = array.length()
            for (int counter = 0; counter < GetSize(); counter++)
            {
                sum += m_numbers[counter];
            }
            // Divide the total of all by the size of the array
            return sum / GetSize();
        }

        // B. If slot 0 in array contained the value 2
        // Then: following array elements contained
        // 4, 6, 8, and then 10
        public void PrintBarChart()
        {
            for (int counter = 0; counter < GetSize(); counter++)
            {
                double value = m_numbers[counter];
                for (int i = 0; i < value; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

    public class BarChart_Demonstration
    {
        public void RunExercise()
        {
            BarChart h1 = new BarChart();
            BarChart h2 = new BarChart();

            for (int i = 0; i < 5; i++)
            {
                h1.SetValue((i + 1) * 2, i);
                h2.SetValue(10 - i, i);
            }


            Console.WriteLine("Data set 1 (Version 1): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // What if the first two values were different?
            h1.SetValue(5, 0);
            h1.SetValue(7, 1);

            Console.WriteLine("Data set 1 (Version 2): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // Wait, hold on - I got those backwards :)
            h1.SetValue(7, 0);
            h1.SetValue(5, 1);

            Console.WriteLine("Data set 1 (Version 3): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // I just got some new data - let me adjust the first value:
            h1.SetValue(9, 0);

            Console.WriteLine("Data set 1 (Version 4): Avg: {0:0.00}", h1.GetAverage());
            h1.PrintBarChart();
            Console.WriteLine();

            // How do the two data sets compare?
            Console.WriteLine("Data set 1 (Version 4): Avg: {0:0.00}", h1.GetAverage());
            Console.WriteLine("Data set 2 (Version 1): Avg: {0:0.00}", h2.GetAverage());

            Console.WriteLine("\nData set 1:");
            h1.PrintBarChart();
            Console.WriteLine("\nData set 2:");
            h2.PrintBarChart();
            Console.WriteLine();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////

    public class TVStorage
    {
        Television[] tvs = new Television[5];

        public TVStorage()
        {
        }

        // TODO: Implement this method!
        // If the location is invalid (negative, or too large) do nothing.
        // If the parameter is null (and the location is ok), then replace
        //      the object reference in the array with null
        public void StoreTV(int iLocation, Television tvToStore)
        {
        }

        // TODO: Implement this method!
        // If the location is invalid (negative, or too large) return null.
        public Television GetTV(int iLocation)
        {
            return new Television(); // odd, but will guarantee all tests fail, to start
        }

        // TODO: Implement this method!
        // If a given slot in the array is non-NULL, then call .Print on it
        // otherwise, print out "Slot X is null", where X is the slot index.
        public void PrintAllTVs()
        {
        }

    }

    public class TVStorage_Demonstration
    {
        public void RunExercise()
        {
            TVStorage tvs = new TVStorage();
            tvs.PrintAllTVs();

            Television t = new Television("Brand X", 1000, 42);
            tvs.StoreTV(2, t);
            tvs.StoreTV(4, new Television("Brand Y", 2000, 52));

            Television t2 = tvs.GetTV(0);
            Console.WriteLine("Is t2 null? (It should be) {0}", t2 == null);

            tvs.PrintAllTVs();

            t2 = tvs.GetTV(2);
            Console.WriteLine("Is t2 the same as t? (It should be) {0}", t2 == t);

        }
    }
}
