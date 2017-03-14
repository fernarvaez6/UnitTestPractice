using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestPractice1
{
        public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hash("leepadg"));
            Console.ReadLine();

        }

        public static Int64 Hash(String s)
        {
            //variables
            Int64 h = 7;
            String letters = "acdegilmnoprstuw";
            int index = 0;
            Int64 inc = 0; //Int64 por que no se puede multiplicar long * int64

                //ciclo FOR
                for (int k =0; s.Length > k; k++)
                {
                inc = h * 37;
                index = letters.IndexOf(s[k]);

                h = inc + index;
            
                }
                return h;
        }
    }
}
