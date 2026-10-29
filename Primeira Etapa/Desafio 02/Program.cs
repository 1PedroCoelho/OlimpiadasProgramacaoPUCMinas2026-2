using System; 

class URI {

    static void Main(string[] args) { 

        int N = int.Parse(Console.ReadLine());

        for(int i=0;i<N;i++)
        {
            string [] Numeros = Console.ReadLine().Split(' ');
            double X= double.Parse(Numeros[0]);
            double Y= double.Parse(Numeros[1]);

            if (Y==0) Console.WriteLine("divisao impossivel");

            
            else
            {
                double resultado= X/Y;
                Console.WriteLine(resultado.ToString("F1"));
            }

        }

    }

}