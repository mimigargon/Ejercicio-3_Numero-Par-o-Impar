using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3_Numero_Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número entero:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("El número {0} es {1}", num, isPairOrNot(num));
        }

        public static string isPairOrNot(int num)
        {
            string result = "";
            if(num % 2 == 0)
            {
                result = "par";
            } else
            {
                result = "impar";
            }

            return result;
        }
    }
}
