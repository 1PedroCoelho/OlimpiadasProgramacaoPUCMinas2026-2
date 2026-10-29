using System;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {



        int casosTeste = int.Parse(Console.ReadLine());


        for (int i = 0; i < casosTeste; i++)
        {
            List<Char> conjuntoLetra = new List<Char>();
            int somadiferente = 0;

            char[] frase = Console.ReadLine().ToCharArray();

            for (int j = 0; j < frase.Length; j++)
            {
                if (frase[j] != ',' && frase[j] != ' ' && !conjuntoLetra.Contains(frase[j]))
                {
                    conjuntoLetra.Add(frase[j]);
                    somadiferente++;
                }
            }
            if (somadiferente == 26)
                Console.WriteLine("frase completa");
            else if (somadiferente >= 13)
                Console.WriteLine("frase quase completa");
            else if (somadiferente < 13)
                Console.WriteLine("frase mal elaborada");

        }
    }

}