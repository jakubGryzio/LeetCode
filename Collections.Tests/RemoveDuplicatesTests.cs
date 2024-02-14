using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class RemoveDuplicatesTests
    {
        [Test]
        public void Remove_Duplicates_5()
        {
            var expected = 5;
            var output = MyArray.RemoveDuplicates(new int[] { 0,0,1,1,1,2,2,3,3,4 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Remove_Duplicates_2()
        {
            var expected = 2;
            var output = MyArray.RemoveDuplicates(new int[] { 1, 1, 2 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Remove_Duplicates_1_OnlyOneElement()
        {
            var expected = 1;
            var output = MyArray.RemoveDuplicates(new int[] { 1 });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Remove_Duplicates_1()
        {
            var expected = 1;
            var output = MyArray.RemoveDuplicates(new int[] { 1, 1, 1, 1, 1 });
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
