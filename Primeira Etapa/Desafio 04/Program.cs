using System;
using System.Globalization;

class URI {

    static void Main(string[] args) { 

        while(true)
        {
            int Amostras = int.Parse(Console.ReadLine());

            if(Amostras==0) return;

            int[] ArrayAmostras=new int[Amostras];

            string [] lista = Console.ReadLine().Split(' ');

            for(int i=0; i<Amostras;i++)
            {
                ArrayAmostras[i]= int.Parse(lista[i]);
            }

            int somaPicos=0;

            for(int j=0; j<ArrayAmostras.Length;j++)
            {
                int inicio= ArrayAmostras[0];    
                int final= ArrayAmostras[Amostras-1];

                if(j==0)
                {
                    if(inicio>ArrayAmostras[j+1] && inicio>final)
                    {
                        somaPicos+=1;
                    }
                    else if(inicio<ArrayAmostras[j+1] && inicio<final)
                    {
                        somaPicos+=1;
                    }
                }
                else if (j==ArrayAmostras.Length-1)
                {
                    if(final>ArrayAmostras[j-1] && final>inicio)
                    {
                        somaPicos+=1;
                    }
                    else if (final<ArrayAmostras[j-1] && final<inicio)
                    {
                        somaPicos+=1;
                    }
                }

                else if(ArrayAmostras[j]>ArrayAmostras[j+1] && ArrayAmostras[j]>ArrayAmostras[j-1])
                {
                    somaPicos+=1;
                }
                   else if(ArrayAmostras[j]<ArrayAmostras[j+1] && ArrayAmostras[j]<ArrayAmostras[j-1])
                {
                    somaPicos+=1;
                }

            }
            Console.WriteLine(somaPicos);
        }

    }

}