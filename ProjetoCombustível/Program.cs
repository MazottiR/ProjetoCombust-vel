using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCombustível
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do combustível: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a distância percorrida: ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a distância percorrida por litro: ");
            double l = double.Parse(Console.ReadLine());

            double resultado = (d / l) * c;
            
            Console.WriteLine("O total gasto foi: R$" + resultado);

            Console.ReadKey();

        }
    }
}
