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
            int x1 = 2;
            int y1 = 3;
            int x2 = 4;
            int y2 = 5;
            bool result = DataService.ElephCanMove(x1, y1, x2, y2);
            Assert.IsTrue(result);
        }
        public void SlonFalse()
        {
            int x1 = 1;
            int y1 = 1;
            int x2 = 5;
            int y2 = 5;
            bool result = DataService.ElephCanMove(x1, y1, x2, y2);
            Assert.IsFalse(result);
        }
    }
}
