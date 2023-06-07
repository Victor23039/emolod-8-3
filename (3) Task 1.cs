using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = new int[10];
            int min = 0;
            bool f_first;
            Random rnd_num = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = rnd_num.Next(0, 20);
            }

            for (int i = 0; i < A.Length; i++)
                Console.Write("{0} ", A[i]);
            Console.WriteLine();
            f_first = true;
            foreach (int item in A)
            {
                if (f_first)
                {
                    min = item;
                    f_first = false;
                }
                else
                {
                    if (min > item)
                        min = item;
                }
            }


            Console.WriteLine(" min = {0}", min);

            Console.ReadKey();
        }
    }
}
