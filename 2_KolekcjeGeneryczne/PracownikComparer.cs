using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    public class PracownikComparer : IEqualityComparer<Pracownik>, IComparer<Pracownik> //pierwszy interfejs pobraliśmy dla hashset a drugi dla sortedset. Jeden korzysta z equals, a drugi z compare
    {
        public int Compare(Pracownik x, Pracownik y)
        {
            return String.Compare(x.Nazwisko, y.Nazwisko);
        }

        public bool Equals(Pracownik x, Pracownik y)
        {
            return String.Equals(x.Nazwisko, y.Nazwisko);
        }

        public int GetHashCode(Pracownik obj)
        {
            return obj.Nazwisko.GetHashCode();
        }
    }
}
