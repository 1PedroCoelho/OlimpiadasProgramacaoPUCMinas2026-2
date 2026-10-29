using System;
using System.Diagnostics;

class URI {

    static void Main(string[] args) { 

        string[] Numeros= Console.ReadLine().Split(' ');

        int Dist = int.Parse(Numeros[0]);
        int Pista = int.Parse(Numeros[1]);

        int resto= Dist%Pista;
        Console.WriteLine(resto);

    }

}