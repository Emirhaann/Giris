using System;

namespace RecursiveMetodlar_SOon3_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecursiveFaktoryel(3);
            fibanocci(10);
            //0,1,2,3,5,8,13,21,34,55...
        }

       //GİT HUBDAN ÇEKİP BAK
        public static void fibanocci(int sayi)
        {
            long[] fib = new long[sayi];
            fib[0] = 0;
            fib[1] = 1;
            for (int i = 2; i < sayi; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
                Console.WriteLine("i=" + i + "=>" + fib[i]);
            }
        }


        public static long RecursiveFaktoryel(int sayi)
        {
            if (sayi == 0)
                return 1;
            else
                return sayi * RecursiveFaktoryel(sayi - 1);
        }
            
           
    }
}
