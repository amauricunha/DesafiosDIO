// algoritmo que calcula o nível de classifição de corridas de tartatura
// para uma entrada (L) da quantidade de tartarugas, espera outra entraga (Vi) com a velocidade 
// das tartarugas.
// percorre o vetor e identificar o nível de 1 a 3 a mais veloz em uma escala pré-definida.

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
                for (int i = 0; i < L; i++)
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