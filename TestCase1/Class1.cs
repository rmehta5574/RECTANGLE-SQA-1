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
        //testing of set length
        public void TestGetLength_input4_expectLength4()
        {
            int l = 4;
            int w = 5;
            Rectangle rect = new Rectangle(l, w);
            int length = rect.GetLength();
            Assert.AreEqual(length, l);
        }

        [Test]
        //testing of getting inputed length
        public void TestSetLength_input3_expectLength3()
        {
            int l = 4;
            int w = 5;
            Rectangle rect = new Rectangle(l, w);
            int length = rect.GetLength();
            Assert.AreEqual(length, l);
        }

        [Test]
        ////testing of setting width
        public void TestSetWidth_input4_expectwidth4()
        {
            int l = 5;
            int w = 4;
            Rectangle rect = new Rectangle(l, w);
            int width = rect.GetWidth();
            Assert.AreEqual(width, w);
        }

        [Test]
        //testing of getting width
        public void TestGetWidth_input4_expectwidth4()
        {
            
            int l = 5;
            int w = 4;
            Rectangle rect = new Rectangle(l, w);
            int width = rect.GetWidth();
            Assert.AreEqual(width, w);
        }

        [Test]
        //checking parameter expected value
        public void TestPerimeter_input5_expectPerimeter20()
        {

            int l = 5;
            int w = 5;
            int p = 20;
            Rectangle rect = new Rectangle(l, w);
            int perimeter = rect.GetPerimeter();
            Assert.AreEqual(perimeter, p);
        }

        [Test]
        //checking value of expected area
        public void TestPerimeter_input5_expectArea25()
        {
            int l = 5;
            int w = 5;
            int a = 25;
            Rectangle rect = new Rectangle(l, w);
            int area = rect.GetArea();
            Assert.AreEqual(area, a);
        }
    }
}
