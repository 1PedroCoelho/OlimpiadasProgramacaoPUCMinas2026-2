using System;

class Program
{
    static void Main()
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            int L = int.Parse(entrada);

            string[] velocidades = Console.ReadLine().Split(' ');

            int maior = 0;

            for (int i = 0; i < L; i++)
            {
                int velocidade = int.Parse(velocidades[i]);

                if (velocidade > maior)
                    maior = velocidade;
            }

            if (maior >= 20)
                Console.WriteLine(3);
            else if (maior >= 10)
                Console.WriteLine(2);
            else
                Console.WriteLine(1);
        }
    }
}