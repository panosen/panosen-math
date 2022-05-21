using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.Math.MSTest
{
    [TestClass]
    public partial class CombinationTest
    {

        [TestMethod]
        public void TestCombinate()
        {
            var value = Combination.Combinate(5, 2);

            Assert.AreEqual(10, value);
        }

        [TestMethod]
        public void TestMethod()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };

            var actual = Combination.Combinate(numbers, 2);
            Assert.IsNotNull(actual);
            Assert.AreEqual(6, actual.Count);

            var items = actual.Select(v => string.Join("", v.OrderBy(x => x)));

            Assert.IsTrue(items.Contains("12"));
            Assert.IsTrue(items.Contains("13"));
            Assert.IsTrue(items.Contains("14"));
            Assert.IsTrue(items.Contains("23"));
            Assert.IsTrue(items.Contains("24"));
            Assert.IsTrue(items.Contains("34"));
        }
    }
}
