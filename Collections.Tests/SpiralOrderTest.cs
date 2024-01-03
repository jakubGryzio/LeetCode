using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    public class SpiralOrderTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Spiral_Order_3x3()
        {
            int[][] nums = { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[3] { 7, 8, 9 } };
            int[] numsArr = { 1, 2, 3, 6, 9, 8, 7, 4, 5 };
            var output = MyArray.SpiralOrder(nums);

            Assert.That(numsArr, Is.EqualTo(output));
        }

        [Test]
        public void Spiral_Order_3x4()
        {
            int[][] nums = { new int[4] { 1, 2, 3, 4 }, new int[4] { 5, 6, 7, 8 }, new int[4] { 9, 10, 11, 12 } };
            int[] numsArr = { 1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7 };
            var output = MyArray.SpiralOrder(nums);

            Assert.That(numsArr, Is.EqualTo(output));
        }

        [Test]
        public void Spiral_Order_1x4()
        {
            int[][] nums = { new int[4] { 1, 2, 3, 4 } };
            int[] numsArr = { 1, 2, 3, 4 };
            var output = MyArray.SpiralOrder(nums);

            Assert.That(numsArr, Is.EqualTo(output));
        }

        [Test]
        public void Spiral_Order_3x1()
        {
            int[][] nums = { new int[1] { 1 }, new int[1] { 2 }, new int[1] { 3 } };
            int[] numsArr = { 1, 2, 3 };
            var output = MyArray.SpiralOrder(nums);

            Assert.That(numsArr, Is.EqualTo(output));
        }

        [Test]
        public void Spiral_Order_1x1()
        {
            int[][] nums = { new int[1] { 1 } };
            int[] numsArr = { 1 };
            var output = MyArray.SpiralOrder(nums);

            Assert.That(numsArr, Is.EqualTo(output));
        }

        [Test]
        public void Spiral_Order_2x2()
        {
            int[][] nums = { new int[2] { 1, 2 }, new int[2] { 3, 4 } };
            int[] numsArr = { 1, 2, 4, 3 };
            var output = MyArray.SpiralOrder(nums);

            Assert.That(numsArr, Is.EqualTo(output));
        }

        [Test]
        public void Spiral_Order_4x4()
        {
            int[][] nums = { new int[4] { 1, 2, 3, 4 }, new int[4] { 5, 6, 7, 8 }, new int[4] { 9, 10, 11, 12 }, new int[4] { 13, 14, 15, 16 } };
            int[] numsArr = { 1,2,3,4,8,12,16,15,14,13,9,5,6,7,11,10 };
            var output = MyArray.SpiralOrder(nums);

            Assert.That(numsArr, Is.EqualTo(output));
        }
    }
}
