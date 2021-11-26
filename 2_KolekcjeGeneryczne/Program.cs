using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {

            /*            var liczby = new List<int>();
                        var pojemnosc = -1;

                        while (true)
                        {
                            if (liczby.Capacity != pojemnosc)
                            {
                                pojemnosc = liczby.Capacity; 
                                Console.WriteLine(pojemnosc);
                            }
                            liczby.Add(1);
                        }*/

            //Pracownik[] pracownicy = new Pracownik[] //tworzymy tablicę elementów
            List<Pracownik> pracownicy = new List<Pracownik> //tworzymy listę. O wiele bardzie optymalny sposób. Pojemność rozszerza się wraz z dodawaniem elementów w tle.
            {
                new Pracownik {Imie = "Marcin", Nazwisko = "Nowak" },
                new Pracownik {Imie = "Jan", Nazwisko = "Nowak" },
                new Pracownik {Imie = "Łukasz", Nazwisko = "Nowak" },
                new Pracownik {Imie = "Maciej", Nazwisko = "Nowak" }
            };

            pracownicy.Add(new Pracownik { Imie = "Jurek", Nazwisko = "Żurek" }); // dzięki liście mamy dostęp do nowych metod, m.in. dodanie kolejnego elementu listy

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }

            for (int i = 0; i < pracownicy.Count; i++) //przy tablicy trzeba było użyć length zamiast count
            {
                Console.WriteLine(pracownicy[i].Imie + " " + pracownicy[i].Nazwisko);
            }

            //Array.Resize(ref pracownicy, 10); //zmienia wielkość tablicy
            //pracownicy[9] = new Pracownik { Imie = "Jurek", Nazwisko = "Żurek" };//wrzucamy pracownika na dziesiątą pozycję w tablicy


        }
    }
}
