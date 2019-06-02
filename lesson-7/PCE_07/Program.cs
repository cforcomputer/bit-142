using System;

namespace PCE_StarterProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // BarChart_Demonstration bcd = new BarChart_Demonstration();
            // bcd.RunExercise();

            // TVStorage_Demonstration tvsd_d = new TVStorage_Demonstration();
            // tvsd_d.RunExercise();

            //Basic_Inheritance bi = new Basic_Inheritance();
            //bi.RunExercise();

            //Constructors_Calling_One_From_Another ccofa = new Constructors_Calling_One_From_Another();
            //ccofa.RunExercise();

            //Calling_Methods_In_Base_Class cmibc = new Calling_Methods_In_Base_Class();
            //cmibc.RunExercise();

            Inheritance_Constructors ic = new Inheritance_Constructors();
            ic.RunExercise();

            // Explain_Basic_Polymorphism ebp = new Explain_Basic_Polymorphism();
            // ebp.RunExercise();

            // Create_Basic_Polymorphic_Method cbpm = new Create_Basic_Polymorphic_Method();
            // cbpm.RunExercise();

            // Polymorphism_And_Arrays paa = new Polymorphism_And_Arrays();
            // paa.RunExercise();

            // Overriding_ToString ot = new Overriding_ToString();
            // ot.RunExercise();

            // ToString_And_Arrays taa = new ToString_And_Arrays();
            // taa.RunExercise();
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

            public double GetAverage()
            {
                // TODO: Implement this!!
                return Double.MinValue;
            }

            public void PrintBarChart()
            {
                // TODO: Implement this!!
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

        // We need a class to pass as a parameter for this exercises, so
        // we're using the 'Television' class
        // PLEASE COPY THIS FROM YOUR PRIOR PCE!
        // I've included just enough code here so that this project compiles, but you'll
        // need the full implementation from the prior class
        public class Television
        {
            public Television() 
            {
            }
            public Television(string br, decimal pr, double si)
            {
            }
        }

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


        class Basic_Inheritance
        {
            public void RunExercise()
            {
                Car carPrinter = new Car();
                FordF250 fordPrinter = new FordF250();
                ToyotaPrius toyotaPrinter = new ToyotaPrius();

                // carPrinter.Print();
                fordPrinter.Print();
                fordPrinter.PrintF250();

                toyotaPrinter.Print();
                toyotaPrinter.PrintToyota();
            }          
        }

        // 1. Create the Car classes (basic inheritance)
        class Car
        {
            private double carWeight = 2000.25;
            private double carTankSize = 10.00;

            public double GetWeight()
            {
                return carWeight;
            }

            public void SetWeight(double carWeight)
            {
                if (carWeight >= 0)
                {
                    this.carWeight = carWeight;
                }                
            }

            public double GetTankSize()
            {
                return carTankSize;
            }

            public void SetTankSize(double carTankSize)
            {
                if (carTankSize >= 0)
                {
                    this.carTankSize = carTankSize;
                }                
            }

            public void Print()
            {
                Console.WriteLine("Weight:{0:N2}", this.carWeight);
                Console.WriteLine("Gas Tank:{0:N2}", this.carTankSize);
            }
        }

        // 1B. Ford F-250 (basic inheritance)
        class FordF250 : Car
        {           
            private double maxPoundsOfCargo = 200.70;

            public double GetMaxPoundsOfCargo()
            {
                return maxPoundsOfCargo;
            }
            public void SetMaxPoundsOfCargo(double maxPoundsOfCargo)
            {
                if (maxPoundsOfCargo >= 0)
                {
                    this.maxPoundsOfCargo = maxPoundsOfCargo;
                }                
            }

            public void PrintF250()
            {
                Console.WriteLine("Max Cargo:{0:N2}", this.maxPoundsOfCargo);                
            }
        }
        // 1C. Toyota prius (basic inheritance)
        class ToyotaPrius : Car
        {
            private double maxPoundsOfCargo = 1337;

            public double GetMaxPoundsOfCargo()
            {
                return maxPoundsOfCargo;
            }
            public void SetMaxPoundsOfCargo(double maxPoundsOfCargo)
            {
                if (maxPoundsOfCargo >= 0)
                {
                    this.maxPoundsOfCargo = maxPoundsOfCargo;
                }
            }

            public void PrintToyota()
            {
                Console.WriteLine("Max Cargo:{0:N2}", this.maxPoundsOfCargo);
            }
        }

        class Constructors_Calling_One_From_Another
        {
            public void RunExercise()
            {

            }
        }
        // 1. Create class (constructors)
        class HomeElectronicsDevice
        {
            private double price;
            private double weight;

            // 2. 
            public HomeElectronicsDevice(double priceInput, double weightInput)
            {
                this.price = priceInput;
                this.weight = weightInput;
            }

            // Getters and setters/////////////
            public void getPrice(double price)
            {
                this.price = price;
            }
            public double setPrice()
            {
                return this.price;
            }
            public void getWeight(double weight)
            {
                this.weight = weight;
            }
            public double getWeight()
            {
                return this.weight;
            }
            /////////////////////////////////////
            
            public void Print()
            {
                Console.WriteLine("Base:");
                Console.WriteLine("The price is: {0}", this.price);
                Console.WriteLine("The weight is: {0}\n", this.weight);
            }
        }

        // 1B. Create class (constructors)
        class TV : HomeElectronicsDevice
        {
            private double screenSize;

            // Constructor for building the object, plus assigning screenSize
            public TV(double priceInput, double weightInput, double screenSizeInput) : base(priceInput, weightInput)
            {
                this.screenSize = screenSizeInput;
            }

            public void setScreenSize(double screenSize)
            {
                this.screenSize = screenSize;
            }
            public double getScreenSize()
            {
                return this.screenSize;
            }

            public void PrintTV()
            {
                Console.WriteLine("Derived 1: TV");
                Console.WriteLine("The screen size is: {0}", this.screenSize);
            }
        }

        // 1C. Create class (constructors)
        class GameConsole : HomeElectronicsDevice
        {
            private double cpuSpeed;

            public GameConsole(double priceInput, double weightInput, double cpuSpeedInput) : base(priceInput, weightInput)
            {
                this.cpuSpeed = cpuSpeedInput;
            }

            public void getCPUSpeed(double cpuSpeed)
            {
                this.cpuSpeed = cpuSpeed;
            }
            public double setCPUSpeed()
            {
                return this.cpuSpeed;
            }

            public void PrintGameConsole()
            {
                Console.WriteLine("Derived 2: GameConsole");
                Console.WriteLine("The CPU speed is: {0}", this.cpuSpeed);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////


        ///////////////////////////////////////////////////////////////////////////////
        // Start " Methods in the base class"
        ///////////////////////////////////////////////////////////////////////////////
        class Calling_Methods_In_Base_Class
        {            
            public void RunExercise()
            {
                // Call derived class jetplane with 4 jet engines
                JetPlane jet = new JetPlane(4);
                jet.Print();
            }
        }

        // 1. Create Plane class
        class Plane
        {
            protected int numberOfPassengers;
            protected double luggageWeight;
            
            public Plane(int numberOfPassengers, double luggageWeight)
            {
                this.numberOfPassengers = numberOfPassengers;
                this.luggageWeight = luggageWeight;
            }
            // Testing, not sure
            public Plane(int numberOfJetEngines, int numberOfPassengers, double luggageWeight)
            {
                this.numberOfPassengers = numberOfPassengers;
                this.luggageWeight = luggageWeight;
                
            }

            public void getNumberOfPassengers(int numberOfPassengers)
            {
                this.numberOfPassengers = numberOfPassengers;
            }
            public int setNumberOfPassengers()
            {
                return this.numberOfPassengers;
            }
            public void getLuggageWeight(double luggageWeight)
            {
                this.luggageWeight = luggageWeight;
            }
            public double setLuggageWeight()
            {
                return this.luggageWeight;
            }
            public void Print()
            {
                Console.WriteLine("NumberPassengers:{0}", this.numberOfPassengers);
                Console.WriteLine(String.Format("Weight:{0:0.00}", this.luggageWeight));
            }
        }

        // 2. Create the JetPlane class
        class JetPlane : Plane
        {
            //  2A. You should set up the “Set” methods on all of your classes so that they only update the private variables if
            // the provided parameter is non-negative(unless it makes sense to have a negative number)
            protected int numberOfJetEngines;
            public JetPlane(int jet) : base(jet, 26, 2212.15534)
            {
                this.numberOfJetEngines = jet;
            }
            public void getNumberOfJetEngines(int numberOfJetEngines)
            {
                this.numberOfJetEngines = numberOfJetEngines;
            }
            public int setNumberOfJetEngines()
            {
                return this.numberOfJetEngines;
            }

            public new void Print()
            {
                base.Print(); // This will call the Plane.Print method
                Console.WriteLine("NumEngines:{0}", this.numberOfJetEngines);
            }
            // 3. What new means = new creates objects, constraints and can invoke constructors. 
            // New in the context of this method means that it's telling the program that this (new) Print is shadowing the base class print.
            // The new keyword used this way allows a type to hide the members of base types, but only if you are using a variable of the type itself.

            // 4. What happens when you leave out base = It will call the default constructor in the base class.
            // This is only okay if there is already a constructor defined in the base class, otherwise there will be an error.
        }

        // Calling One Constructor from Another
        class Inheritance_Constructors
        {            
            public void RunExercise()
            {
                ElectricSaw esaw = new ElectricSaw();
                esaw.Print();

                ElectricSaw esaw2 = new ElectricSaw(15);
                esaw2.Print();

                ElectricSaw esaw3 = new ElectricSaw(3, 25.32);
                esaw3.Print();
            }
        }

        // A. Base Class
        class Saw
        {
            protected int sharpness;

            // default constructor
            public Saw() : this(5) // jump to the main constructor
            {
            }
            // main constructor
            public Saw(int sharp)
            {
                if (sharpness >= 1 && sharpness <= 10)
                {
                    this.sharpness = sharp;
                }
                else
                {
                    Console.WriteLine("Please enter a sharpness value between 1 and 10.");
                }
            }
            public void getSharpness(int sharp)
            {
                this.sharpness = sharp;
            }
            public int setSharpness()
            {               
                    return this.sharpness;                
            }

            // C. Print method
            public void Print()
            {
                Console.WriteLine("Sharpness: {0}", this.sharpness);
            }            
        }

        // B. Derived Class
        class ElectricSaw : Saw
        {
            protected double cordLength;

            public ElectricSaw() : this(6) // call sharpness constructor
            {
                // Default constructor
            }
            // Takes only the value for sharpness
            public ElectricSaw(int sharp) : this(sharp, 20.00)
            {
                // Constructor that sends the values to the third constructor
            }
            // Takes the value for sharpness and the length of the cord
            public ElectricSaw(int sharp, double length) : base(sharp)
            {
                this.cordLength = length;
            }

            public new void Print()
            {
                base.Print();
                Console.WriteLine("Cord Length: {0}", this.cordLength);
            }
        }

        // The comments you need to fill in are inside RunExercise, below:
        class Explain_Basic_Polymorphism
        {
            public void RunExercise()
            {
                BaseClass bcRef1 = new BaseClass();
                BaseClass bcRef2 = new DerrivedClassOne();
                BaseClass bcRef3 = new TheOtherDerrivedClass();

                Console.WriteLine("variables is of type BaseClass, object is of type BaseClass:");
                bcRef1.VirtualMethod1();
                // What output does the prior line produce?  Paste it in here:
                //

                // Why does bcRef1.VirtualMethod1 produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                //
                bcRef1.VirtualMethodTWO();
                // What output does the prior line produce?  Paste it in here:
                //

                // Why does bcRef1.VirtualMethodTWO produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                //

                Console.WriteLine("variables is of type BaseClass, object is of type DerrivedClassOne:");
                bcRef2.VirtualMethod1();
                // What output does the prior line produce?  Paste it in here:
                //

                // Why does bcRef2.VirtualMethod1 produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                //
                bcRef2.VirtualMethodTWO();
                // What output does the prior line produce?  Paste it in here:
                //

                // Why does bcRef2.VirtualMethodTWO produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                //

                Console.WriteLine("variables is of type BaseClass, object is of type TheOtherDerrivedClass:");
                bcRef3.VirtualMethod1();
                // What output does the prior line produce?  Paste it in here:
                //

                // Why does bcRef3.VirtualMethod1 produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                //
                bcRef3.VirtualMethodTWO();
                // What output does the prior line produce?  Paste it in here:
                //

                // Why does bcRef3.VirtualMethodTWO produce that output?  Which method is it calling, and why?
                // YOUR ANSWER:
                //
            }
        }
        class BaseClass
        {
            public virtual void VirtualMethod1()
            {
                Console.WriteLine("BaseClass.VirtualMethod1!");
            }
            // This is here just to show you that virtual & public can be in either order
            // void (the return type) needs to go immediately prior to the method name, though
            // (try something like public void virtual, and note the compiler errors you get)
            virtual public void VirtualMethodTWO()
            {
                Console.WriteLine("BaseClass.VirtualMethodTWO!");
            }
        }
        class DerrivedClassOne : BaseClass
        {
            public override void VirtualMethod1()
            {
                Console.WriteLine("DerrivedClassOne.VirtualMethod1");
                base.VirtualMethod1();
            }
        }
        class TheOtherDerrivedClass : BaseClass
        {
            public override void VirtualMethodTWO()
            {
                Console.WriteLine("TheOtherDerrivedClass.VirtualMethodTWO");
            }
        }

        public class Create_Basic_Polymorphic_Method
        {
            public void RunExercise()
            {
            }
        }

        public class LightBulb
        {
            public double CalculateLight(double amps)
            {
                // We want to start by returning something that will cause the tests to fail.
                // Not A Number (NaN) is a good choice for that :)
                return Double.NaN;
            }
            public double CalculateHeat(double amps)
            {
                return Double.NaN;
            }
        }
        public class IncandescentLightBulb : LightBulb
        {
        }
        public class FluorescentLightBulb : LightBulb
        {
        }


        class Polymorphism_And_Arrays
        {
            public void RunExercise()
            {
                // This will create 10 spaces, each of which is a blank reference to 
                // a GeneralPrinter.
                GeneralPrinter[] gps = new GeneralPrinter[10];

                gps[1] = new GeneralPrinter();
                gps[2] = new GeneralPrinter(21);
                gps[3] = new SpecificPrinter();

                gps[6] = new GeneralPrinter(1111111);
                gps[7] = new SpecificPrinter();

                for (int i = 0; i < gps.Length; i++)
                {
                    if (gps[i] != null)
                        gps[i].PrintTheMessage();
                }
            }
        }
        public class GeneralPrinter
        {
            private int data; // mostly, we just want to see that there are, in fact,
            // separate objects

            public GeneralPrinter()
            {
                data = 99;
            }
            public GeneralPrinter(int n) // in case you want to create a GP with a specific data value...
            {
                data = n;
            }
            public void PrintTheMessage()
            {
                Console.WriteLine("GeneralPrinter.PrintTheMessage: This is my general message.  My data:{0}", data);
            }
        }
        public class SpecificPrinter : GeneralPrinter
        {
        }


        class Overriding_ToString
        {
            public void RunExercise()
            {
                MyPoint p = new MyPoint(3, 7.6);

                Console.WriteLine("Your point is at:" + p.ToString());
                Console.WriteLine("Your point is at:{0}", p.ToString());
                Console.WriteLine("Your point is at:" + p);
                Console.WriteLine("Your point is at:{0}", p);
            }
        }
        public class MyPoint
        {
            double x;
            double y;
            public MyPoint(double nX, double nY)
            {
                x = nX;
                y = nY;
            }
            double getX() { return x; }
            void setX(double nx) { x = nx; }

            double getY() { return y; }
            void setY(double ny) { y = ny; }
        }

        class ToString_And_Arrays
        {
            public void RunExercise()
            {
                //Object[] objs = new Object[4];
                //objs[0] = new MyPoint(1, 2);
                //objs[1] = new IncandescentLightBulb(10) ; // amps, maybe?
                //objs[2] = new MyPoint(4, 7);
                //objs[3] = new IncandescentLightBulb(20) ; // amps, maybe?

                //for (int i = 0; i < objs.Length; i++)
                //{
                //    string s = objs[i].ToString();
                //    Console.WriteLine(s);
                //}
            }
        }
    }
}