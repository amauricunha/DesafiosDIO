using System;

namespace Consumo.Desafios
{
    public class ComparacaoString
    {
        public void Compara() {
            string[] joias;
            int quantidade = 0;
            int cont = 0 , index = 0;
            joias =  new string[5];
            string joia = " ";
            while (joia != "")
            {
                joia = Console.ReadLine();
                if (joia != "") {
                    joias[index] = joia;
                    index++;
                }
            }
            for(int i = 0; i < index; i++)
            {
                cont++;
                for(int x = cont; x < index; x++)
                {
                    if (String.Compare(joias[i], joias[x]) == 0)
                    {
                        quantidade++;                       
                    }
                }       
            }
            Console.WriteLine(index-quantidade);
        }
    }
}