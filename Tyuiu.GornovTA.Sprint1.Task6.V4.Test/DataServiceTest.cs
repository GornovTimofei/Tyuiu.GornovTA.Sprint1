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
            string word = "оловянный";
            bool result = DataService.CheckDoubleN(word);
            Assert.IsTrue(result);
        }
    }
}
