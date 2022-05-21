using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panosen.Math.MSTest
{
    [TestClass]
    public class BinaryTest
    {
        [TestMethod]
        public void Test1()
        {
            var @base = 2;

            var nums = Binary.ToBase(0, @base);

            var actual = Binary.FromBase(nums, @base);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test2()
        {
            var @base = 2;

            var nums = new List<int> { 0, 0, 0 };

            var actual = Binary.FromBase(nums, @base);

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void Test3()
        {
            var ramdom = new Random();

            var @base = ramdom.Next(7, 23);

            var value = ramdom.Next(100000, 10000000);

            var nums = Binary.ToBase(value, @base);

            var actual = Binary.FromBase(nums, @base);

            Assert.AreEqual(value, actual);
        }
    }
}
