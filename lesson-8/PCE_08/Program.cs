using System;
using System.IO;

namespace PCE_StarterProject
{
	// NOTE: NONE OF THIS CODE WILL WORK UNTIL YOU SET THE 
	// WORKING DIRECTORY IN VISUAL STUDIO.
	// There are instructions in the slides for Input
	// Slide #7, here: http://faculty.cascadia.edu/mpanitz/Courses/BIT142/Lessons/Lesson_08_File_IO/FileIO_Cs_Only_Slides.pptx

    class Program
    {
        static void Main(String[] args)
        {
            File_Exercises fe = new File_Exercises();
            // fe.Average();
            // fe.FindWord();
            fe.Output_Numbers();

            // SSA name_searcher = new SSA();
            // name_searcher.Search();


            SlideExamples_Input_LineByLine se = new SlideExamples_Input_LineByLine();
            //se.Slide_8();
            //se.Slide_14();
            //se.Slide_14_Extra_Example();
            //se.Slide_17();
            //se.Slide_23();
            //se.Slide_26();
            //se.Slide_28();
            //se.Slide_30();
            //se.Slide_32();
            //se.Slide_37();
            //se.Slide_xx_OOP_and_Files();

            SlideExamples_Output so = new SlideExamples_Output();
            // so.Slide_3();
            // so.Slide_4();
            // so.Slide_6();
            // so.Slide_8();
        }
    }

    class File_Exercises
    {
        public void Average()
        {
            char[] delimiters = { ' ', '\t' }; // ignore tabs, ignore spaces
            using (TextReader file = new StreamReader(@"Files\Exercise_Files\NumberJumble.txt"))
            {
                int counter = 0;
                double sum = 0.0;
                string line;
                bool numCheck = false;

                line = file.ReadLine();
                while (line != null)
                {
                    string[] tokensFromLine = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                    foreach(string token in tokensFromLine) {
                        
                        double num;
                        if (Double.TryParse(token, out num))
                        {
                            counter += 1;
                            sum += num;
                            numCheck = true;
                            // Console.WriteLine("counter = {0} \n sum = {1}", counter, sum);
                        }
                    }
                    // Read the next line
                    line = file.ReadLine();
                }

                if (!numCheck)
                {
                    Console.WriteLine("No numbers in the file!");
                }
                // close the file being read
                Console.WriteLine("Average: {0}", sum/counter);
            }            
        }

        public void FindWord()
        {
            using (TextReader file = new StreamReader(@"Files\Exercise_Files\Words.txt"))
            {
                Console.WriteLine("Hello! Type a word to search the text file.");
                string input = Console.ReadLine();
                string wordLine = file.ReadLine();
                bool check = false;

                while (wordLine != null)
                {
                    double num;

                    if(wordLine.Equals(input, StringComparison.InvariantCultureIgnoreCase))
                    {
                        Console.WriteLine("{0} has been FOUND in the text file!", input);
                        check = true;
                    }                    
                    wordLine = file.ReadLine();
                }              
                if (!check)
                {
                    Console.WriteLine("Sorry, the word you are looking for has not been found.");
                }
            }
        }

		public void Output_Numbers()
		{
            // collect numbers to print
            Console.WriteLine("How many integers do you want to print?");
            int numbersToPrint = Convert.ToInt32(Console.ReadLine());

            // collect the first integer to start printing from
            Console.WriteLine("What is the first integer that you want printed?");
            int firstInt = Convert.ToInt32(Console.ReadLine());

            // make a new streamwriter that writes to the newly created output file
            using (StreamWriter file =
            new StreamWriter(@"Files\Exercise_Files\output.txt"))
            {
                for (int i = 0; i < numbersToPrint; i++)
                {
                    file.Write(firstInt + " ");
                    firstInt += 1;
                }
            }

            Console.WriteLine("The program has successfully printed those numbers to the file!");
        }

		public void Output_Maxes()
		{
		}
    }

    // SSA Assignment
    public class SSA
    {
        public void Search()
        {
            Console.WriteLine("Name to search for?");
            string n = Console.ReadLine();
            Search(n, "Files/Exercise_Files/SSA_Names_Long.txt");
        }

        public int[] Search(string targetName, string fileName)
        {
            int[] nums = new int[12];

            // ignore spaces, tabs
            char[] delimiters = { ' ', '\t' };                       

            // Open the file reader
            using (TextReader t = new StreamReader(fileName))
            {
                string sLine = t.ReadLine();
                bool check = false;

                // while there is a new line do --> 
                while (sLine != null && check == false)
                {
                    string[] tokens = sLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    // Console.WriteLine(sLine);

                    int rank;
                    for (int i = 0; i < tokens.Length; i++)
                    {
                        // Search for a name through matching string
                        if (tokens[i].Equals(targetName, StringComparison.InvariantCultureIgnoreCase))
                        {
                            Console.WriteLine("{0} was found!", targetName);
                            check = true;                                                   
                        }

                        // Once the name is found, fill the num array with the next 11 values in line
                        if (Int32.TryParse(tokens[i], out rank) && check == true)
                        {
                            // Add the rank to the array
                            nums[i] = rank;                                                               
                                                      
                                                       
                        }                        
                    }                    
                    sLine = t.ReadLine();
                }
                // if not found, write not found
                if (check == false)
                    Console.WriteLine("{0} was not found", targetName);                
            }

            // Print the year and score
            int year = 1900;
            for (int l = 0; l < 12; l++)
            {
                Console.WriteLine("Year Rank\n{0}\t{1}\n", year, nums[l]);
                year += 10;
            }
            // return null if name not found 
            return nums;
        }
    }

    class SlideExamples_Input_LineByLine
    {
        public void Slide_10()
        {
            String path = "Files\\example.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public void Slide_14()
        {
            TextReader name = new StreamReader("Files\\example.txt");
            // The program reads the file here
            name.Dispose();


            // or, using the more concise syntax:
            using (TextReader name2 = new StreamReader("Files\\example.txt"))
            {
            } // name2.Dispose called here automatically

            // using also works with File.OpenText:
            // (this is not in the slide)
            using (TextReader name2 = File.OpenText("Files\\example.txt"))
            {
            } // name2.Dispose called here automatically
        }

        public void Slide_14_Extra_Example()
        {
            // an example of relative paths that use the forward slash:
            string path = "Files/example.txt";
            bool fExists = File.Exists(path);
            Console.WriteLine("Does example.txt exist?  {1}", path, fExists);
        }

        public void Slide_17()
        {
            using (TextReader t = new StreamReader("missing_file.txt"))
            {
                string s = t.ReadLine();
            }
        }

        // This was listed as 'Slide_17' in a video in the PowerPoint slides
        public void Slide_23()
        {
            using (TextReader file = new StreamReader("Files/numbers.txt"))
            {
                for (int i = 0; i < 5; i++)
                {
                    string sLine = file.ReadLine();
                    Console.WriteLine("{0}<", sLine);
                }
            }
        }

        public void Slide_26()
        {
            using (TextReader file = new StreamReader("Files/numbers.txt"))
            {
                double sum = 0.0;
                for (int i = 0; i < 5; i++)
                {
                    string sLine = file.ReadLine();
                    double dNum;
                    if (Double.TryParse(sLine, out dNum))
                    {
                        sum += dNum;
                        Console.WriteLine("number = {0}", dNum);
                    }
                }
                Console.WriteLine("Sum = {0}", sum);
            }
        }

        public void Slide_28()
        {
            using (TextReader file = new StreamReader("Files/numbers2.txt"))
            {
                double sum = 0.0;
                string sLine;
                sLine = file.ReadLine();
                while (sLine != null)
                {
                    double dNum;
                    if (Double.TryParse(sLine, out dNum))
                    {
                        sum += dNum;
                        Console.WriteLine("number = {0}", dNum);
                    }
                    sLine = file.ReadLine();
                }
                Console.WriteLine("Sum = {0}", sum);
            }
        }

        public void Slide_30()
        {
            char[] delimiters = { ' ', '\t' };
            using (TextReader file = new StreamReader("Files/numbers3.txt"))
            {
                double sum = 0.0;
                string sLine = file.ReadLine();
                while (sLine != null)
                {
                    string[] tokensFromLine = sLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string token in tokensFromLine)
                    {
                        double dNum;
                        if (Double.TryParse(token, out dNum))
                        {
                            sum += dNum;
                            Console.WriteLine("number = {0}", dNum);
                            break; // out of foreach
                        }
                    }
                    sLine = file.ReadLine();
                }
                Console.WriteLine("Sum = {0}", sum);
            }
        }

        public void Slide_32()
        {
            char[] delimiters = { ' ', '\t' };
            int obamaVotes = 0, mccainVotes = 0, eVotes = 0;

            using (TextReader t = new StreamReader("Files/poll.txt"))
            {
                string sLine = t.ReadLine();
                while (sLine != null)
                {
                    string[] tokens = sLine.Split(delimiters,
                                StringSplitOptions.RemoveEmptyEntries);
                    if (tokens.Length < 5)
                    {
                        Console.WriteLine("Did not find the expected number of items on line:\n\t{0}", sLine);
                        sLine = t.ReadLine();
                        continue;
                    }

                    int obama;
                    if (!Int32.TryParse(tokens[1], out obama))
                    {
                        Console.WriteLine("Obama's votes not formatted properly on line\n\t{0}", sLine);
                        sLine = t.ReadLine();
                        continue;
                    }
                    int mccain;
                    if (!Int32.TryParse(tokens[2], out mccain))
                    {
                        Console.WriteLine("McCain's votes not formatted properly on line\n\t{0}", sLine);
                        sLine = t.ReadLine();
                        continue;
                    }

                    if (!Int32.TryParse(tokens[3], out eVotes))
                    {
                        Console.WriteLine("Electoral votes not formatted properly on line\n\t{0}", sLine);
                        sLine = t.ReadLine();
                        continue;
                    }
                    if (obama > mccain)
                        obamaVotes += eVotes;
                    else if (mccain > obama)
                        mccainVotes += eVotes;
                    // on tie neither candidate gets the votes

                    sLine = t.ReadLine();
                }
            }
            Console.WriteLine("Obama: {0} votes", obamaVotes);
            Console.WriteLine("McCain: {0} votes", mccainVotes);
            if (obamaVotes > mccainVotes)
                Console.WriteLine("Overall: Obama");
            else
                Console.WriteLine("Overall: McCain");
        }

        public void Slide_37()
        {
            char[] delimiters = { ' ', '\t' };
            using (TextReader file = new StreamReader("Files/numbers4.txt"))
            {
                double sum = 0.0;
                string sFile = file.ReadToEnd();
                string[] tokensFromFile = sFile.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                foreach (string token in tokensFromFile)
                {
                    double dNum;
                    if (Double.TryParse(token, out dNum))
                    {
                        sum += dNum;
                        Console.WriteLine("number = {0}", dNum);
                    }
                }
                Console.WriteLine("Sum = {0}", sum);
            }
        }

        // This isn't used in the slides, but it's nifty enough
        // that I left it in.  Look it over if you're curious about it, but
        // don't worry about knowing this stuff in detail
        public void Slide_xx_OOP_and_Files()
        {
            using (TextReader t = new StreamReader("Files/poll2.txt"))
            {
                int numLines;  // total number of lines
                int iLine = 0; // which line are we on?

                string sLine = t.ReadLine();
                if (!Int32.TryParse(sLine, out numLines))
                {
                    Console.WriteLine("Expected to find the number of records on the first line, but didn't!");
                    return; // i.e., exit
                }
                PollResult[] results = new PollResult[numLines];


                sLine = t.ReadLine();
                while (iLine < results.Length && sLine != null)
                {
                    results[iLine] = new PollResult(sLine);
                    sLine = t.ReadLine();
                    iLine++;
                }

                foreach (PollResult result in results)
                {
                    result.Print();
                }
            }
        }

        class PollResult
        {
            private string stateAbbrev;
            private int obamaPercent;
            private int mccainPercent;
            private int electoralVotes;
            private string source;
            public string getState() { return stateAbbrev; }
            public int getObamaPercent() { return obamaPercent; }
            public int getMcCainPercent() { return mccainPercent; }
            public int getElectoralVotes() { return electoralVotes; }

            public PollResult(string lineFromFile)
            {
                char[] delimiters = { ' ', '\t' };
                string[] tokens = lineFromFile.Split(delimiters,
                            StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length < 5)
                {
                    Console.WriteLine("Did not find the expected number of items on line:\n\t{0}", lineFromFile);
                    return; // better to throw an exception here
                }

                if (!Int32.TryParse(tokens[1], out obamaPercent))
                {
                    Console.WriteLine("Obama's votes not formatted properly on line\n\t{0}", lineFromFile);
                    return;
                }

                if (!Int32.TryParse(tokens[2], out mccainPercent))
                {
                    Console.WriteLine("McCain's votes not formatted properly on line\n\t{0}", lineFromFile);
                    return;
                }

                if (!Int32.TryParse(tokens[3], out electoralVotes))
                {
                    Console.WriteLine("Electoral votes not formatted properly on line\n\t{0}", lineFromFile);
                    return;
                }
                stateAbbrev = tokens[0];

                source = "";
                for (int i = 4; i < tokens.Length; i++)
                {
                    source += tokens[i] + " ";
                }
            }

            public void Print()
            {
                Console.WriteLine("Results for {0}, as reported by \"{1}\":", stateAbbrev, source);
                Console.WriteLine("\tObama:\n\t\tPercent:{0}", obamaPercent);
                Console.WriteLine("\tMcCain:\n\t\tPercent:{0}", mccainPercent);
                if (obamaPercent > mccainPercent)
                    Console.WriteLine("{0} electoral votes for Obama", electoralVotes);
                else
                    Console.WriteLine("{0} electoral votes for McCain", electoralVotes);
            }
        }
    }

    class SlideExamples_Output
    {
        public void Slide_3()
        {
            StreamWriter output = new StreamWriter("out.txt");
            output.WriteLine("Hello, file!");
            output.WriteLine("This is a second line of output.");
            output.Dispose();
        }

        public void Slide_4()
        {
            using (StreamWriter output = new StreamWriter("out.txt"))
            {
                output.WriteLine("Hello, file!");
                output.WriteLine("This is a second line of output.");
            } // output.Dispose() called here automatically
            // This is C#-specific
        }

        public void Slide_6()
        {
            TextWriter out1 = Console.Out;
            TextWriter out2 = new StreamWriter("data.txt");
            out1.WriteLine("Hello, console!");   // goes to console
            out2.WriteLine("Hello, file!");      // goes to file
            out2.Dispose();
        }

        public void Slide_8()
        {
            char[] delimiters = { ' ', '\t' };
            TextReader input = new StreamReader("Files/hours.txt");
            StreamWriter output = new StreamWriter("Files/hours_out.txt");
            String sLine;
            while ((sLine = input.ReadLine()) != null)
            {
                string[] tokensFromLine = sLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                if (tokensFromLine.Length < 3)
                {
                    Console.WriteLine("Line contained fewer than 3 tokens! {0}", sLine);
                    continue; // get next line
                }
                int ID;
                if (false == Int32.TryParse(tokensFromLine[0], out ID))
                {
                    Console.WriteLine("Line did not start with ID number! {0}", sLine);
                    continue; // get next line
                }
                string name = tokensFromLine[1];

                double sum = 0.0;
                int count = 0;
                for (int i = 2; i < tokensFromLine.Length; i++)
                {
                    double dNum;
                    if (Double.TryParse(tokensFromLine[i], out dNum))
                    {
                        sum += dNum;
                        count++;
                    }
                }
                if (count == 0) // didn't find any hours worked
                {
                    Console.WriteLine("Line did not find any hours worked! {0}", sLine);
                    continue; // get next line
                }

                double average = sum / count;
                output.WriteLine("{0} (ID#{1}) worked {2} hours ({3} hours/day)", name, ID, sum, average);
                // If you change output.WriteLine to Console.WriteLine 
                // you’d see the output on the screen
            }

            output.Dispose();
        }
    }
}
