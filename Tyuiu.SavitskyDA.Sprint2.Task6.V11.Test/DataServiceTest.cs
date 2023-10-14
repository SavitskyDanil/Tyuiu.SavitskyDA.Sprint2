using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SavitskyDA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.SavitskyDA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 10;
            int n = 14;
            string wait = "15 10 2023";
            var res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);

        }
    }
}
