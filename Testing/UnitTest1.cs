using NUnit.Framework;
using System;
using WPF_рон;
using WpfAppForTPO;

namespace Testing
{
    public class Tests
    {
        Area Area = new Area();
        [SetUp]
        
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(Area.AreaRectangle(4, 4), 16);
            Assert.AreEqual(Area.AreaRectangle(6, 5), 30);
            Assert.AreEqual(Area.AreaRectangle(12, 4), 48);
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual(Area.AreaCircle(4),50 );
            Assert.AreEqual(Area.AreaCircle(7), 154);
            Assert.AreEqual(Area.AreaCircle(123), 47529);
        }
    }
}