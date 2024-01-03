using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class PairSumTests
    {
        [Test]
        public void Pair_Sum_1234()
        {
            var input = new int[] { 1, 4, 2, 3 };
            var expected = 4;
            var output = MyArray.ArrayPairSum(input);
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
