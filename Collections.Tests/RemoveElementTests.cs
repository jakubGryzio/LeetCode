using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class RemoveElementTests
    {
        [Test]
        public void Remove_Element_3_Should_Be_2()
        {
            var expected = 2;
            var output = MyArray.RemoveElement(new int[] { 3, 2, 2, 3 }, 3);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Remove_Element_2_Should_Be_5()
        {
            var expected = 5;
            var output = MyArray.RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Remove_Element_NotInArray_Should_Be_LengthArray()
        {
            var expected = 5;
            var output = MyArray.RemoveElement(new int[] { 0, 1, 2, 2, 3 }, 10);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Remove_Element_OnlyInArray_Should_Be_0()
        {
            var expected = 0;
            var output = MyArray.RemoveElement(new int[] { 1, 1, 1, 1, 1 }, 1);
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Remove_Element_EmptyArray_Should_Be_0()
        {
            var expected = 0;
            var output = MyArray.RemoveElement(new int[] {  }, 1);
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
