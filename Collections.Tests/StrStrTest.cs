using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class StrStrTest
    {
        [Test]
        public void Str_Str_Valid()
        {
            var expected = 0;
            var output = MyArray.StrStr("sadbutsad", "sad");

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Str_Str_Invalid()
        {
            var expected = -1;
            var output = MyArray.StrStr("leetcode", "leeto");

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Str_Str_Valid_ShortLength()
        {
            var expected = 0;
            var output = MyArray.StrStr("l", "l");

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Str_Str_Invalid_ShortLength()
        {
            var expected = -1;
            var output = MyArray.StrStr("a", "l");

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Str_Str_In_String()
        {
            var expected = 1;
            var output = MyArray.StrStr("mississippi", "issi");

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Str_Str_Needel_Greater()
        {
            var expected = -1;
            var output = MyArray.StrStr("aa", "aaaaaa");

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Str_Str_Not_Full_Valid()
        {
            var expected = 4;
            var output = MyArray.StrStr("mississippi", "issip");

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Str_Str_Not_Full_Valid_II()
        {
            var expected = -1;
            var output = MyArray.StrStr("mississippi", "issipi");

            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Str_Str_Lot_Of_Same_Letter()
        {
            var expected = 6;
            var output = MyArray.StrStr("mississippi", "sipp");

            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
