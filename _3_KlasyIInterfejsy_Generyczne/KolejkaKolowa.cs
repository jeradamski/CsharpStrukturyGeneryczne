namespace _3_KlasyIInterfejsy_Generyczne
{
    public class KolejkaKolowa<T> : DuzaKolejka<T>
    {
        private int _pojemnosc;

        public KolejkaKolowa(int pojemnosc = 5)
        {
            _pojemnosc = pojemnosc;
        }

        public override void Zapisz(T wartosc) //nadpisujemy metodę bazową. Pozwala nam na to virtual
        {
            base.Zapisz(wartosc);

            if (kolejka.Count > _pojemnosc)
            {
                kolejka.Dequeue();
            }
        }

        public override bool JestPelny //nadpisujemy właściwość
        {
            get
            {
                return kolejka.Count == _pojemnosc;
            }
        } 
                                      

    }
}
