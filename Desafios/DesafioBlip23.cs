using System;
using System.Globalization;

namespace Consumo.Desafios
{
    public class DesafioBlip23
    {
        public void desafioBlip23() { 

            int t = Convert.ToInt32(Console.ReadLine());
            double[] arrayList = new double[4];
            int pa, pb;
            double cpa, cpb;
            int anos;

            for (int i = 0; i < t; i++)
            {
                anos = 0;
                string[] valores = Console.ReadLine().Split();
                pa = int.Parse(valores[0]);
                pb = int.Parse(valores[1]);

               //declare as variaveis corretamente
                cpa = double.Parse(valores[2], CultureInfo.InvariantCulture);
                cpb = double.Parse(valores[3], CultureInfo.InvariantCulture);

                while (pa <= pb)
                {

                    pa = pa + (int)(pa*(cpa/100));
                    pb = pb + (int)(pb*(cpb/100));
                    anos++;
                    if (anos > 100)
                    {
                        Console.WriteLine("Mais de 1 seculo.");
                        break;
                    }

                }

                if (anos <= 100)
                {
                   Console.WriteLine(anos + " anos.");
                }                
                

            }

        }
        
    }
}