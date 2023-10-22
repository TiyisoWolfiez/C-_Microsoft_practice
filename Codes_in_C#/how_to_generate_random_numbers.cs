namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        
       Random random = new Random();
        int current = random.Next(1,11);

        do
        {
            current = random.Next(1, 11);
            Console.WriteLine(current);
        } while (current != 7); 
        
        while(current >= 3){
            Console.WriteLine(current);
            current = random.Next(1, 11);
        }
        Console.WriteLine($"Last number: {current}"); 
    }
  }
}




