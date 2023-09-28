using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GornovTA.Sprint1.Task7.V26.Lib;

namespace Tyuiu.GornovTA.Sprint1.Task7.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 0.944;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
