using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMean
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray = new int[] { 8, 6, 10, 11, 9, 6, 10 };

            int x = 0;

            for(int i = 0; i < newArray.Length; i++)
            {
                x += newArray[i];
            }
            int rezult = x / newArray.Length;

             Console.WriteLine(rezult);

            Console.ReadLine();
        }
    }
}
