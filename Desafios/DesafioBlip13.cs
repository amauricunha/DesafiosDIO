using System;
using System.Globalization;

namespace Consumo.Desafios
{
    public class DesafioBlip13
    {
        public void desafioBlip13() { 

            double a, b, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            
            //complete com as variaveis
            mediaP = (( a * 0.35) + ( b * 0.75));
            mediaP = mediaP / (3.5 + 7.5);
            Console.WriteLine("MEDIA = {0}", mediaP.ToString("F5",CultureInfo.InvariantCulture));

        }
        
    }
}