using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
    	int k = 100;
		for(int i = 1; i <= k;i++){

    		if(i % 3 == 0){
        		Console.WriteLine(i + " - Fizz");
    		}
    		else if(i % 5 == 0){
        		Console.WriteLine(i + " - Buzz");
    		}
    		else if(i % 3 == 0 && i % 5 == 0){
        		Console.WriteLine(i + " - FizzBuzz");
    		}
    		else{
        		Console.WriteLine(i);
    		}
		}
    }
  }
}
