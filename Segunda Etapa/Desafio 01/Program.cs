using System;

class URI
{

    static void Main(string[] args)
    {

        int casos = int.Parse(Console.ReadLine());

        for(int i=0;i<casos;i++)
        {
            int x=int.Parse(Console.ReadLine());
            int soma=0;
            
            for(int j =1;j<=x;j++)
            {    
                if(x%j==0) 
                {
                    soma+=x/j;  
                }
            }
            soma-=x;

            if(soma==x) Console.WriteLine($"{x} eh perfeito");
            else Console.WriteLine($"{x} nao eh perfeito");
        }

    }

}