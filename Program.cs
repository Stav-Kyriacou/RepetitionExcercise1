using System;

namespace RepetitionExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int counter = 0;

            Console.Write("How many times should I repeat? ");
            int repeatAmount = int.Parse(Console.ReadLine());
            

            while(counter < repeatAmount){
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                Console.WriteLine(name);

                counter++;
            }

            Console.WriteLine("Goodbye");
            
        }
    }
}