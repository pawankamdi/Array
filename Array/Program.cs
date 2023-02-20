using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Add(out a);
            Console.WriteLine(a);
           // int[] evenNum = new int[5] { 1, 2, 4, 6, 8 };
            // Console.WriteLine(evenNum[4]);

            //// to read the array
            //for (int i = 0; i < evenNum.Length; i++)
            //    Console.WriteLine(evenNum[i]);

            //for (int i = 0; i < evenNum.Length; i++)
            //    evenNum[i] = evenNum[i] + 10;

            //Console.WriteLine("After Increment");

            //for (int i = 0; i < evenNum.Length; i++)
            //    Console.WriteLine(evenNum[i]);

           // Console.WriteLine(evenNum.Max());
           

            Console.ReadLine();
        }
        static void  Add(out int a)
        {
            a=100;
            a = 20;
        }
    }
}
