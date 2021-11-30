using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczneTests
{
    [TestClass]
    public class HashSetTest
    {
        [TestMethod]
        public void IntersectSet()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.IntersectWith(set2); //zwraca elementy wspólne z dwóch zestawów

            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 })); //porównanie wartości
        }

        [TestMethod]
        public void Union()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.UnionWith(set2); //łączy oba sety

            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }

        [TestMethod]
        public void SymmetricExceptWith()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2); //zwraca elementy unikalne dla porównywanych zestawów

            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));
        }

        [TestMethod]
        public void Remove()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.Remove(1); //usuwamy wybrany element z zestawu

            Assert.AreEqual(2, set1.Count);
        }

        [TestMethod]
        public void RemoveWhere()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.RemoveWhere(x => x > 1); //usuwamy elementy, które spełniają warunek

            Assert.AreEqual(1, set1.Count);
        }

        [TestMethod]
        public void Contains()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            Assert.IsTrue(set1.Contains(3)); //sprawdzamy, czy zestaw zawiera dany element
        }

    }
}
