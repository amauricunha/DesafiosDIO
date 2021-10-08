using System;
using System.Globalization;

namespace Consumo.Desafios
{
    public class desafioCap3
    {
        public void dasafiocap3() { 
            string[] input = Console.ReadLine().Split(' ');
            double N = int.Parse(input[0]);
            double L = int.Parse(input[1]);
            double perimetro = N*L;

            Console.WriteLine("{0}", perimetro);

        }
    }
}