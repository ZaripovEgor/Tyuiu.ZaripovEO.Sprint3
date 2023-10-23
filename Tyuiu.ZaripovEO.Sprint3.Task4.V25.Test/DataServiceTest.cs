using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint3.Task4.V25.Lib;

namespace Tyuiu.ZaripovEO.Sprint3.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValiCalc()
        {
            DataService ds = new DataService();

            int startVal = -5;
            int stopVal = 5;

            double res = ds.Calculate(startVal, stopVal);

            double wait = 44.313;
            Assert.AreEqual(wait, res);
        }
    }
}
