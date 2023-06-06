using DPTechnicalTest.Drivers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DPTechnicalTest.Tests
{
    /// <summary>
    /// This is the base class for all non-Specflow tests.
    /// </summary>
    public class TestBase
    {
        protected Driver Driver { get; } = new();
        
        [TestCleanup]
        public void TestCleanup()
        {
            Driver.Close();
        }
    }
}
