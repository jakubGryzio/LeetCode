using Exercises.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class MyHashSetTests
    {
        private MyHashSet hashSet;

        [SetUp]
        public void SetUp()
        {
            this.hashSet = new MyHashSet();
            hashSet.Add(1);
        }

        [Test]
        public void Add_Key_Out_Of_Range()
        {
            Assert.Throws<IndexOutOfRangeException>(
                () => hashSet.Add(int.MaxValue));
        }

        [Test]
        public void Add_Negative_Key()
        {
            Assert.Throws<IndexOutOfRangeException>(
                () => hashSet.Add(-1));
        }

        [Test]
        public void Add_Key()
        {
            hashSet.Add(5);
            var expected = hashSet.Contains(5);
            Assert.That(expected, Is.True);
        }

        [Test]
        public void Remove_Key()
        {
            hashSet.Remove(1);
            var expected = hashSet.Contains(1);
            Assert.That(expected, Is.False);
        }

        [Test]
        public void Remove_NonExists_Key()
        {
            hashSet.Remove(100);
            var expected = hashSet.Contains(100);
            Assert.That(expected, Is.False);
        }

        [Test]
        public void Contains_Key()
        {
            hashSet.Add(5);
            var expected = hashSet.Contains(5);
            Assert.That(expected, Is.True);
        }

        [Test]
        public void Not_Contains_Key()
        {
            hashSet.Add(5);
            var expected = hashSet.Contains(100);
            Assert.That(expected, Is.False);
        }

        [Test]
        public void Intersection()
        {
            var expected = new int[] { 2 };
            var output = MyHashSet.Intersection(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void Intersection_First_Smaller_Than_Second_Array()
        {
            var expected = new int[] { 9, 4 };
            var output = MyHashSet.Intersection(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 });
            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void Is_Happy_19()
        {
            Assert.That(MyHashSet.IsHappy(19), Is.True);
        }

        [Test]
        public void Is_Happy_2()
        {
            Assert.That(MyHashSet.IsHappy(2), Is.False);
        }
    }
}
