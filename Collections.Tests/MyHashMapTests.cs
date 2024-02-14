using Exercises.Collections;
using Exercises.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Tests
{
    internal class MyHashMapTests
    {
        private MyHashMap hashMap;

        [SetUp]
        public void SetUp()
        {
            this.hashMap = new MyHashMap();
            hashMap.Put(1, 10);
        }

        [Test]
        public void Put_Key_Value_Pair()
        {
            hashMap.Put(100, 1);
            var expected = hashMap.Get(100);
            Assert.That(expected, Is.EqualTo(1));
        }

        [Test]
        public void Get_Value()
        {
            var expected = this.hashMap.Get(1);
            Assert.That(expected, Is.EqualTo(10));
        }

        [Test]
        public void Get_Lack_Key_Value()
        {
            var expected = this.hashMap.Get(100);
            Assert.That(expected, Is.EqualTo(-1));
        }

        [Test]
        public void Remove_Key()
        {
            hashMap.Remove(1);
            var expected = hashMap.Get(1);
            Assert.That(expected, Is.EqualTo(-1));
        }

        [Test]
        public void Remove_Empty_Key()
        {
            hashMap.Remove(500);
            var expected = hashMap.Get(500);
            Assert.That(expected, Is.EqualTo(-1));
        }

        [Test]
        public void Is_Isomorphic_Three_Char()
        {
            Assert.That(MyHashMap.IsIsomorphic("egg", "add"), Is.True);
        }

        [Test]
        public void Is_Not_Isomorphic_Three_Char()
        {
            Assert.That(MyHashMap.IsIsomorphic("foo", "bar"), Is.False);
        }

        [Test]
        public void Is_Isomorphic_Five_Char()
        {
            Assert.That(MyHashMap.IsIsomorphic("paper", "title"), Is.True);
        }

        [Test]
        public void Is_Isomorphic_Four_Char()
        {
            Assert.That(MyHashMap.IsIsomorphic("badc", "baba"), Is.False);
        }

        [Test]
        public void Find_Restaurant_Shogun()
        {
            var expected = new string[] { "Shogun" };
            var output = MyHashMap.FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "Piatti", "The Grill at Torrey Pines", "Hungry Hunter Steakhouse", "Shogun" });
            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void Find_Restaurant_Shogun_Again()
        {
            var expected = new string[] { "Shogun" };
            var output = MyHashMap.FindRestaurant(new string[] { "Shogun", "Tapioca Express", "Burger King", "KFC" }, new string[] { "KFC", "Shogun", "Burger King" });
            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void Find_Restaurant_Two_Words_Finding()
        {
            var expected = new string[] { "happy", "sad" };
            var output = MyHashMap.FindRestaurant(new string[] { "happy", "sad", "good" }, new string[] { "sad", "happy", "good" });
            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void First_Uniq_Char()
        {
            var expected = 2;
            var output = MyHashMap.FirstUniqChar("loveleetcode");
            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void First_Uniq_Char_Non_Unique()
        {
            var expected = -1;
            var output = MyHashMap.FirstUniqChar("aabb");
            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void Intersection_Without_Repets()
        {
            var expected = new int[] { 2, 2 };
            var output = MyHashMap.Intersection(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 });
            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void Intersection_With_Repets()
        {
            var expected = new int[] { 9,4 };
            var output = MyHashMap.Intersection(new int[] { 4,9,5 }, new int[] { 9,4,9,8,4 });
            Assert.That(expected, Is.EqualTo(output));
        }

        [Test]
        public void Contain_Nearby_Duplicate()
        {
            Assert.That(MyHashMap.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3), Is.True);
        }

        [Test]
        public void Contain_Nearby_Duplicate_More_Same_Values()
        {
            Assert.That(MyHashMap.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1), Is.True);
        }

        [Test]
        public void Not_Contain_Nearby_Duplicate()
        {
            Assert.That(MyHashMap.ContainsNearbyDuplicate(new int[] { 1, 2 ,3, 1, 2, 3 }, 2), Is.False);
        }

        [Test]
        public void Find_Duplicate_Subtrees_2()
        {
            var left = new TreeNode(2, 
                new TreeNode(4));
            var right = new TreeNode(3, 
                new TreeNode(2, new TreeNode(4)), 
                new TreeNode(4));
            var root = new TreeNode(1, left, right);
            MyHashMap.FindDuplicateSubtrees(root);
        }

        [Test]
        public void Num_Jewels_Find_2()
        {
            var output = MyHashMap.NumJewelsInStones("aA", "aAAbbbb");
            var expected = 3;
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Num_Jewels_Find_0()
        {
            var output = MyHashMap.NumJewelsInStones("z", "Z");
            var expected = 0;
            Assert.That(output, Is.EqualTo(expected));
        }

        [Test]
        public void Longest_Substring_3()
        {
            var exptected = 3;
            var output = MyHashMap.LengthOfLongestSubstring("abcabcbb");
            Assert.That(output, Is.EqualTo(exptected));
        }

        [Test]
        public void Longest_Substring_1()
        {
            var exptected = 1;
            var output = MyHashMap.LengthOfLongestSubstring("bbbbb");
            Assert.That(output, Is.EqualTo(exptected));
        }

        [Test]
        public void Longest_Substring_3_With_Subsequence()
        {
            var exptected = 3;
            var output = MyHashMap.LengthOfLongestSubstring("pwwkew");
            Assert.That(output, Is.EqualTo(exptected));
        }

        [Test]
        public void Longest_Substring_3_Again()
        {
            var exptected = 3;
            var output = MyHashMap.LengthOfLongestSubstring("dvdf");
            Assert.That(output, Is.EqualTo(exptected));
        }
    }
}
