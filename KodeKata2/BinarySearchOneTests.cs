using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KodeKata
{
    [TestFixture]
    class BinarySearchOneTests
    {   
        private BinarySearchOne _BSOne;

        [SetUp]
        public void Setup()
        {
            _BSOne = new BinarySearchOne();
        }

        [Test]
        public void ChopEmptyTest()
        {
            Assert.That(_BSOne.chop(3, new int[0]), Is.EqualTo(-1));
        }

        [Test]
        public void ChopOneTest()
        {
            Assert.That(_BSOne.chop(3, new int[] {1}), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(1, new int[] {1}), Is.EqualTo(0));

        }

        [Test]
        public void ChopeThreeTest()
        {

            Assert.That(_BSOne.chop(1, new int[] { 1, 3, 5 }), Is.EqualTo(0));
            Assert.That(_BSOne.chop(3, new int[] { 1, 3, 5 }), Is.EqualTo(1));
            Assert.That(_BSOne.chop(5, new int[] { 1, 3, 5 }), Is.EqualTo(2));
            Assert.That(_BSOne.chop(0, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(2, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(4, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(6, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
        }

        [Test]
        public void ChopFourTest()
        {
            Assert.That(_BSOne.chop(1, new int[] { 1, 3, 5, 7 }), Is.EqualTo(0));
            Assert.That(_BSOne.chop(3, new int[] { 1, 3, 5, 7 }), Is.EqualTo(1));
            Assert.That(_BSOne.chop(5, new int[] { 1, 3, 5, 7 }), Is.EqualTo(2));
            Assert.That(_BSOne.chop(7, new int[] { 1, 3, 5, 7 }), Is.EqualTo(3));
            Assert.That(_BSOne.chop(0, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(2, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(4, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(6, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(8, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
           
        }

        [Test]
        public void ChopTwoTest()
        {
            Assert.That(_BSOne.chop(1, new int[] { 1, 5 }), Is.EqualTo(0));
            Assert.That(_BSOne.chop(3, new int[] { 1, 5 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(5, new int[] { 1, 5 }), Is.EqualTo(1));
            Assert.That(_BSOne.chop(0, new int[] { 1, 5 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(2, new int[] { 1, 5 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(4, new int[] { 1, 5 }), Is.EqualTo(-1));
            Assert.That(_BSOne.chop(6, new int[] { 1, 5 }), Is.EqualTo(-1));

        }
    }
}
