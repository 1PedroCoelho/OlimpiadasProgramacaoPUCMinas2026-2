using System;

class Program
{
    static void Main()
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            string[] dimensoes = entrada.Split(' ');

            int N = int.Parse(dimensoes[0]);
            int M = int.Parse(dimensoes[1]);

            int linhaJogador = 0;
            int colunaJogador = 0;

            int linhaPokemon = 0;
            int colunaPokemon = 0;

            for (int i = 0; i < N; i++)
            {
                string[] linha = Console.ReadLine().Split(' ');

                for (int j = 0; j < M; j++)
                {
                    int valor = int.Parse(linha[j]);

                    if (valor == 1)
                    {
                        linhaJogador = i;
                        colunaJogador = j;
                    }
                    else if (valor == 2)
                    {
                        linhaPokemon = i;
                        colunaPokemon = j;
                    }
                }
            }

            int distancia = Math.Abs(linhaJogador - linhaPokemon)
                          + Math.Abs(colunaJogador - colunaPokemon);

            Console.WriteLine(distancia);
        }
    }
}