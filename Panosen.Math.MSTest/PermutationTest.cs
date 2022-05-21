using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Panosen.Math.MSTest
{
    [TestClass]
    public class PermutationTest
    {

        [TestMethod]
        public void TestPermutate()
        {
            var value = Permutation.Permutate(5, 2);

            Assert.AreEqual(20, value);
        }

        [TestMethod]
        public void TestMethod()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4 };

            var actual = Permutation.Permutate(numbers);
            Assert.IsNotNull(actual);
            Assert.AreEqual(24, actual.Count);

            var items = actual.Select(v => string.Join("", v));

            Assert.IsTrue(items.Contains("1234"));
            Assert.IsTrue(items.Contains("1243"));
            Assert.IsTrue(items.Contains("1324"));
            Assert.IsTrue(items.Contains("1342"));
            Assert.IsTrue(items.Contains("1432"));
            Assert.IsTrue(items.Contains("1423"));
            Assert.IsTrue(items.Contains("2134"));
            Assert.IsTrue(items.Contains("2143"));
            Assert.IsTrue(items.Contains("2314"));
            Assert.IsTrue(items.Contains("2341"));
            Assert.IsTrue(items.Contains("2431"));
            Assert.IsTrue(items.Contains("2413"));
            Assert.IsTrue(items.Contains("3214"));
            Assert.IsTrue(items.Contains("3241"));
            Assert.IsTrue(items.Contains("3124"));
            Assert.IsTrue(items.Contains("3142"));
            Assert.IsTrue(items.Contains("3412"));
            Assert.IsTrue(items.Contains("3421"));
            Assert.IsTrue(items.Contains("4231"));
            Assert.IsTrue(items.Contains("4213"));
            Assert.IsTrue(items.Contains("4321"));
            Assert.IsTrue(items.Contains("4312"));
            Assert.IsTrue(items.Contains("4132"));
            Assert.IsTrue(items.Contains("4123"));
        }
    }
}
