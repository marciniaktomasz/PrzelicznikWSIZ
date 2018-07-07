using Microsoft.VisualStudio.TestTools.UnitTesting;
using Przelicznik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznik.Tests
{
    [TestClass()]
    public class AplicationTests
    {

        [TestMethod()]
        public jednostki klasaPoNazwieTest()
        {
            Aplication p = new Aplication();
            jednostki cal = new jednostki("odległości", "cal", "centymetr", 2.54);
            jednostki cal_test = p.klasaPoNazwie("cal");
            if (cal == cal_test)
            {
                return cal;
            }
            else {
                Assert.Fail();
            }
            //Assert.AreEqual(cal, cal_test);
            return cal;
            //
        }

        [TestMethod()]
        public void przeliczMetryNaCentymetry()
        {
            Aplication p = new Aplication();
            double final = 100;
            double test = p.przelicz("metr", "centymetr", 1);
            Assert.AreEqual(final, test);
            //Assert.Fail();
        }

        [TestMethod()]
        public void przeliczCentymetryNaMetry()
        {
            Aplication p = new Aplication();
            double final = 1;
            double test = p.przelicz("centymetr", "metr", 100);
            Assert.AreEqual(final, test);
            //Assert.Fail();
        }

        [TestMethod()]
        public void przeliczCalNaCentymetr()
        {
            Aplication p = new Aplication();
            double final = 2.54;
            double test = p.przelicz("cal", "centymetr", 1);
            Assert.AreEqual(final, test);
            //Assert.Fail();
        }

        [TestMethod()]
        public void przeliczArNaM2()
        {
            Aplication p = new Aplication();
            double final = 100;
            double test = p.przelicz("ar", "m2", 1);
            Assert.AreEqual(final, test);
            //Assert.Fail();
        }
    }
}