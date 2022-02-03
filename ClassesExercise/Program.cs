using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car("Dodge", "Dakota", 1997);

            Console.WriteLine($"Make:{myCar.Make} Model:{myCar.Model} Year{myCar.Year}");
        }
    }
}
