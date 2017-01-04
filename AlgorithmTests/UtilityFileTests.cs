using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmTests
{
    [TestClass]
    public class UtilityFileTests
    {
        [TestMethod]
        public void TestFindFile()
        {
            // Valid case
            string path = @"simulation data\networkA.csv";
            string foundFilepath;
            bool exists =  Utility.FileHelper.FindFile(path, out foundFilepath);
            Assert.IsTrue(exists);

            // Invalid case
            path = "simulation data\nonsense.csv";
            exists = Utility.FileHelper.FindFile(path, out foundFilepath);
            Assert.IsFalse(exists);
        }
    }
}
