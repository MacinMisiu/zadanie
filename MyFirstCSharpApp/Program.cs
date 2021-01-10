using System;

namespace MyFirstCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj Ilość krasnali: ");
            string line = Console.ReadLine();
            int krasnale = int.Parse(line);

            int n = krasnale;


            Console.WriteLine("Podaj Ilość złota: ");

            double[] gold = new double[n];
            double sumazlota = 0;
            for (int i = 0; i< n; i++)
            {
                line = Console.ReadLine();
                double ilosczlotakrasnala = double.Parse(line);
                gold[i] = ilosczlotakrasnala;
                sumazlota += ilosczlotakrasnala;
                
            }
            double sredniazlota = (sumazlota / n);
            Console.WriteLine("Suma zlota = " + sumazlota);
            Console.WriteLine("Srednia zlota = " + sredniazlota);

            for (int i = 0; i < n; i++)
            {
                double roznicazlota = (sredniazlota - gold[i]);
                if(roznicazlota>0)
                {
                    Console.WriteLine("Krasnal nr." + i + " ma otrzymać " + roznicazlota + " zlota");
                }
                else if(roznicazlota<0)
                {
                    Console.WriteLine("Krasnal nr." + i + " ma oddać " + (-roznicazlota) + " zlota");
                }
                else
                {
                    Console.WriteLine("Krasnal nr." + i + " ma tyle złota ile ma mieć");
                }
            }



        }
    }
}
