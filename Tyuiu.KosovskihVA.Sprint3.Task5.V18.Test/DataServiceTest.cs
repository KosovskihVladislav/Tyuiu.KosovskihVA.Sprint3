using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint3.Task5.V18.Lib;

namespace Tyuiu.KosovskihVA.Sprint3.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(759.361, service1.GetSumSumSeries(5, 1, 1, 3, 11));
        }
    }
}
