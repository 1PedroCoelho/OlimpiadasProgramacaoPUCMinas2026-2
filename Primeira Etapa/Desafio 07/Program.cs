using System;

class URI
{

    static void Main(string[] args)
    {

        string linha;
        while((linha=Console.ReadLine())!=null)
        {
            string[] lance = linha.Split(' ');
            int A = int.Parse(lance[0]);
            int B = int.Parse(lance[1]);
            int C = int.Parse(lance[2]);

            if(A!=B && A!=C) Console.WriteLine("A");
            else if(B!=A && B!=C) Console.WriteLine("B");
            else if(C!=A && C!=B) Console.WriteLine("C");
            else Console.WriteLine("*");

        }
    }

}