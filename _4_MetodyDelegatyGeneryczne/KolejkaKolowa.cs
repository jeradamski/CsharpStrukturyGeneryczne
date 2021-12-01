using System;

namespace _4_MetodyDelegatyGeneryczne
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
                var usuniety = kolejka.Dequeue();
                PoUsunieciuElementu(usuniety, wartosc);

            }
        }

        private void PoUsunieciuElementu(T usuniety, T wartosc)
        {
            if (elementusuniety != null)
            {
                var args = new ElementUsunietyEventArgs<T>(usuniety, wartosc);
                elementusuniety(this, args);
            }
        }

        public override bool JestPelny //nadpisujemy właściwość
        {
            get
            {
                return kolejka.Count == _pojemnosc;
            }
        }

        public event EventHandler<ElementUsunietyEventArgs<T>> elementusuniety; //zdarzenie generyczne                                    

    }

    public class ElementUsunietyEventArgs<T> : EventArgs
    {
        public T ElementUsuniety { get; set; }
        public T ElementNowy { get; set; }

        public ElementUsunietyEventArgs(T elementUsuniety, T elementNowy) // konstruktor
        {
            ElementUsuniety = elementUsuniety;
            ElementNowy = elementNowy;
        }
    }
}
