using System.Collections.Generic;

namespace _4_MetodyDelegatyGeneryczne
{
    public interface IKolejka<T> : IEnumerable<T> // ienumerable pozwala na traktowanie kolekcji jak ciągi wartości
    {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Czytaj();
        void Zapisz(T wartosc);

        //IEnumerable<Twyjscie> ElementJako<Twyjscie>(); //tworzymy metodę generyczną

        

    }
}