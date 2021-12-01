using System;
using static _4_MetodyDelegatyGeneryczne.KolejkaExtentions;

namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
/*        static void KonsolaWypisz(double dane)
        {
            Console.WriteLine(dane);
        }*/

        static void Main(string[] args)
        {
            //Action<double> drukuj = KonsolaWypisz; //action zawsze zwraca void. Action jest rodzajem delegata
            /*            Action<double> drukuj = delegate (double dane) //metoda anonimowa, która zastępuje metodę KonsolaWypisz
                        {
                            Console.WriteLine(dane);
                        };*/

            //Action<double> drukuj = d => Console.WriteLine(d); // wyrażenie lambda, która zastępuje metodę anonimową

            //Action<bool> drukuj = x => Console.WriteLine(x);
            //drukuj(7.89);
            //Action<int, int, int> test = (a, b, c) => Console.WriteLine(a+b+c);
            //test(1, 3, 5); //wyżej dwa przykłady delegatów typu action

            //Func<double, double> potegowanie = d => d * d; //delegat func przyjmuje do 17 parametrów ale zawsze jest wyjsciowy. Może być 1 wyjściowy i 0 wejściowych, ale też 1 wyjściowy i do 16 wejściowych
            //Func<double, double, double> dodaj = (x, y) => x + y;

            //drukuj(potegowanie(4.5));
            //drukuj(dodaj(4.5, 6.7));

            //Predicate<double> jestMniejszeOdSto = d => d < 100; //kolejny delegat, który przyjmuje jeden warunek i zwraca wartość logiczną

            //drukuj(jestMniejszeOdSto(potegowanie(dodaj(6, 7))));

            
            var kolejka = new KolejkaKolowa<double>(pojemnosc:3);
            kolejka.elementusuniety += Kolejka_elementusuniety;
            WprowadzanieDanych(kolejka);

/*            Converter<double, DateTime> konwerter = d => new DateTime(2021, 1, 1).AddDays(d); //kolejny delegat
            var jakoData = kolejka.Mapuj(konwerter);

            foreach (var item in jakoData)
            {
                Console.WriteLine(item);
            }      */                

            
            //var konsolaWyjscie = new Drukarka<double>(KonsolaWypisz);

            //kolejka.Drukuj(KonsolaWypisz);
            //kolejka.Drukuj(drukuj);
            kolejka.Drukuj(d => Console.WriteLine(d)); // wyrażenie lambda wpisane wprost w wywołanie, dzięki czemu nie trzeba tworzyć nowego delegata

            /*var elementyJakoInt = kolejka.ElementJako<double, int>();

            foreach (var item in elementyJakoInt)
            {
                Console.WriteLine(item);
            }*/

            PrzetwarzanieDanych(kolejka);            

        }

        private static void Kolejka_elementusuniety(object sender, ElementUsunietyEventArgs<double> e)
        {
            Console.WriteLine("Kolejka pełna. Element usunięty to: {0}. Nowy element to {1}", e.ElementUsuniety, e.ElementNowy);
        }

        private static void PrzetwarzanieDanych( IKolejka<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("W naszej kolejce jest: ");

            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine(suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscWejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscWejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}
