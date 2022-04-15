using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_Minus
{
    internal class Program
    {
        public static void plusMinus(int[] arr)
        {
            int pos = 0;
            int neg = 0;
            int zero = 0;

            for (var i = 0; i<arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    zero++;
                    Console.WriteLine("zero");
                }
                else if (arr[i] == Math.Abs(arr[i]))
                {
                    pos++;
                    Console.WriteLine("pos");
                }
                else
                {
                    neg++;
                    Console.WriteLine("neg");
                }
            }
            Console.WriteLine("{0:F6}", pos/Convert.ToDouble(arr.Length));
            Console.WriteLine("{0:F6}", neg/Convert.ToDouble(arr.Length));
            Console.WriteLine("{0:F6}", zero/Convert.ToDouble(arr.Length));
        }
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 1, 0, -1, -1 };
            plusMinus(arr);
        }
    }
}
