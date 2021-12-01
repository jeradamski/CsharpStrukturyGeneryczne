using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    public class DzialyKolekcja : SortedDictionary<string, SortedSet<Pracownik>>, ICollection<>
    {
        public DzialyKolekcja Add(string nazwaDzialu, Pracownik pracownik)
        {
            if (!ContainsKey(nazwaDzialu)) //jeżeli nie wystepuje w dziale
            {
                Add(nazwaDzialu, new SortedSet<Pracownik>(new PracownikComparer()));                
            }
            this[nazwaDzialu].Add(pracownik);
            return this;
        }
    }
}
