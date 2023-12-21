using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    public class MyArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Find_Pivot_Index()
        {
            int[] nums = { 1, 7, 3, 6, 5, 6 };
            var pivotIndex = MyArray.PivotIndex(nums);

            Assert.That(pivotIndex, Is.EqualTo(3));
        }

        [Test]
        public void Find_No_Pivot_Index()
        {
            int[] nums = { 1, 2, 3 };
            var pivotIndex = MyArray.PivotIndex(nums);

            Assert.That(pivotIndex, Is.EqualTo(-1));
        }

        [Test]
        public void Find_Zero_Pivot_Index()
        {
            int[] nums = { 2, 1, -1 };
            var pivotIndex = MyArray.PivotIndex(nums);

            Assert.That(pivotIndex, Is.EqualTo(0));
        }

        [Test]
        public void Dominant_Index()
        {
            int[] nums = { 3, 6, 1, 0 };
            var dominantIndex = MyArray.DominantIndex(nums);

            Assert.That(dominantIndex, Is.EqualTo(1));
        }

        [Test]
        public void Non_Dominant_Index()
        {
            int[] nums = { 1, 2, 3, 4 };
            var dominantIndex = MyArray.DominantIndex(nums);

            Assert.That(dominantIndex, Is.EqualTo(-1));
        }

        [Test]
        public void Zero_Dominant_Index()
        {
            int[] nums = { 0, 0, 0, 1 };
            var dominantIndex = MyArray.DominantIndex(nums);

            Assert.That(dominantIndex, Is.EqualTo(3));
        }

        [Test]
        public void Zero_One_Dominant_Index()
        {
            int[] nums = { 1, 0 };
            var dominantIndex = MyArray.DominantIndex(nums);

            Assert.That(dominantIndex, Is.EqualTo(0));
        }

        [Test]
        public void Zero_First_Dominant_Index()
        {
            int[] nums = { 0, 0, 3, 2 };
            var dominantIndex = MyArray.DominantIndex(nums);

            Assert.That(dominantIndex, Is.EqualTo(-1));
        }

        [Test]
        public void Plus_One()
        {
            int[] sourceNums = { 1, 2, 3 };
            int[] nums = { 1, 2, 4 };
            var plusOneArr = MyArray.PlusOne(sourceNums);

            Assert.That(plusOneArr, Is.EquivalentTo(nums));
        }

        [Test]
        public void Plus_One_4Digit()
        {
            int[] sourceNums = { 4,3,2,1 };
            int[] nums = { 4, 3, 2, 2 };
            var plusOneArr = MyArray.PlusOne(sourceNums);

            Assert.That(plusOneArr, Is.EquivalentTo(nums));
        }

        [Test]
        public void Plus_One_9Digit()
        {
            int[] sourceNums = { 9 };
            int[] nums = { 1, 0 };
            var plusOneArr = MyArray.PlusOne(sourceNums);

            Assert.That(plusOneArr, Is.EquivalentTo(nums));
        }

        [Test]
        public void Plus_One_Last_9Digit()
        {
            int[] sourceNums = { 3, 2, 9 };
            int[] nums = { 3,3,0 };
            var plusOneArr = MyArray.PlusOne(sourceNums);

            Assert.That(plusOneArr, Is.EquivalentTo(nums));
        }

        [Test]
        public void Plus_One_Last_99Digit()
        {
            int[] sourceNums = { 3, 9, 9 };
            int[] nums = { 4, 0, 0 };
            var plusOneArr = MyArray.PlusOne(sourceNums);

            Assert.That(plusOneArr, Is.EquivalentTo(nums));
        }

        [Test]
        public void Plus_One_Last_999Digit()
        {
            int[] sourceNums = { 9, 9, 9 };
            int[] nums = { 1, 0, 0, 0 };
            var plusOneArr = MyArray.PlusOne(sourceNums);

            Assert.That(plusOneArr, Is.EquivalentTo(nums));
        }

        [Test]
        public void Plus_One_Last_989Digit()
        {
            int[] sourceNums = { 9, 8, 9 };
            int[] nums = { 9,9,0 };
            var plusOneArr = MyArray.PlusOne(sourceNums);

            Assert.That(plusOneArr, Is.EquivalentTo(nums));
        }

        [Test]
        public void Plus_One_Invalid_Reversing() 
        {
            int[] sourceNums = { 9,8,7,6,5,4,3,2,1,0 };
            int[] nums = { 9,8,7,6,5,4,3,2,1,1 };
            var plusOneArr = MyArray.PlusOne(sourceNums);

            Assert.That(plusOneArr, Is.EquivalentTo(nums));
        }

        [Test]
        public void Plus_One_Long_Number()
        {
            int[] sourceNums = { 7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,6 };
            int[] nums = { 7,2,8,5,0,9,1,2,9,5,3,6,6,7,3,2,8,4,3,7,9,5,7,7,4,7,4,9,4,7,0,1,1,1,7,4,0,0,7 };
            var plusOneArr = MyArray.PlusOne(sourceNums);

            Assert.That(plusOneArr, Is.EquivalentTo(nums));
        }

        [Test]
        public void Find_Diagonal_Order()
        {
            int[][] nums = { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6}, new int[3] { 7, 8 ,9} };
            int[] numsArr = { 1, 2, 4, 7,5, 3, 6 ,8, 9 };
            var output = MyArray.FindDiagonalOrder(nums);

            Assert.That(numsArr, Is.EquivalentTo(output));
        }

        [Test]
        public void Find_Diagonal_Order_II()
        {
            int[][] nums = { new int[2] { 1, 2 }, new int[2] { 3, 4 } };
            int[] numsArr = { 1,2,3,4 };
            var output = MyArray.FindDiagonalOrder(nums);

            Assert.That(numsArr, Is.EquivalentTo(output));
        }

        [Test]
        public void Find_Diagonal_Order_One_Digit()
        {
            int[][] nums = { new int[1] { 1 } };
            int[] numsArr = { 1 };
            var output = MyArray.FindDiagonalOrder(nums);

            Assert.That(numsArr, Is.EquivalentTo(output));
        }

        [Test]
        public void Find_Diagonal_Order_Two_Digit()
        {
            int[][] nums = { new int[2] { 2, 3 } };
            int[] numsArr = { 2, 3 };
            var output = MyArray.FindDiagonalOrder(nums);

            Assert.That(numsArr, Is.EquivalentTo(output));
        }

        [Test]
        public void Find_Diagonal_Order_Three_Digit()
        {
            int[][] nums = { new int[3] { 6, 9, 7 } };
            int[] numsArr = { 6, 9, 7 };
            var output = MyArray.FindDiagonalOrder(nums);

            Assert.That(numsArr, Is.EquivalentTo(output));
        }

        [Test]
        public void Find_Diagonal_Order_One_Column()
        {
            int[][] nums = { new int[1] { 6 }, new int[1] { 9 }, new int[1] { 7 } };
            int[] numsArr = { 6, 9, 7 };
            var output = MyArray.FindDiagonalOrder(nums);

            Assert.That(numsArr, Is.EquivalentTo(output));
        }

        [Test]
        public void Find_Diagonal_Order_Not_Equal_Dimension()
        {
            int[][] nums = { new int[2] { 2, 5 }, new int[2] { 8, 4 }, new int[2] { 0, -1 } };
            int[] numsArr = { 2, 5, 8, 0, 4, -1 };
            var output = MyArray.FindDiagonalOrder(nums);

            Assert.That(numsArr, Is.EquivalentTo(output));
        }
    }
}
