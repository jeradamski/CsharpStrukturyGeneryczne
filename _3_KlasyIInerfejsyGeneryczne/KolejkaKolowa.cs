namespace _3_KlasyIInerfejsyGeneryczne
{


    public class KolejkaKolowa<T> : IKolejka<T> //wyodrębnienie interfejsu - prawym na nazwię klasy i wyodrębnij interfejs
    {
        private T[] bufor; //typ generyczny. Może być dowolny. Dzięki temu nie musimy tworzyć wielu osobnych klas odpowiedzialnych za inny typ danych.
        private int poczatekBufora;
        private int koniecBufora;

        //konstruktor domyślny. ctor
        public KolejkaKolowa() : this(pojemnosc: 5) //to znaczy, że jeżeli nie zostanie wskazana pojemność to przyjmie 5
        {

        }

        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new T[pojemnosc + 1];
            poczatekBufora = 0;
            koniecBufora = 0;

        }

        public void Zapisz(T wartosc)
        {
            bufor[koniecBufora] = wartosc;
            koniecBufora = (koniecBufora + 1) % bufor.Length;

            if (koniecBufora == poczatekBufora)
                poczatekBufora = (poczatekBufora + 1) % bufor.Length;
        }

        public T Czytaj()
        {
            var wynik = bufor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            return wynik;
        }

        public int Pojemnosc
        {
            get
            {
                return bufor.Length;
            }
        }

        public bool JestPusty
        {
            get
            {
                return koniecBufora == poczatekBufora;
            }
        }

        public bool JestPelny
        {
            get
            {
                return (koniecBufora + 1) % bufor.Length == poczatekBufora;
            }
        }
    }
}
