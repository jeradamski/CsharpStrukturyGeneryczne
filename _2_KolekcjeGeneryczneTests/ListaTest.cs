using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class ListaTest
    {
        [TestMethod]
        public void ListaMozemyDodawacNaKoniec()
        {
            List<int> listaLiczb = new List<int> { 1, 2, 3 };

            listaLiczb.Add(4);

            Assert.AreEqual(4, listaLiczb[3]);

        }
    }
}
