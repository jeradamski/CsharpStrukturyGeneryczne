using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace _4_MetodyDelegatyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T> //implementacja interfejsu w klasie
    {
        protected Queue<T> kolejka; //definiujemy zmienną kolejkę na podstawie kolecji queue. Protected oznacza, że ma do niej dostęp jedynie klasa, która po niej dziedziczy

        public DuzaKolejka()
        {
            kolejka = new Queue<T>();
        }

        public virtual bool JestPelny => throw new System.NotImplementedException(); //virtual pozwala na modyfikacje w klasie, która będzie z niej dziedziczyła

        public virtual bool JestPusty
        {
            get
            {
                return kolejka.Count == 0; //właściwość sprawdzająca czy kolejka jest pusta
            }
        }

        public virtual T Czytaj()
        {
            return kolejka.Dequeue();
        }

        public virtual void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }

        public IEnumerator<T> GetEnumerator()
        {
            //return kolejka.GetEnumerator();

            foreach (var item in kolejka)
            {
                //filtrowanie
                yield return item; //
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}