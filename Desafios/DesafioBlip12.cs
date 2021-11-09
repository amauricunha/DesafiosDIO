using System;

namespace Consumo.Desafios
{
    public class DesafioBlip12
    {
        public void desafioBlip12() { 

            //Leia quatro valores inteiros A, B, C e D
            int A, B, C, D;  //declare suas variaveis              ;
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            //calcule e mostre a diferença do produto de A e B pelo produto de C e D
            Console.WriteLine("DIFERENCA = " +   (  A   *  B    -  C   *  D   ));
            Console.ReadKey();

        }
        
    }
}