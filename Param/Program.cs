using System;

namespace Params_array
{
    class Program
    {
        static int add(params int[] allnumber)
        {
            int sum = 0;
            foreach (int n in allnumber)
            {
                sum = sum + n;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum;
            // passing three parameters
            sum = Program.add(1, 2, 3);
            Console.WriteLine("Sum of 1,2,3 is:\t{0}", sum);

            // passing five parameters
            sum = Program.add(3, 5, 2, 6, 2);
            Console.WriteLine("Sum of 3,5,2,6,2 is:\t{0}", sum);
            Console.ReadLine();
        }
    }
}
