using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KodeKata
{
    [TestFixture]
    internal class BinarySearchFourTests : BinarySearchTests
    {

        [SetUp]
        public void Setup()
        {
            _BS = new BinarySearchFour();
        }
    }
}
