using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class MoveZeroesTests
    {
        [Test]
        public void Move_Zeroes_Two_Zeroes()
        {
            var expected = new int[] { 1, 3, 12, 0, 0 };
            var tested = new int[] { 0, 1, 0, 3, 12 };
            MyArray.MoveZeroes(tested);
            Assert.That(expected, Is.EqualTo(tested));
        }

        [Test]
        public void Move_Zeroes_One_Zeroes()
        {
            var expected = new int[] { 0 };
            var tested = new int[] { 0 };
            MyArray.MoveZeroes(tested);
            Assert.That(expected, Is.EqualTo(tested));
        }

        [Test]
        public void Move_Zeroes_None_Zeroes()
        {
            var expected = new int[] { 2, 1 };
            var tested = new int[] { 2, 1 };
            MyArray.MoveZeroes(tested);
            Assert.That(expected, Is.EqualTo(tested));
        }
    }
}
