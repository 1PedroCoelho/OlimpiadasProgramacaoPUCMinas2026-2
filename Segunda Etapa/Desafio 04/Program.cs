using System;

class Program
{
    static bool SemRepeticao(int numero)
    {
        bool[] digitos = new bool[10];

        while (numero > 0)
        {
            int digito = numero % 10;

            if (digitos[digito])
                return false;

            digitos[digito] = true;

            numero /= 10;
        }

        return true;
    }

    static void Main()
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            string[] dados = entrada.Split(' ');

            int N = int.Parse(dados[0]);
            int M = int.Parse(dados[1]);

            int contador = 0;

            for (int i = N; i <= M; i++)
            {
                if (SemRepeticao(i))
                    contador++;
            }

            Console.WriteLine(contador);
        }
    }
}