using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ZaripovEO.Sprint3.Task0.V1.Lib
{
    public class DataSevice : ISprint3Task0V1
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                sumSeries = sumSeries + ((value * value * i) + 1);
            }
            return sumSeries;
        }
    }
}
