using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class FindMaxConsecutiveOnesTests
    {
        [Test]
        public void Find_Max_Consecutive_Ones_Should_Be_3()
        {
            var expected = 3;
            var output = MyArray.FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Find_Max_Consecutive_Ones_Should_Be_2()
        {
            var expected = 2;
            var output = MyArray.FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Find_Max_Consecutive_Ones_Should_Be_1()
        {
            var expected = 1;
            var output = MyArray.FindMaxConsecutiveOnes(new int[] { 1 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Find_Max_Consecutive_Ones_Should_Be_0()
        {
            var expected = 0;
            var output = MyArray.FindMaxConsecutiveOnes(new int[] { 0, 0, 0, 0 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Find_Max_Consecutive_Ones_Should_Be_ArrayLength()
        {
            var expected = 4;
            var output = MyArray.FindMaxConsecutiveOnes(new int[] { 1, 1, 1, 1 });
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
