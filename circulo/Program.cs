using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o raio do circulo: ");

            double raio = double.Parse(Console.ReadLine());

            double area = raio * raio * 3.14;
            double diametro = 2 * raio;
            double perimetro = 2 * 3.14 * raio;

            Console.WriteLine("A área do círculo é: " + area);
            Console.WriteLine("O diâmetro do círculo é: " + diametro);
            Console.WriteLine("O perímetro do círculo é: " + perimetro);

            Console.ReadKey();


        }
    }
}
