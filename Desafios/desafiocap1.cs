using System;
using System.Globalization;

namespace Consumo.Desafios
{
    public class desafiocap1
    {
        public void dasafiocap1() { 
            string[] input = Console.ReadLine().Split(' ');
            double A = double.Parse(input[0]);
            double B = double.Parse(input[1]);
            double aumento = (B-A)/A*100;

            Console.WriteLine("{0:F2}%", aumento.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}