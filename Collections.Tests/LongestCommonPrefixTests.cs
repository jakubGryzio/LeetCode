using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class LongestCommonPrefixTests
    {
        [Test]
        public void Find_Longest_Prefix()
        {
            var expected = "fl";
            var output = MyArray.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Find_Prefix_With_No_Prefix()
        {
            var expected = "";
            var output = MyArray.LongestCommonPrefix(new string[] { "reflower", "flow", "flight" });
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Find_No_Longest_Prefix()
        {
            var expected = "";
            var output = MyArray.LongestCommonPrefix(new string[] { "dog", "racecar", "car" });
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
