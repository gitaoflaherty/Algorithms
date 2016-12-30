using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JosephusProblem;

namespace AlgorithmTests
{
    [TestClass]
    public class JosephusProblemTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Create circular chain of 10 people
            int countAlive = 6;
            Person firstPerson = new Person( 1 );
            Person lastPerson = firstPerson.CreateChain( countAlive - 1 );
            lastPerson.NextPerson = firstPerson;

            int k = 3;

            Person lastManStanding = firstPerson.Kill(k, 1, countAlive);

            Console.WriteLine( lastManStanding.ToString() );
        }
    }
}
