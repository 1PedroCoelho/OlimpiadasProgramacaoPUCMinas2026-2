using System;

class URI
{

    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string[] categoria ={"Rolien", "Naej", "Elehcim", "Odranoel"};

        for(int i=0;i<N;i++)
        {
            int K= int.Parse(Console.ReadLine());
            for(int j=0;j<K;j++)
            {
                int opcao = int.Parse(Console.ReadLine());

                Console.WriteLine(categoria[opcao-1]);
            }
        }

    }

}