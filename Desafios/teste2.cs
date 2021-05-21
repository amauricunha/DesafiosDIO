using System;

namespace Consumo.Desafios
{
    public class teste2
    {
        public void Tartaruga() {
            var entrada = "0";
            while (entrada != null)
            {          
                entrada = Console.ReadLine();
                if ((entrada == "")||(entrada == null) ) {
                    break;
                }
                int L = int.Parse(entrada);
                string[] Vi = Console.ReadLine().Split();
                int maior = 1;
                int velocidade = 0;
                for (int i = 0; i < L; i++) //insira a variavel correta
                {
                int vi = int.Parse(Vi[i]);
                    if(vi > maior) {
                        maior = vi;
                        velocidade = vi;
                    };
                }

                if (velocidade < 10) {
                    Console.WriteLine(1);
                } else if (velocidade < 20) {
                    Console.WriteLine(2);
                } else {
                    Console.WriteLine(3);
                }
            }
        }
    }
}