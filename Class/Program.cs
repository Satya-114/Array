using System;

namespace Array__class
{
    class Program
    {
        public static void Main()
        {

            // declares an 1D Array of string.
            string[] topic;

            // allocating memory for topic.
            topic = new string[] {"Array, ", "String, ",
                              "Stack, ", "Queue, ",
                              "Exception, ", "Operators"};

            // Displaying Elements of the array
            Console.WriteLine("Topic of C#:");
            Console.WriteLine();

            // Here we calculate and print 
            // the length of the array, i.e. 6
            Console.WriteLine("Length of the array: {0}",
                                           topic.Length);
            foreach (string ele in topic)
                Console.WriteLine(ele + " ");

        }
    }
}
