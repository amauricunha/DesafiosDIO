using System;

namespace Consumo.Desafios
{
    public class Desafio41
    {
        public void desafioAva41(int aa, int bb) { 

            //string[] valores = Console.ReadLine().Split();
            int a = aa;//int.Parse(valores[0]);
            int b = bb;//int.Parse(valores[1]);
            int q, r;

           //complete o código aqui -7 -3
            q = a/b;
            r = a - b * q;
            if (r<0)
            {
                r += Math.Abs(b);
                q = (a - r) / b;
            }

            Console.WriteLine("{0} {1}", q, r);

        }
        
    }
}