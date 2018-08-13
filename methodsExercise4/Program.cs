using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods user1 = new Methods();

            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter another number(not required) or just press enter.");
            int num2 = Int32.TryParse(Console.ReadLine(), out num2) ? num2 : 4;

            Console.WriteLine(user1.Problem1(num1, num2));
            Console.ReadLine();

            
            
           
           
        }
    }
}
