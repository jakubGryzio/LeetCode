using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class MinSubArrayLenTests
    {
        [Test]
        public void Min_Sub_Array_Len_Should_Be_2()
        {
            var expected = 2;
            var output = MyArray.MinSubArrayLen(7, new int[] { 2, 3, 1, 2, 4, 3 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Min_Sub_Array_Len_Should_Be_1()
        {
            var expected = 1;
            var output = MyArray.MinSubArrayLen(4, new int[] { 1, 4, 4 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Min_Sub_Array_Len_Should_Be_0()
        {
            var expected = 0;
            var output = MyArray.MinSubArrayLen(11, new int[] { 1, 1, 1, 1, 1 ,1, 1, 1 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Min_Sub_Array_Len_Should_Be_1_OneElem()
        {
            var expected = 1;
            var output = MyArray.MinSubArrayLen(5, new int[] { 5 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Min_Sub_Array_Len_Should_Be_3()
        {
            var expected = 3;
            var output = MyArray.MinSubArrayLen(6, new int[] { 0, 0, 2, 2, 2, 0 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Min_Sub_Array_Len_Should_Be_2_FailedTest()
        {
            var expected = 3;
            var output = MyArray.MinSubArrayLen(6, new int[] { 0, 0, 2, 2, 2, 0 });
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
