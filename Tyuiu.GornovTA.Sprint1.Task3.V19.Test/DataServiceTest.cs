using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.GornovTA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.GornovTA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SlonTrue()
        {
            DataService ds = new DataService();
            int x1 = 0;
            int y1 = 0;
            int x2 = 1;
            int y2 = 1;
            bool result = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void SlonFalse()
        {
            DataService ds = new DataService();
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 1;
            bool result = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.IsFalse(result);
        }
    }
}
