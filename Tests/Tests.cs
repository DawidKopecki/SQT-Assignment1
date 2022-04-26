using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SQT_Assignment;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(17,"rural", ExpectedResult = 0)]
        [TestCase(18,"rural", ExpectedResult = 5)]
        [TestCase(19,"rural", ExpectedResult = 5)]
        [TestCase(29,"rural", ExpectedResult = 5)]
        [TestCase(30,"rural", ExpectedResult = 5)]
        [TestCase(31,"rural", ExpectedResult = 2.5)]
        [TestCase(51,"rural", ExpectedResult = 0.375)]
        [TestCase(17,"urban", ExpectedResult = 0)]
        [TestCase(18,"urban", ExpectedResult = 6)]
        [TestCase(19,"urban", ExpectedResult = 6)]
        [TestCase(34,"urban", ExpectedResult = 5)]
        [TestCase(35,"urban", ExpectedResult = 6)]
        [TestCase(36,"urban", ExpectedResult = 5)]
        [TestCase(51,"urban", ExpectedResult = 0.75)]
        public float BoundaryTests(int a, string b)
        {
            InsuranceService insuranceService = new InsuranceService();
            float result = insuranceService.CalcPremium(a, b);
            return result;
        }
    }
}
