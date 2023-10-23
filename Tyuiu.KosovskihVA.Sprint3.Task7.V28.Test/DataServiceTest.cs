using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KosovskihVA.Sprint3.Task7.V28.Lib;

namespace Tyuiu.KosovskihVA.Sprint3.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] v;
            v = new double[len];

            v[0] = -11.22;
            v[1] = -8.65;
            v[2] = -4.76;
            v[3] = -6.47;
            v[4] = -2.98;
            v[5] = 1.00;
            v[6] = 1.82;
            v[7] = 3.55;
            v[8] = 6.99;
            v[9] = 7.74;
            v[10] = 9.03;

            double[] res;
            res = new double[len];
            res = service1.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(v, res);
        }
    }
}
