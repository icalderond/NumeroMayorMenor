using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMayorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            string A;
            string B;

            //while: Significa mientras
            //Do While: Significa Hacer mientras
            do
            {
                Console.Clear();
                Console.WriteLine("Instroduzca dos valores distintos");
                Console.WriteLine("Digite la variable A");
                A = Console.ReadLine();
                Console.WriteLine("Digite la variable B");
                B = Console.ReadLine();
            } while (A == B);

            var letraA = Convert.ToInt32(A);
            var letraB = Convert.ToInt32(B);

            if (letraA > letraB)
                Console.WriteLine("A es el mayor");
            else
                Console.WriteLine("B es el mayor");

            Console.ReadKey();
        }
    }
}
