using System;

namespace Consumo.Desafios
{
    public class Desafio42
    {
        public void desafioAva42() { 

            string v = Console.ReadLine();
            char[] arr = v.ToCharArray();
            if(  arr.Length <= 140  ) //complete a condicional
                Console.WriteLine("TWEET");
            else
                Console.WriteLine("MUTE");

        }
        
    }
}