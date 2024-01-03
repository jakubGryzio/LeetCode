using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class ReverseStringTests
    {
        [Test]
        public void Reverse_String()
        {
            var input = new char[] { 'h', 'e', 'l', 'l', 'o' };
            var reversed = new char[] { 'o', 'l', 'l', 'e', 'h' };
            MyArray.ReverseString(input);
            Assert.That(input, Is.EqualTo(reversed));
        }
    }
}
