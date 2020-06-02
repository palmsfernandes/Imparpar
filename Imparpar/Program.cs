using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imparpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
           
            Console.Write("Digite o numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }

            Console.ReadLine();
        }
        }
    }

