using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> alimentos = new Dictionary<string, int>()
        {
            {"suco de laranja", 120},
            {"morango fresco", 85},
            {"mamao", 85},
            {"goiaba vermelha", 70},
            {"manga", 56},
            {"laranja", 50},
            {"brocolis", 34}
        };

        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            int T = int.Parse(entrada);

            if (T == 0)
                break;

            int total = 0;

            for (int i = 0; i < T; i++)
            {
                string linha = Console.ReadLine();

                int posicao = linha.IndexOf(' ');

                int N = int.Parse(linha.Substring(0, posicao));
                string alimento = linha.Substring(posicao + 1);

                total += N * alimentos[alimento];
            }

            if (total > 130)
                Console.WriteLine("Menos " + (total - 130) + " mg");
            else if (total < 110)
                Console.WriteLine("Mais " + (110 - total) + " mg");
            else
                Console.WriteLine(total + " mg");
        }
    }
}