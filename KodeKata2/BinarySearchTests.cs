using NUnit.Framework;

namespace KodeKata
{
    [Ignore]
    public class BinarySearchTests
    {
        protected BinarySearch _BS;
     

        [Test]
        public void ChopEmptyTest()
        {
            Assert.That(_BS.chop(3, new int[0]), Is.EqualTo(-1));
        }

        [Test]
        public void ChopOneTest()
        {
            Assert.That(_BS.chop(3, new int[] { 1 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(1, new int[] { 1 }), Is.EqualTo(0));

        }

        [Test]
        public void ChopeThreeTest()
        {

            Assert.That(_BS.chop(1, new int[] { 1, 3, 5 }), Is.EqualTo(0));
            Assert.That(_BS.chop(3, new int[] { 1, 3, 5 }), Is.EqualTo(1));
            Assert.That(_BS.chop(5, new int[] { 1, 3, 5 }), Is.EqualTo(2));
            Assert.That(_BS.chop(0, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(2, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(4, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(6, new int[] { 1, 3, 5 }), Is.EqualTo(-1));
        }

        [Test]
        public void ChopFourTest()
        {
            Assert.That(_BS.chop(1, new int[] { 1, 3, 5, 7 }), Is.EqualTo(0));
            Assert.That(_BS.chop(3, new int[] { 1, 3, 5, 7 }), Is.EqualTo(1));
            Assert.That(_BS.chop(5, new int[] { 1, 3, 5, 7 }), Is.EqualTo(2));
            Assert.That(_BS.chop(7, new int[] { 1, 3, 5, 7 }), Is.EqualTo(3));
            Assert.That(_BS.chop(0, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(2, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(4, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(6, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(8, new int[] { 1, 3, 5, 7 }), Is.EqualTo(-1));

        }

        [Test]
        public void ChopTwoTest()
        {
            Assert.That(_BS.chop(1, new int[] { 1, 5 }), Is.EqualTo(0));
            Assert.That(_BS.chop(3, new int[] { 1, 5 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(5, new int[] { 1, 5 }), Is.EqualTo(1));
            Assert.That(_BS.chop(0, new int[] { 1, 5 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(2, new int[] { 1, 5 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(4, new int[] { 1, 5 }), Is.EqualTo(-1));
            Assert.That(_BS.chop(6, new int[] { 1, 5 }), Is.EqualTo(-1));

        }
    }
}