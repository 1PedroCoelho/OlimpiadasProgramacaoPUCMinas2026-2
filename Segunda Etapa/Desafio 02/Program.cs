using System;

class Program
{
    static void Main()
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            string[] dados = entrada.Split(' ');

            int N = int.Parse(dados[0]);
            int L = int.Parse(dados[1]);
            int C = int.Parse(dados[2]);

            string[] palavras = Console.ReadLine().Split(' ');

            int paginas = 1;
            int linhas = 1;
            int caracteres = 0;

            for (int i = 0; i < N; i++)
            {
                int tamanho = palavras[i].Length;

                if (caracteres == 0)
                {
                    caracteres = tamanho;
                }
                else if (caracteres + 1 + tamanho <= C)
                {
                    caracteres += 1 + tamanho;
                }
                else
                {
                    if (linhas == L)
                    {
                        paginas++;
                        linhas = 1;
                    }
                    else
                    {
                        linhas++;
                    }

                    caracteres = tamanho;
                }
            }

            Console.WriteLine(paginas);
        }
    }
}