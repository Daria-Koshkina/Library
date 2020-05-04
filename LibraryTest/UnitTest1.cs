using System;
using LibraryFramework.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LibraryTest
{
    [TestClass]
    public class LibraryTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Library library = new Library();
            library.FillDataTest(100);
            Assert.AreEqual("Book1", library.Books[0].Name);
        }
    }
}
