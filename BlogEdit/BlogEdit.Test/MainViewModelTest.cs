using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlogEdit.Test
{
    [TestClass]
    public class MainViewModelTest : TestBase
    {
        [TestMethod, TestCategory("MainViewModel")]
        public void Constructor_Pass_Test()
        {
        }

        [TestMethod, TestCategory("MainViewModel")]
        public void Constructor_Fail_Test()
        {
            Assert.Fail();
        }
    }
}
