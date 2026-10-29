using System; 

class URI {

    static void Main(string[] args) 
    { 

        int N = int.Parse(Console.ReadLine());

        for(int i=0;i<N;i++)
        {
            string [] Numeros = Console.ReadLine().Split(' ');
            int X= int.Parse(Numeros[0]);
            int Y= int.Parse(Numeros[1]);

            int soma=0;

            if(X>Y)
            {
                for(int j=Y+1;j<X;j++)
                {
                    if(j%2==1)
                    {
                        soma+=j;
                    }
                }
            }
            if(Y>X)
            {  
                for(int j=X+1;j<Y;j++)
                {
                    if(j%2==1)
                    {
                        soma+=j;
                    }
                }
                
            }
        
            Console.WriteLine(soma);


        }    
        


    }

}