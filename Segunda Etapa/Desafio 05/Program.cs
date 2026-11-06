using System;

class Program
{
    static void Main()
    {
        string entrada;

        while ((entrada = Console.ReadLine()) != null)
        {
            string numero = "";

            foreach (char c in entrada)
            {
                if (c == 'O' || c == 'o')
                    numero += '0';
                else if (c == 'l')
                    numero += '1';
                else if (c == ' ' || c == ',')
                    continue;
                else if (char.IsDigit(c))
                    numero += c;
                else
                {
                    numero = "";
                    break;
                }
            }

            if (numero.Length == 0)
            {
                Console.WriteLine("error");
            }
            else if (long.TryParse(numero, out long valor) && valor <= int.MaxValue)
            {
                Console.WriteLine(valor);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}