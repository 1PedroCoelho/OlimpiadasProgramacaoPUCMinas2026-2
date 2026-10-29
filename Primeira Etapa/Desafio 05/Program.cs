using System;

class URI
{

    static void Main(string[] args)
    {
        int casos = int.Parse(Console.ReadLine());

        int qntRato = 0;
        int qntSapo = 0;
        int qntCoelho = 0;

        for (int i = 0; i < casos; i++)
        {
            string[] parametro = Console.ReadLine().Split(' ');

            int quantidade = int.Parse(parametro[0]);
            char tipo = char.Parse(parametro[1]);

            if(tipo== 'R') qntRato+=quantidade;
            if(tipo== 'S') qntSapo+=quantidade;
            if(tipo== 'C') qntCoelho+=quantidade;
        }

        double total=qntCoelho+qntRato+qntSapo;
        Console.WriteLine($"Total: {total} cobaias");
        Console.WriteLine($"Total de coelhos: {qntCoelho}");
        Console.WriteLine($"Total de ratos: {qntRato}");
        Console.WriteLine($"Total de sapos: {qntSapo}");

        Console.WriteLine($"Percentual de coelhos: {(double)qntCoelho/total*100:F2} %");
        Console.WriteLine($"Percentual de ratos: {(double)qntRato/total*100:F2} %");
        Console.WriteLine($"Percentual de sapos: {(double)qntSapo/total*100:F2} %");
    }

}