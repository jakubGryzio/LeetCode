using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    public class AddBinaryTest
    {
        [Test]
        public void Add_Binary_11_1()
        {
            string output = MyArray.AddBinary("11", "1");
            string expected = "100";
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Add_Binary_1010_1011()
        {
            string output = MyArray.AddBinary("1010", "1011");
            string expected = "10101";
            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
