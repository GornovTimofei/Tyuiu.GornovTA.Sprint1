using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GornovTA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.GornovTA.Sprint1.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string word = "Слова с удвоенной н";
            string result = ds.CheckDoubleN(word);
            string wait = "удвоенной";
            Assert.AreEqual(result, wait);
        }
    }
}
