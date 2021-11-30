using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolejka();
            //Stos();
            //HashSet();
            //LinkedList();
            //Slownik();
            //SortedDictionary();
            //SortedList();
            //SortedSet();

        }

        private static void SortedSet()
        {
            var set = new SortedSet<int>();
            set.Add(4);
            set.Add(5);
            set.Add(3);
            set.Add(2);
            set.Add(1);
            set.Add(10);

            foreach (var item in set)
            {
                Console.WriteLine("Wartość wynosi {0}", item);
            }

            var set2 = new SortedSet<string>();
            set2.Add("basia");
            set2.Add("kasia");
            set2.Add("wiesia");
            set2.Add("czesia");
            set2.Add("zosia");
            set2.Add("gosia");

            foreach (var item in set2)
            {
                Console.WriteLine("Wartość wynosi {0}", item);
            }
        }

        private static void SortedList() 
        {
            var listaPosortowana = new SortedList<int, string>(); //bliźniacza kolekcja do SortedDictionary.
                                                                  //Nadaje się lepiej jeżeli szukasz po kluczu. Jeżeli po wartościach to lepiej skorzystać z SortedDictionary

            listaPosortowana.Add(3, "trzy");
            listaPosortowana.Add(1, "jeden");
            listaPosortowana.Add(2, "dwa");
            listaPosortowana.Add(5, "pięć");

            foreach (var item in listaPosortowana)
            {
                Console.WriteLine("Wartość dla klucza {0} wynosi {1}", item.Key, item.Value);
            }
        }

        private static void SortedDictionary()
        {
            var pracownicy = new SortedDictionary<string, List<Pracownik>>(); //słownik uporządkowany. Zachodzanie tej kolekcji jest takie samo ale sortuje po kluczu

            pracownicy.Add("Sprzedaż", new List<Pracownik>() { new Pracownik { Imie = "Jan", Nazwisko = "Nowak" },
                                                               new Pracownik { Imie = "Mariusz", Nazwisko = "Kowal" },
                                                               new Pracownik { Imie = "Wojciech", Nazwisko = "Kowalczyk" } });

            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik { Imie = "Kasia", Nazwisko = "Agat" },
                                                                  new Pracownik { Imie = "Marysia", Nazwisko = "Opal" } });

            pracownicy.Add("Księgowość", new List<Pracownik>() { new Pracownik { Imie = "Wiesia", Nazwisko = "Lupa" },
                                                                 new Pracownik { Imie = "Jaś", Nazwisko = "Okno" },
                                                                 new Pracownik { Imie = "Rysio", Nazwisko = "Oknowski" },
                                                                 new Pracownik { Imie = "Małgosia", Nazwisko = "Stanowska" } });

            foreach (var item in pracownicy)
            {
                Console.WriteLine("Ilość pracowników w dziale {0} wynosi {1}", item.Key, item.Value.Count);
            }
        }

        private static void Slownik()
        {
            var pracownicy = new Dictionary<string, Pracownik>(); //słownik umożliwia utworzenie klucza dla danego elementu. Ważne! Wartość klucza musi być unikalna
            pracownicy.Add("Nowak", new Pracownik { Nazwisko = "Nowak" });
            pracownicy.Add("Kowal", new Pracownik { Nazwisko = "Kowal" });
            pracownicy.Add("Kaczor", new Pracownik { Nazwisko = "Kaczor" });

            var kowal = pracownicy["Kowal"]; //indeksuje po kluczu ze słownika

            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine("{0}:{1}", pracownik.Key, pracownik.Value.Nazwisko);
            }

            var pracownicySecond = new Dictionary<string, List<Pracownik>>(); // w tym przykładzie tworzymy słownik, w którym wartością jest lista
            pracownicySecond.Add("Ksiegowosc", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowak" }, 
                                                                       new Pracownik { Nazwisko = "Kowal" }, 
                                                                       new Pracownik { Nazwisko = "Kowalczyk" } });


            pracownicySecond["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });//Tutaj można dodać kolejny element, ponieważ tworzymy nowy obiekt listy

            pracownicySecond.Add("Informatyka", new List<Pracownik>() { new Pracownik { Nazwisko = "Kowalski" },
                                                                        new Pracownik { Nazwisko = "Murański" },
                                                                        new Pracownik { Nazwisko = "Wolański" } });

            foreach (var item in pracownicySecond)
            {
                Console.WriteLine("Dział: " + item.Key);
                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pracownicy z księgowości: ");
            foreach (var item in pracownicySecond["Ksiegowosc"])
            {
                Console.WriteLine(item.Nazwisko);
            }
        }

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>(); //pozwala dzielić listę na węzły (nodes) i dowolnie zarządzać elementami
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            var elementPierwszy = lista.First; //tworzy tzw. węzeł (LinkedListNode). To nie jest wartość z listy!
            var elementOstatni = lista.Last;

            lista.AddAfter(elementPierwszy, 10); //dodajemy po konkretnym elemencie
            lista.AddBefore(elementPierwszy, 20); //dodajemy przed elementem

            var wezel = lista.First;

            while (wezel != null) //inny sposób przechodzenia przez listę
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void HashSet()
        {
            HashSet<int> set = new HashSet<int>(); //ma za zadanie dodawanie unikalnych danych do zestawu. Nie możemy wrzucić dwóch tych samych elementów. Dane do zestawu dodawane są
                                                   //w sposób nieuporządkowany
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);
            set.Add(5);
            set.Add(6);
            set.Add(7);
            set.Add(8);
            set.Add(9);
            set.Add(10);
            set.Add(10); //program się nie wywala, po prostu go nie dodaje


            foreach (var item in set)
            {
                Console.WriteLine(item);
            }

            HashSet<Pracownik> setPracownik = new HashSet<Pracownik>(); //ma za zadanie dodawanie unikalnych danych do zestawu. Nie możemy wrzucić dwóch tych samych elementów. Dane do zestawu dodawane są
                                                                        //w sposób nieuporządkowany

            setPracownik.Add(new Pracownik { Imie = "Jurek", Nazwisko = "Żurek" });
            setPracownik.Add(new Pracownik { Imie = "Ala", Nazwisko = "Fala" });
            setPracownik.Add(new Pracownik { Imie = "Darek", Nazwisko = "Ogarek" });
            setPracownik.Add(new Pracownik { Imie = "Jurek", Nazwisko = "Żurek" }); //dodaje do zestawu, ponieważ dla HashSet to są dwa różne obiekty (new Pracownik)

            var pracownik = new Pracownik { Imie = "Marek" };

            setPracownik.Add(pracownik);
            setPracownik.Add(pracownik); //tu już nie dodaje, ponieważ porównuje zwykłe zmienne, a nie obiekty

            Console.WriteLine();

            foreach (var item in setPracownik)
            {
                Console.WriteLine(item.Imie + " " + item.Nazwisko);
            }
        }

        private static void Kolejka()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Jurek", Nazwisko = "Jurek" }); //zakolejkowanie. Zawsze nowy obiekt jest dodawany na koniec kolejki
            kolejka.Enqueue(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });
            kolejka.Enqueue(new Pracownik { Imie = "Jacek", Nazwisko = "Kowal" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomek", Nazwisko = "Kowalski" });

            Console.WriteLine("Kolejka");
            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }

        private static void Stos()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>(); //stos polega na pobieraniu zawsze ostatnio dodanego elementu
            stos.Push(new Pracownik { Imie = "Jurek", Nazwisko = "Jurek" }); //dodanie elementu do stosu
            stos.Push(new Pracownik { Imie = "Ola", Nazwisko = "Nowak" });
            stos.Push(new Pracownik { Imie = "Jacek", Nazwisko = "Kowal" });
            stos.Push(new Pracownik { Imie = "Tomek", Nazwisko = "Kowalski" });

            Console.WriteLine();
            Console.WriteLine("Stos");
            while (stos.Count > 0)
            {
                var pracownik = stos.Pop(); //pobranie elementu ze stosu
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}
