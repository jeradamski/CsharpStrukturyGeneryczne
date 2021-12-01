using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace _4_MetodyDelegatyGeneryczne
{
    public static class KolejkaExtentions
    {
        //public delegate void Drukarka<T>(T dane); //delegat
        
        public static IEnumerable<Twyjscie> Mapuj<T, Twyjscie>(this IKolejka<T> kolejka, Converter<T,Twyjscie> konwerter)  //tzw. metody rozszerzenia (dla IKolejka<T>). Musi być statyczna
        {
            //var konwerter = TypeDescriptor.GetConverter(typeof(T)); //konwertuje różne typy

            foreach (var item in kolejka)
            {
                //Twyjscie wynik = (Twyjscie)konwerter.ConvertTo(item, typeof(Twyjscie)); //z poprzednich lekcji
                Twyjscie wynik = konwerter(item);
                yield return wynik;
            }
        }

        //public static void Drukuj<T>(this IKolejka<T> kolejka, Drukarka<T> wydruk) //z lekcji o delegacie generycznym
        public static void Drukuj<T>(this IKolejka<T> kolejka, Action<T> wydruk)
        {
            foreach (var item in kolejka)
            {
                //System.Console.WriteLine(item);
                wydruk(item);
            }
        }

    }
}
