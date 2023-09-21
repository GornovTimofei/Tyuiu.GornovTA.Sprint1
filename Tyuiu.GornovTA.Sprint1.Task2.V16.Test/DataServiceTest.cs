using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GornovTA.Sprint1.Task2.V16.Lib;

namespace Tyuiu.GornovTA.Sprint1.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculatePerimetrCircle(x);
            Assert.AreEqual(12.56, res);
        }
    }
}
