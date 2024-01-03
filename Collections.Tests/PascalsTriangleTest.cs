using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    public class PascalsTriangleTest
    {
        [Test]
        public void Generate_1Row()
        {
            int numRows = 1;
            var expected = new List<int[]> { new int[] { 1 } };
            var output = MyArray.Generate(numRows);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_2Rows()
        {
            int numRows = 2;
            var expected = new List<int[]> { new int[] { 1 }, new int[] { 1, 1 } };
            var output = MyArray.Generate(numRows);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_3Rows()
        {
            int numRows = 3;
            var expected = new List<int[]> { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 } };
            var output = MyArray.Generate(numRows);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_4Rows()
        {
            int numRows = 4;
            var expected = new List<int[]> { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 }, new int[] { 1, 3, 3, 1 } };
            var output = MyArray.Generate(numRows);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Generate_5Rows()
        {
            int numRows = 5;
            var expected = new List<int[]> { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 2, 1 }, new int[] { 1, 3, 3, 1 }, new int[] { 1, 4, 6, 4, 1 } };
            var output = MyArray.Generate(numRows);
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
