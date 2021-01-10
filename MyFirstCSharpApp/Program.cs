using System;

namespace MyFirstCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int krasnale = 3;
            Console.WriteLine("Ilość krasnali: " + krasnale +" ");

            float krasnal0 = 16.6f;
            float krasnal1 = 12.7f;
            float krasnal2 = 8.8f;

            Console.WriteLine("Zloto krasnala nr.0: " + krasnal0 + " ");
            Console.WriteLine("Zloto krasnala nr.1: " + krasnal1 + " ");
            Console.WriteLine("Zloto krasnala nr.2: " + krasnal2 + " ");

            float suma = (krasnal0 + krasnal1 + krasnal2);
            Console.WriteLine("W sumie krasnale maja: " + suma + " zlota ");

            float srednia = suma / 3;
            Console.WriteLine("Średnio każdy krasnal ma: " + srednia + " zlota ");

            float krasnal0wynagrodzenie = (krasnal0 - srednia);
            float krasnal1wynagrodzenie = (krasnal1 - srednia);
            float krasnal2wynagrodzenie = (srednia - krasnal2);
            Console.WriteLine("Krasnal nr.0 powinien oddać: " + krasnal0wynagrodzenie + " ponieważ zebrał więcej złota niż średnia ");
            Console.WriteLine("Krasnal nr.1 powinien oddać: " + krasnal1wynagrodzenie + " ponieważ zebrał tyle ile wynosi średnia ");
            Console.WriteLine("Krasnal nr.2 powinien otrzymać: " + krasnal2wynagrodzenie + " ponieważ zebrał mniej niż wynosi średnia ");
        }
    }
}
