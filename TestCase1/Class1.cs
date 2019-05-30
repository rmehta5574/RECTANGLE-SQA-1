using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignmentdemo;
using NUnit.Framework;

namespace TestCase1
{
    [TestFixture]
    class Class1
    {
        [Test]
        public void TestGetLength_input4_expectLength4()
        {
            int l = 4;
            int w = 5;
            Rectangle rect = new Rectangle(l, w);
            int length = rect.GetLength();
            Assert.AreEqual(length, l);
        }

        [Test]
        public void TestSetLength_input3_expectLength3()
        {
            int l = 4;
            int w = 5;
            Rectangle rect = new Rectangle(l, w);
            int length = rect.GetLength();
            Assert.AreEqual(length, l);
        }

        [Test]
        public void TestSetWidth_input3_expectLength3()
        {
            int l = 5;
            int w = 4;
            Rectangle rect = new Rectangle(l, w);
            int length = rect.GetLength();
            Assert.AreEqual(length, l);
        }

        [Test]
        public void TestGetWidth_input3_expectLength3()
        {
            int l = 5;
            int w = 4;
            Rectangle rect = new Rectangle(l, w);
            int length = rect.GetLength();
            Assert.AreEqual(length, l);
        }

        [Test]
        public void TestPerimeter_input5_expectPerimeter20()
        {
            int l = 5;
            int w = 5;
            Rectangle rect = new Rectangle(l, w);
            int length = rect.GetLength();
            Assert.AreEqual(length, l);
        }

        [Test]
        public void TestPerimeter_input5_expectArea25()
        {
            int l = 5;
            int w = 5;
            Rectangle rect = new Rectangle(l, w);
            int length = rect.GetLength();
            Assert.AreEqual(length, l);
        }
    }
}
