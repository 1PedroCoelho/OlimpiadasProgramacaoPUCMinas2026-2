using System;

class URI
{

    static void Main(string[] args)
    {
        int casosTestes = int.Parse(Console.ReadLine());

        for(int i=0; i<casosTestes;i++)
        {
            int totalLeds=0;
            char[] Numero= Console.ReadLine().ToCharArray();
            
            foreach(char x in Numero)
            {
                if(x=='1') totalLeds+=2;
                if(x=='2') totalLeds+=5;
                if(x=='3') totalLeds+=5;
                if(x=='4') totalLeds+=4;
                if(x=='5') totalLeds+=5;
                if(x=='6') totalLeds+=6;
                if(x=='7') totalLeds+=3;
                if(x=='8') totalLeds+=7;
                if(x=='9') totalLeds+=6;
                if(x=='0') totalLeds+=6;
            }
            Console.WriteLine($"{totalLeds} leds");
        }

       
    }

}