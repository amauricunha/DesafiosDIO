using System;
using System.Globalization;

namespace Consumo.Desafios
{
    public class Terceiro
    {
        public void Third() { 

            double salario = 0.00, reajuste = 0.00, novoSalario = 0.00, percentual = 0;
            salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            //insira os valores corretos de acordo com o enunciado

            if(salario >= 0.00 && salario <= 400.00) //15%
            {
                percentual = 15;
                reajuste = salario * (percentual/100); 
                novoSalario = salario + reajuste;
                
                
            }
            else if (salario >= 400.01 && salario <= 800.00) //12%
            {
                percentual = 12;
                reajuste = salario * (percentual/100);
                novoSalario = salario + reajuste;
                
            }
            else if (salario >= 800.01 && salario <= 1200.00) //10%
            {
                percentual = 10;
                reajuste = salario * (percentual/100);
                novoSalario = salario + reajuste;
            }
            else if (salario >= 1200.01 && salario <= 2000.00) //7%
            {
                percentual = 7;
                reajuste = salario * (percentual/100);
                novoSalario = salario + reajuste;
            }
            else //4%
            {
                percentual = 4;
                reajuste = salario * (percentual/100);
                novoSalario = salario + reajuste;
            }
            Console.WriteLine("Novo salario: {0}", novoSalario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: {0}", reajuste.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: {0} %", percentual);
        }
    }
}