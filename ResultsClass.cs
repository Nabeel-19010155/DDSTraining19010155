using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDSTraining
{
    class ResultsClass
    {
        ReplaceBooksClass rbc = new ReplaceBooksClass();
        public static int dispPts;
        public static string dispMedal;
        public static string dispMsg;
        
        public void DetermineResult()
        {
            int pts = ReplaceBooksClass.points;
            int newPts = pts * 2;
            dispPts = newPts;

            if (newPts >= 16)
            {
                Console.WriteLine("gold");
                dispMedal = "goldMedal.png";
                dispMsg = "CONGRATULATIONS!";
            } 
            else if (newPts >= 14 && newPts < 16)
            {
                Console.WriteLine("silver");
                dispMedal = "silverMedal.png";
                dispMsg = "AMAZING!";
            }
            else if (newPts >= 12 && newPts < 14)
            {
                Console.WriteLine("bronze");
                dispMedal = "bronzeMedal.png";
                dispMsg = "GREAT!";
            }
            else if (newPts >= 10 && newPts < 12)
            {
                Console.WriteLine("passed");
                dispMedal = "noMedal";
                dispMsg = "GOOD!";
            } 
            else
            {
                Console.WriteLine("fail");
                dispMedal = "noMedal";
                dispMsg = "FAIL";
            }
        }
    }
}
