using System;
using System.Globalization;

namespace Consumo.Desafios
{
    public class ValidacaoNotas
    {
        public void ValidaNota() {
            int novoCaulculo = 0;
            double n2 = -1;
            double n1;
            while (novoCaulculo!=2) {
                novoCaulculo = 0;
                n1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                n2 = -1;
                if ((n1 <= 0)||(n1 >= 10)) {
                    Console.WriteLine("nota invalida");
                } else if ((n1 >= 0)&(n1 <= 10)) {
                    while ((n2<0)||(n2>10)){
                        n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                        if ((n2 < 0)||(n2 > 10)) {
                            Console.WriteLine("nota invalida");
                        }
                    }
                }
                if ((n2>=0)&(n2<=10)) {
                    double media = (n1+n2)/2;
                   Console.WriteLine("media = "+ media.ToString("F2",CultureInfo.InvariantCulture));
                    while ((novoCaulculo<1)||(novoCaulculo>2)){
                        Console.WriteLine("novo calculo (1-sim 2-nao)");
                        novoCaulculo = int.Parse(Console.ReadLine());
                    } 
                }
            }
        }
    }
}