using System;

class URI
{

    static void Main(string[] args)
    {
        int C =int.Parse(Console.ReadLine());

        for(int i=0;i<C;i++)
        {
            string frase = Console.ReadLine();

            Console.WriteLine($"{(double)frase.Length/100:F2}");
        }
    }

}