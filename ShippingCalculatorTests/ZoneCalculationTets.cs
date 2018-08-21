using System;
using CalculateShippingCosts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// Declaring delegate
delegate double zoneCalculator(double price);

namespace ShippingCalculatorTests
{
    [TestClass]
    public class ZoneCalculationTets
    {
        [TestMethod]
        public void Zone1()
        {
            zoneCalculator zoneCalc1 = ShippingCalculatorDelegate.Zone1;
            double zone1 = 100;
            double Zone1 = zoneCalc1(zone1);
            Assert.AreEqual(125, Zone1);
        }
        [TestMethod]
        public void Zone2()
        {
            zoneCalculator zoneCalc2 = ShippingCalculatorDelegate.Zone2;
            double zone2 = 100;
            double Zone2 = zoneCalc2(zone2);
            Assert.AreEqual(137, Zone2);
        }

        [TestMethod]
        public void Zone3()
        {
            zoneCalculator zoneCalc3 = ShippingCalculatorDelegate.Zone3;
            double zone3 = 100;
            double Zone3 = zoneCalc3(zone3);
            Assert.AreEqual(108, Zone3);
        }

        [TestMethod]
        public void Zone4()
        {
            zoneCalculator zoneCalc4 = ShippingCalculatorDelegate.Zone4;
            double zone4 = 100;
            double Zone4 = zoneCalc4(zone4);
            Assert.AreEqual(129, Zone4);
        }
    }
}
