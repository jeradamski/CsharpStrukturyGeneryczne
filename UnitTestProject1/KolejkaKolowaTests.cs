using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using _3_KlasyIInterfejsy_Generyczne;

namespace _3_KlasyIInterfejsy_GeneryczneTests
{
    [TestClass]
    public class KolejkaKolowaTests
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa<double>();

            Assert.IsTrue(kolejka.JestPusty);        
        }

        [TestMethod]
        public void KolejkaTrzyElementowaJestPelnaPoTrzechZapisach()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            kolejka.Zapisz(3.8);
            kolejka.Zapisz(6);
            kolejka.Zapisz(3);

            Assert.IsTrue(kolejka.JestPelny);         
        }

        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            var kolejka = new KolejkaKolowa<string>(pojemnosc: 3);
            var wartosc1 = "43.4";
            var wartosc2 = "4.3";

            kolejka.Zapisz(wartosc1); 
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, kolejka.Czytaj());
            Assert.AreEqual(wartosc2, kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void NadpisujGdyJestWiekszaNizPojemnosc()
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            var wartosci = new[] {1.2, 1.4, 2.5, 5,6, 6.9 };

            foreach (var wartosc in wartosci)
            {
                kolejka.Zapisz(wartosc);
            }

            Assert.IsTrue(kolejka.JestPelny);
            Assert.AreEqual(wartosci[3], kolejka.Czytaj());
            Assert.AreEqual(wartosci[4], kolejka.Czytaj());
            Assert.AreEqual(wartosci[5], kolejka.Czytaj());
            Assert.IsTrue(kolejka.JestPusty);
        }


    }
}
