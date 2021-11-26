using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik[] pracownicy = new Pracownik[] //tworzymy tablicę elementów
            {
                new Pracownik {Imie = "Marcin", Nazwisko = "Nowak" },
                new Pracownik {Imie = "Jan", Nazwisko = "Nowak" },
                new Pracownik {Imie = "Łukasz", Nazwisko = "Nowak" },
                new Pracownik {Imie = "Maciej", Nazwisko = "Nowak" }
            };

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            for (int i = 0; i < pracownicy.Length; i++)
            {
                Console.WriteLine(pracownicy[i].Imie + '' + pracownicy[i].Nazwisko);
            }

            Array.Resize(ref pracownicy, 10); //zmienia wielkość tablicy
            pracownicy[9] = new Pracownik { Imie = "Jurek", Nazwisko = "Żurek" };//wrzucamy pracownika na dziesiątą pozycję w tablicy
        }
    }
}
