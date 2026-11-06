using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            string[] dados = entrada.Split(' ');

            int C = int.Parse(dados[0]);
            int N = int.Parse(dados[1]);

            int[] estacionamento = new int[C];
            Dictionary<int, int> veiculos = new Dictionary<int, int>();

            int faturamento = 0;

            for (int i = 0; i < N; i++)
            {
                string[] evento = Console.ReadLine().Split(' ');

                if (evento[0] == "C")
                {
                    int placa = int.Parse(evento[1]);
                    int Q = int.Parse(evento[2]);

                    for (int j = 0; j <= C - Q; j++)
                    {
                        bool cabe = true;

                        for (int k = j; k < j + Q; k++)
                        {
                            if (estacionamento[k] != 0)
                            {
                                cabe = false;
                                break;
                            }
                        }

                        if (cabe)
                        {
                            int id = placa;

                            for (int k = j; k < j + Q; k++)
                            {
                                estacionamento[k] = id;
                            }

                            veiculos[placa] = Q;
                            faturamento += 10;

                            break;
                        }
                    }
                }
                else if (evento[0] == "S")
                {
                    int placa = int.Parse(evento[1]);

                    for (int j = 0; j < C; j++)
                    {
                        if (estacionamento[j] == placa)
                        {
                            estacionamento[j] = 0;
                        }
                    }

                    veiculos.Remove(placa);
                }
            }

            Console.WriteLine(faturamento);
        }
    }
}