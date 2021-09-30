using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSTraining
{
    class ReplaceBooksClass
    {
        readonly Random rnd = new Random();
        public static List<string> callNums = new List<string>();
        public static List<string> sortedCallNums = new List<string>();
        public static List<string> enteredCallNums = new List<string>();
        //public static List<string> confirmedCallNums = new List<string>();
        public static int points;

        
        public void GenerateCallNumbers()
        {
            string cn;
            int wholeNumber;
            int deci;
            char ranLet;
            int cutterNum;

            for (int i = 0; i < 10; i++)
            {

                //------------------------------------code attribution---------------------------------------
                //Author:   Guffa, StackOverflow
                //Link:     https://stackoverflow.com/questions/2706500/how-do-i-generate-a-random-int-number

                wholeNumber = rnd.Next(000, 1000);
                deci = rnd.Next(0, 100000);
                cutterNum = rnd.Next(0, 1000);

                //------------------------------------------end----------------------------------------------


                //--------------------------------code attribution-----------------------------------
                //Author:   Riptutorial.com
                //Link:     https://riptutorial.com/csharp/example/28125/generate-a-random-character

                ranLet = (char)rnd.Next('A', 'Z');

                //--------------------------------------end------------------------------------------


                if (wholeNumber < 10)
                {
                    cn = $"00{wholeNumber}.{deci} {ranLet}{cutterNum}";
                } 
                else if (wholeNumber < 100)
                {
                    cn = $"0{wholeNumber}.{deci} {ranLet}{cutterNum}";
                }
                else
                {
                    cn = $"{wholeNumber}.{deci} {ranLet}{cutterNum}";
                }

                callNums.Add(cn);
            }
        }

        public void CompareCallNums()
        {
            int pointCounter = 0;

            for (int i = 0; i < 10; i++)
            {
                if (enteredCallNums[i] == sortedCallNums[i])
                {
                    Console.WriteLine("Correct, {0}", i);
                    pointCounter++;
                    
                }
                else
                {
                    Console.WriteLine("Incorrect, {0}", i);
                }
            }
            Console.WriteLine("points: " + pointCounter);
            points = pointCounter;
        }

        //--------------------------------code attribution-----------------------------------
        //Author:   Microsoft
        //Link:     https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-5.0
        public void SortGeneratedCallNums()
        {
            sortedCallNums = callNums;
            sortedCallNums.Sort();
            Console.WriteLine("generated nums");
            foreach (var num in sortedCallNums)
            {
                Console.WriteLine("   {0}", num);
            }
        }
        //--------------------------------------end------------------------------------------

        public void RBCReset()
        {
            callNums.Clear();
            sortedCallNums.Clear();
            enteredCallNums.Clear();
        }
        
    }
}
