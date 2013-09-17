using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace KodeKata
{
    [TestFixture]
    internal class BinarySearchThreeTests :BinarySearchTests
    {

        [SetUp]
        public void Setup()
        {
            _BS = new BinarySearchThree();
        }
    }
}
