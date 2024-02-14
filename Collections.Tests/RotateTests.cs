using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class RotateTests
    {
        [Test]
        public void Rotate_Three_K()
        {
            var tested = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var expected = new int[] { 5, 6, 7, 1, 2, 3, 4 };
            MyArray.Rotate(tested, 3);
            Assert.That(tested, Is.EqualTo(expected));
        }

        [Test]
        public void Rotate_Two_K()
        {
            var tested = new int[] { -1, -100, 3, 99 };
            var expected = new int[] { 3, 99, -1, -100 };
            MyArray.Rotate(tested, 2);
            Assert.That(tested, Is.EqualTo(expected));
        }

        [Test]
        public void Rotate_Zero_K()
        {
            var tested = new int[] { 1 };
            var expected = new int[] { 1 };
            MyArray.Rotate(tested, 0);
            Assert.That(tested, Is.EqualTo(expected));
        }

        [Test]
        public void Rotate_One_K()
        {
            var tested = new int[] { 1 };
            var expected = new int[] { 1 };
            MyArray.Rotate(tested, 10);
            Assert.That(tested, Is.EqualTo(expected));
        }

        [Test]
        public void Rotate_Same_K_As_ArrLength()
        {
            var tested = new int[] { 1, 2 };
            var expected = new int[] { 1, 2 };
            MyArray.Rotate(tested, 2);
            Assert.That(tested, Is.EqualTo(expected));
        }

        [Test]
        public void Rotate_Greater_K_Than_ArrLength()
        {
            var tested = new int[] { 1, 2 };
            var expected = new int[] { 2, 1 };
            MyArray.Rotate(tested, 3);
            Assert.That(tested, Is.EqualTo(expected));
        }

        [Test]
        public void Rotate_Odd_K_Even_ArrLength()
        {
            var tested = new int[] { 1, 2, 3, 4, 5, 6 };
            var expected = new int[] { 4, 5, 6, 1, 2, 3 };
            MyArray.Rotate(tested, 3);
            Assert.That(tested, Is.EqualTo(expected));
        }
    }
}
