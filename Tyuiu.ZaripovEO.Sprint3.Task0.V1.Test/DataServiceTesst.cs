﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZaripovEO.Sprint3.Task0.V1.Lib;

namespace Tyuiu.ZaripovEO.Sprint3.Task0.V1.Test
{
    [TestClass]
    public class DataServiceTesst
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            double value = 4;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 1935;

            Assert.AreEqual(wait, res);
        }
    }
}
