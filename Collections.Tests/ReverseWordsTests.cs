using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class ReverseWordsTests
    {
        [Test]
        public void Reverse_Without_Whitespaces()
        {
            var expected = "blue is sky the";
            var output = MyArray.ReverseWords("the sky is blue");
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Reverse_With_Whitespaces()
        {
            var expected = "world hello";
            var output = MyArray.ReverseWords("  hello world  ");
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Reverse_With_Whitespaces_In_Sentence()
        {
            var expected = "example good a";
            var output = MyArray.ReverseWords("a good   example");
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Reverse_Words_Long_Sentence()
        {
            var expected = "s'teL ekat edoCteeL tsetnoc";
            var output = MyArray.ReverseWordsII("Let's take LeetCode contest");
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
