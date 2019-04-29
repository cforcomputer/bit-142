using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic_Parameters bp = new Basic_Parameters();
            // bp.RunExercise();

            // Number_Printing_With_Parameters pnwp = new Number_Printing_With_Parameters();
            // pnwp.RunExercise();

            //Return_Values rv = new Return_Values();
            //rv.RunExercise();

            // Testing_Randomness tr = new Testing_Randomness();
            // tr.RunExercise();

            // Square_Of_Numbers son = new Square_Of_Numbers();
            // son.RunExercise();

            // Square_Of_Numbers_Parameters_Return sonpr = new Square_Of_Numbers_Parameters_Return();
            // sonpr.RunExercise();

            // Detecting_Prime_Numbers dpn = new Detecting_Prime_Numbers();
            // dpn.RunExercise();

            // Array_Basics ab = new Array_Basics();
            // ab.RunExercise();

            // Array_Usage au = new Array_Usage();
            // au.RunExercise();

            // Using_Part_Of_An_Array upoaa = new Using_Part_Of_An_Array();
            // upoaa.RunExercise();

            // Array_Parameter ap = new Array_Parameter();
            // ap.RunExercise();

            Returning_An_Array raa = new Returning_An_Array();
            raa.RunExercise();

            // Fibonnaci_With_Array fwa = new Fibonnaci_With_Array();
            // fwa.RunExercise();

            ///////////////////////////////////////////////////////////////////

            // The following were used to demonstrate topics
            // on the various videos, but aren't used in the actual
            // exercises that you have to hand in:

            //MethodDemo md = new MethodDemo();
            //md.PrintSomethingElse();
            //Console.WriteLine("==========");
            //md.PrintSomething();
            //Console.WriteLine("==========");

            //Return_Ref_Out_Demo rrod = new Return_Ref_Out_Demo();
            //rrod.RunExercise();
        }
    }


    // Call this function from RunExercise, passing two integer arguments to it. 
    // Verify that the larger of the two is displayed when the program runs. Make
    //sure to test your function using several different values (positive, negative, zero, etc, etc). 
    class Basic_Parameters
    {
        public void RunExercise()
        {
            displayMax(10, 15);
            displayMax(-1, 5);
            displayMax(0, -3);
            displayMax(-5, -1);
        }

        public void displayMax(int a, int b)
        {
            Console.WriteLine(Math.Max(a, b));
        }
    }

    class Number_Printing_With_Parameters
    {
        public void RunExercise()
        {
            NumberPrinter np = new NumberPrinter();
            // np.PrintNumbers( -3, 2); // this will print the numbers -3 -2 -1 0 1 2
        }
    }

    class NumberPrinter
    {
        //// Your method goes here:
        //public ??? PrintNumbers( ??????   )
        //{

        //}
    }

    class Return_Values
    {
        public void RunExercise()
        {
            Console.WriteLine("First value?");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Second value?");
            int secondNumber = Int32.Parse(Console.ReadLine());

            int theMax;

            Max m = new Max();

            // TODO: YOU MUST CHANGE THE METHOD DEFINITION OF returnMax,
            // AND THIS NEXT LINE OF CODE, 
            // SO THAT firstNumber AND secondNumber ARE PASSED INTO THE METHOD AS PARAMETERS, 
            // AND THEN STORE THE RESULTING RETURN VALUE INTO theMax.

            theMax = m.returnMax(firstNumber, secondNumber); // you'll need to change this line 
                                                             // Don't forget to assign the return value to theMax!    

            Console.WriteLine("The max of {0} and {1} is {2}", firstNumber, secondNumber, theMax);

        }
    }

    class Max
    {
        // You'll need to change this method
        public int returnMax(int firstNumber, int secondNumber)
        {
            return Math.Max(firstNumber, secondNumber);
        }
    }

    class Params
    {
        public void RunExercise()
        {
        }



    }

    class Testing_Randomness
    {
        public void RunExercise()
        {
            //HelperClass help = new HelperClass();

            //double a1_6 = help.getAverage(1, 6);
            //double a1_10 = help.getAverage(1, 10);
            //double a1_20 = help.getAverage(1, 20);

            //help.checkAverage(1, 6, a1_6);
            //help.checkAverage(1, 10, a1_10);
            //help.checkAverage(1, 20, a1_20);
        }
    }

    class Square_Of_Numbers
    {
        public void RunExercise()
        {
        }
    }

    class Square_Of_Numbers_Parameters_Return
    {
        public void RunExercise()
        {
        }
    }

    class SquarePrinter
    {
    }


    class Detecting_Prime_Numbers
    {
        public void RunExercise()
        {
        }
    }

    class PrimalityDetector
    {
        // // Add your isPrime method here:
        // public ______  isPrime( _______ )
        // {
        //
        //
        // }
    }

    class Array_Basics
    {
        public void RunExercise()
        {
        }
    }

    class Array_Usage
    {
        public void RunExercise()
        {
        }
    }

    class Using_Part_Of_An_Array
    {
        public void RunExercise()
        {
            int[] array = new int[11];

            bool next = true;
            int sumCounter = 0;
            Console.WriteLine("Please enter up to 10 integers higher than 0 \n Type Q/q when you are finished.");
            do
            {
                string userInput = Console.ReadLine();
                if (userInput.Equals("q", StringComparison.OrdinalIgnoreCase) || sumCounter == 10)
                {
                    next = false;
                } else
                {
                    array[sumCounter] = Convert.ToInt32(userInput);
                    sumCounter += 1;

                    Console.WriteLine("You entered a number!\nYou've entered {0} numbers so far", sumCounter);
                }
            } while (next == true);

            decimal sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            decimal average = (sum / sumCounter);

            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
            // calculate sum and average entered by the user
        }
    }

    // These have been commented out so that the other exercises will compile.
    // When you get to this exercise, uncomment it, do the work, and leave this code uncommented
    //      (so your instructor can quickly and easily compile your final, 'fixed' version).
    class Array_Parameter
    {
        public void RunExercise()
        {
            ArrayHelper calculate = new ArrayHelper();

            // allocate the array here - name it something like dataValues
            int[] dataValues = new int[5];

            // call GetUserData( dataValues ); to fill in the array
            //      RunExercise will need to remember how many values were actually filled in
            int howMany = calculate.GetUserData(dataValues);
            Console.WriteLine("\nStored {0} values into the array\n", howMany);

            // call CalculateSum( howManyValues, dataValues );  to get the sum of the values -
            //      store the return value into a variable
            // print the sum (using the variable)
            Console.WriteLine("\nThe total is: {0}\n", calculate.CalculateSum(howMany, dataValues));

            // Do everything a second time, just to make sure it works with a different array
            int[] nums2 = new int[10];

            howMany = calculate.GetUserData(nums2);
            Console.WriteLine("\nStored {0} values into the array\n", howMany);

            // How many to sum up
            Console.WriteLine("\nThe total is: {0}\n", calculate.CalculateSum(howMany, nums2));

            // Make sure CalculateSum totals up everything in the array (AND DOES NOT CRASH) when
            // given a 'howMany' parameter that's larger than the array

            int[] nums3 = new int[3] { -10, 9, 4 };
            howMany = 20; // note that this is larger than the 3 element array that we're using

            Console.WriteLine("\nTesting CalculateSum with negative values and a 'howMany' parameter larger than the array\n");
            Console.WriteLine("\nThe total is: {0}\n", calculate.CalculateSum(howMany, nums3));
            // note that the total should be 13.  If it's just 3 then you're including negative numbers, which
            // is a mistake
        }
    }

    class ArrayHelper
    {
        public int GetUserData(int[] array)
        {
            bool next = true;
            int sumCounter = 0;
            Console.WriteLine("Please enter up to {0} integers higher than 0 \n Type Q/q when you are finished.", array.Length);
            do
            {
                string userInput = Console.ReadLine();
                if (userInput.Equals("q", StringComparison.OrdinalIgnoreCase) || sumCounter == array.Length)
                {
                    next = false;
                }
                else
                {
                    array[sumCounter] = Convert.ToInt32(userInput);
                    sumCounter += 1;

                    Console.WriteLine("You entered a number!\nYou've entered {0} numbers so far", sumCounter);
                }
            } while (next == true);

            return sumCounter;
        }
        public int CalculateSum(int sum, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }

    class Returning_An_Array
    {
        public void RunExercise()
        {
            ArrayReturnMethods exporter = new ArrayReturnMethods();
            int[] nums1; // Array will be allocated by 
                         // CreatedRandomlyFilledArray, below

            // Create an array of 10 integers, filled with random numbers
            nums1 = exporter.CreateRandomlyFilledArray(10);

            exporter.PrintArray(nums1);
        }
    }



    class ArrayReturnMethods
    {
        public int[] CreateRandomlyFilledArray(int input)
        {
            int[] numsReturn = new int[input];

            Random randNum = new Random();

            // Fill the array with random ints from 0 to 100
            for (int i = 0; i < numsReturn.Length; i++)
            {
                numsReturn[i] = randNum.Next(0, 101);
            }
            return numsReturn;

        }

        public void PrintArray(int[] importArray)
        {
            for (int count = 0; count < importArray.Length; count++)
            {
                Console.WriteLine(importArray[count]);
            }
        }
    }


	class Fibonnaci_With_Array
	{
		public void RunExercise()
		{
		}
	}

	///////////////////////////////////////////////////////////////////

	// The following were used to demonstrate topics
	// on the various videos, but aren't used in the actual
	// exercises that you have to hand in:   

	class MethodDemo
	{
		public void PrintSomethingElse()
		{
			Console.WriteLine("Something else");
		}

		public void PrintSomething()
		{
			Console.WriteLine("Hello!");
			this.PrintSomethingElse(); // valid, 115-like
			PrintSomethingElse(); // also valid

			Basic_Parameters_Demo bpd = new Basic_Parameters_Demo();
			bpd.RunExercise();
		}
	}

	class Basic_Parameters_Demo
	{
		public void RunExercise()
		{

			// // This was used in a video. Feel free to uncomment & play with it
			Demo d = new Demo();
			int theNum = 3;
			d.ParameterDemo(theNum, 3.2); // an argument
			Console.WriteLine(theNum);

			Console.WriteLine("First value?");
			int firstNumber = Int32.Parse(Console.ReadLine());

			Console.WriteLine("Second value?");
			int secondNumber = Int32.Parse(Console.ReadLine());

			// MaxPrinter mp = new MaxPrinter();
			// call displayMax here, with firstNumber and secondNumber
		}
	}

	// This was used in a video; you don't have to do anything with it yourself
	public class Demo
	{

		public void ParameterDemo(int theNum, double n2) // parameter, aka 'formal argument'
		{
			theNum = 10;
			Console.WriteLine("value passed in is: {0} {1}", theNum, n2);

			return;
		}


	}


	class Return_Values_Demo
	{
		public void RunExercise()
		{
			// This was used in a video. Feel free to uncomment & play with it
			ReturnValueHelper rvd = new ReturnValueHelper();
			int importantValue = 99;

			importantValue = rvd.ProduceReturnValue();

			Console.WriteLine(importantValue);
		}
	}

	// This was used in a video; you don't have to do anything with it yourself
	class ReturnValueHelper
	{
		public int ProduceReturnValue()
		{
			int number = 10;

			if (number < 5)
				return number;

			Console.WriteLine("Hello!");
			return 10;
		}
	}

	class Return_Ref_Out_Demo
	{
		public void RunExercise()
		{
			// This was used in a video. Feel free to uncomment & play with it
			Return_Ref_Out_Examples rvd = new Return_Ref_Out_Examples();

			int importantValue = 99;
			importantValue = rvd.ProduceReturnValue();
			Console.WriteLine(importantValue);

			int otherValue; // NOTICE: NOT initialized!
			rvd.InitializeVariables(out importantValue, out otherValue);
			Console.WriteLine("ImportantValue: {0} otherValue: {1}", importantValue, otherValue);

			otherValue = 10;
			rvd.PrintOrMakePositive(ref otherValue);
			Console.WriteLine("otherValue: {0}", otherValue);

			otherValue = -10;
			rvd.PrintOrMakePositive(ref otherValue);
			Console.WriteLine("otherValue: {0}", otherValue);
		}
	}

	// This was used in a video; you don't have to do anything with it yourself
	class Return_Ref_Out_Examples
	{
		public int ProduceReturnValue()
		{
			int number = 10;

			return number;
		}

		public void InitializeVariables(out int num1, out int num2)
		{
//            Console.WriteLine(num1); // note the compiler error!
			num1 = 0;
			num2 = 0;
			Console.WriteLine("num1 is now: {0}", num1);
		}

		public void PrintOrMakePositive(ref int num1)
		{
			if (num1 > 0)
				Console.WriteLine("num1 is: {0}", num1);
			else
				num1 = 1; // 1 is positive :)
		}
	}

	class ArrayExamples
	{
		public void RunExercise()
		{
			int[] nums = new int[5];
			// put vlaues into nums
			int x = 3;

			ArrayDemo ad = new ArrayDemo();
			ad.PrintArray(x, nums);

			int num = ad.ReturnNumber();

			int[] moreNums; // NOTE: NO new int[] - we'll do that below
			moreNums = ad.ReturnArray();

			ad.PrintArray(-10, moreNums);
		}
	}

	class ArrayDemo
	{
		public void PrintArray(int oneNum, int[] numsToPrint)
		{
			Console.WriteLine(oneNum);

			for (int i = 0; i < numsToPrint.Length; i++)
				Console.WriteLine(numsToPrint[i]);
		}

		public int ReturnNumber()
		{
			int x = 0;
			// x is given a value, somehow
			//      we'll leave that out since this 
			//      example focuses on returning the value
			return x+1;
		}

		public int[] ReturnArray()
		{
			int[] nums = { 1, 2 + 1, this.ReturnNumber() };
				// turns out, you can put code into the initializer
				// that will be executed at run-time

			// normally you'd do more with the array
			return nums;
		}
	}
}
