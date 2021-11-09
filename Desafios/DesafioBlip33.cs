using System;
using System.Globalization;

namespace Consumo.Desafios
{
    public class DesafioBlip33
    {
        public void desafioBlip33() { 

            ulong resultado = 1;
            int cont = 0;
            int qtdTeste = int.Parse(Console.ReadLine());
            for (int i = 0; i < qtdTeste; i++)
            {
                int casas = int.Parse(Console.ReadLine()) - 1;
                do{
                    if (cont == 63)
                    {
                        resultado = 1537228672809129;
                        cont ++; 
                        break;
                    }
                    resultado = resultado * 2;
                    cont ++;                    
                }while(cont <= casas);
                if (cont < 64)
                {
                   resultado = resultado/12000; 
                }                                
                Console.WriteLine($"{resultado} kg");
                resultado = 1;
                cont = 0;
            }

        }
        
    }
}