using System;

class URI
{

    static void Main(string[] args)
    {

        int Estrelas = int.Parse(Console.ReadLine());

        string [] linha = Console.ReadLine().Split(' ');

        int[] carneiros= new int[Estrelas];
        bool[]visitadas = new bool[Estrelas];


        int atacada=0;
    

        for (int i =0;i<Estrelas;i++)
        {
            carneiros[i]=int.Parse(linha[i]);
        }

        for(int j=0;j>=0 && j<Estrelas;)
        {

            bool impar = carneiros[j] % 2 != 0;

            if(!visitadas[j])
            {
                atacada++;
                visitadas[j] = true;
            }

            if(carneiros[j] > 0)
                carneiros[j]--;

            if(impar)
                j++;
            else
                j--;
        }
        long total = 0;

        for (int k = 0; k < carneiros.Length; k++)
        {
            total += carneiros[k];
        }
        Console.WriteLine($"{atacada} {total}");

    }

}