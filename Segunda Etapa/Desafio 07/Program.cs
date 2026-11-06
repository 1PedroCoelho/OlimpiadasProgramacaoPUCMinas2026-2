using System;
using System.Text;

class Program
{
    static void Main()
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            StringBuilder resultado = new StringBuilder();
            bool ultimoFoiF = false;

            foreach (char c in entrada)
            {
                char atual = c;

                if ("bjpsvx".IndexOf(c) >= 0)
                    atual = 'f';
                else if ("BJPSVX".IndexOf(c) >= 0)
                    atual = 'F';

                if (atual == 'f' || atual == 'F')
                {
                    if (ultimoFoiF)
                        continue;

                    ultimoFoiF = true;
                }
                else
                {
                    ultimoFoiF = false;
                }

                resultado.Append(atual);
            }

            Console.WriteLine(resultado);
        }
    }
}