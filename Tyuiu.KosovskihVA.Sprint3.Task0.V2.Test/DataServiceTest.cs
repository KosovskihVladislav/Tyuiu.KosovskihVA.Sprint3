using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint3.Task0.V2.Lib;

namespace Tyuiu.KosovskihVA.Sprint3.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            Assert.AreEqual(0.021, service1.GetMultiplySeries(1, 9));
        }
    }
}
