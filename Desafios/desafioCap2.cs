using System;
using System.Globalization;

namespace Consumo.Desafios
{
    public class desafioCap2
    {
        public void dasafiocap2() { 
        string[] line = Console.ReadLine().Split(' ');
        double a = double.Parse(line[0]);
        double b = double.Parse(line[1]);
        double c = double.Parse(line[2]);
        double pi = 3.14159;
		
		//Insira aqui o seu código 
        //a) a área do triângulo retângulo que tem A por base e C por altura.
        // dividir por 2 o resultado da multiplicação da base (b) pela altura (h)
        double triangulo = (a*c)/2;
        triangulo = Math.Round(triangulo*1000)/1000;
        //b) a área do círculo de raio C. (pi = 3.14159)
        // pi vezes o raio elevado ao quadrado
        double circulo = pi*(c*c);
        circulo = Math.Round(circulo*1000) / 1000;
        //c) a área do trapézio que tem A e B por bases e C por altura.
        //somar a base maior e base menor, multiplicar pela altura e depois, basta dividir o resultado por dois
        double trapezio = ((a + b)*c )/2;
        trapezio = Math.Round(trapezio*1000) / 1000;
        //d) a área do quadrado que tem lado B.
        //l*l
        double quadrado = b*b;
        quadrado = Math.Round(quadrado*1000) / 1000;
        //e) a área do retângulo que tem lados A e B.
        //multiplicar o valor da base com o da altura
        double retangulo = a*b;
        retangulo = Math.Round(retangulo*1000) / 1000;
		
        Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("F3",CultureInfo.InvariantCulture));
        Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3",CultureInfo.InvariantCulture));
        Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3",CultureInfo.InvariantCulture));
        Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3",CultureInfo.InvariantCulture));
        Console.WriteLine("RETANGULO: {0}", retangulo.ToString("F3",CultureInfo.InvariantCulture));

        }
    }
}