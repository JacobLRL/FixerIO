using System;
using NUnit.Framework;
using Fixer.FixerLatestService;

namespace Fixer.Tests
{
    [TestFixture]
    public class FixerLatestRatesTest
    {
        private FixerLatestService.FixerLatestService fixerLatestRates = new FixerLatestService.FixerLatestService();
        [Test]
        public void WebCallSuccessCheck()
        {
            // DTO data transfer object
            Assert.AreEqual(true, fixerLatestRates.fixerLatestDTO.LatestRates.success);
        }

        // Total Rates Check
        [Test]
        public void TotalRatesCheck() {
            Assert.AreEqual(168, fixerLatestRates.CountOfRates());
        }
        // All Rates are Floats
        [Test]
        public void AllRatesAreFloatsCheck() {
            
            foreach (var elem in fixerLatestRates.fixerLatestDTO.LatestRates.rates) {
                TestContext.Out.WriteLine(elem.Value);
                TestContext.Out.WriteLine(elem.Key);
                Assert.IsInstanceOf(typeof(float), elem.Value);
            }
            
        }
        // Base Check
        [Test]
        public void BaseCheck() {
            //TestContext.Out.WriteLine(fixerLatestRates.fixerLatestDTO.LatestRates);
            TestContext.Out.WriteLine(fixerLatestRates.LatestRatesJson.ToString());
            Assert.AreEqual("EUR", fixerLatestRates.LatestRatesJson["base"].ToString());
        }
        // Date
        [Test]
        public void DateCheck() {
            Assert.AreEqual(DateTime.Now.ToString("yyyy'-'MM'-'dd"), fixerLatestRates.fixerLatestDTO.LatestRates.date);
        }
        // Timestamp Check
    }
}
