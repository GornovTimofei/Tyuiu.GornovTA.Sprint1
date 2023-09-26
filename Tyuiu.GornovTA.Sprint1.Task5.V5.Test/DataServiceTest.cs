using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GornovTA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.GornovTA.Sprint1.Task5.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 32.597;
            int d = 5;
            int dn = ds.Calculate(x);
            Assert.AreEqual(d, dn);
        }
    }
}
