using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Kolejka
    {
        static void Main(string[] args)
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Jurek", Nazwisko = "Jurek" }); //zakolejkowanie. Zawsze nowy obiekt jest dodawany na koniec kolejki
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jacek", Nazwisko = "Kowal" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Kowalski" });
            
            while (kolejka.Count > 0)
            {
                 var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }


        }
    }
}
