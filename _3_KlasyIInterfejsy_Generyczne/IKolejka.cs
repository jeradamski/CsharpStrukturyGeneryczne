using System.Collections.Generic;

namespace _3_KlasyIInterfejsy_Generyczne
{
    public interface IKolejka<T> : IEnumerable<T> // ienumerable pozwala na traktowanie kolekcji jak ciągi wartości
    {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Czytaj();
        void Zapisz(T wartosc);
    }
}