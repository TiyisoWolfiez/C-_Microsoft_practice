using System;

namespace HelloWorld
{
    class Program
    {       
    
    
    	static void PrintArray(int[] arr)
            {
                for(int k = 1; k < arr.Length+1; ++k)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();

                foreach(int x in arr)
                {
                    Console.Write($"{x} ");
                }
                Console.WriteLine();
            }
    
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5};

            Console.WriteLine("Contents of Array:");
            PrintArray(a); // Pass the array 'a' as an argument
        }
    }
}
