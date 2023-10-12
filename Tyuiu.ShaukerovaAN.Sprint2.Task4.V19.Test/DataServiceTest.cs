using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShaukerovaAN.Sprint2.Task4.V19.Lib;

namespace Tyuiu.ShaukerovaAN.Sprint2.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 15;
            double res = ds.Calculate(x, y);
            double wait = 47491.608 ;
            Assert.AreEqual(wait, res);
        }
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 61481537.562;
            Assert.AreEqual(wait, res);
        }
    }
}
