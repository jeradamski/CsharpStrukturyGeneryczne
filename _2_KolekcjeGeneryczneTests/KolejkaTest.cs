using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class KolejkaTest
    {
        [TestMethod]
        public void UzyciePeek()
        {

            //test same testy można wykonać dla Stosu

            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(7);
            kolejka.Enqueue(10);
            kolejka.Enqueue(12);

            Assert.AreEqual(1, kolejka.Peek()); //wybiera pierwszą osobę z kolejki

        }

        [TestMethod]
        public void UzycieContains()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(7);
            kolejka.Enqueue(10);
            kolejka.Enqueue(12);

            Assert.IsTrue(kolejka.Contains(12)); //sprawdza czy kolejka zawiera

        }

        [TestMethod]
        public void UzycieToArray()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(7);
            kolejka.Enqueue(10);
            kolejka.Enqueue(12);

            var tablica = kolejka.ToArray(); //kolejka zrzucona do tablicy
            kolejka.Dequeue();

            Assert.AreEqual(1, tablica[0]);
            Assert.AreEqual(4, kolejka.Count);           

        }


        [TestMethod]
        public void UzycieClear()
        {
            var kolejka = new Queue<int>();

            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(7);
            kolejka.Enqueue(10);
            kolejka.Enqueue(12);

            kolejka.Clear(); // usuwa wszystkie elementy z kolejki

            Assert.AreEqual(0, kolejka.Count);
            

        }

    }
}
