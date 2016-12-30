using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class UtilityFileTests
    {
        [TestMethod]
        public void TestFileExists()
        {
            string path = @"c:\temp\";

            bool exists =  Utility.FileHelper.Exists(path);
            Assert.IsTrue(exists);

        }
    }
}
