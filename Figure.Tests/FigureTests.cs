using System;
using NUnit.Framework;

namespace Figure.Tests
{
    public class FigureTests
    {
        [Test]
        public void Triangle_2_4_8__it()
        {
            var expected = Assert.Throws<Exception>(() =>
            {
                var triangle = new Triangle(2, 4, 8);
            });
            
            Assert.That(expected.Message == "Impossible triangle");
        }
        
        [Test]
        public void Triangle_2_n4_8__it()
        {
            var expected = Assert.Throws<Exception>(() =>
            {
                var triangle = new Triangle(2, -4, 8);
            });
            
            Assert.That(expected.Message == "Impossible triangle");
        }
        
        [Test]
        public void Triangle_2_n4_n8__it()
        {
            var expected = Assert.Throws<Exception>(() =>
            {
                var triangle = new Triangle(2, -4, -8);
            });
            
            Assert.That(expected.Message == "Impossible triangle");
        }
        
        [Test]
        public void Circle_n3__ic()
        {
            var expected = Assert.Throws<Exception>(() =>
            {
                var circle = new Circle(-3);
            });
            
            Assert.That(expected.Message == "Impossible circle");
        }
        
        [Test]
        public void Square_Triangle_3_4_5__6()
        {
            Triangle t = new Triangle(3, 4, 5);
            const int expected = 6;

            var actual = Operation.Square(t);
            
            Assert.AreEqual(expected, actual);
        }
        
        [Test]
        public void Square_Triangle_2_4_5__4()
        {
            Triangle t = new Triangle(2, 4, 5);
            var expected = Math.Sqrt(231)/4;

            var actual = Operation.Square(t);
            
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Square_Circle_6__36Pi()
        {
            Circle c = new Circle(6);
            var expected = Math.PI * 36;

            var actual = Operation.Square(c);
            
            Assert.AreEqual(expected, actual);
        }
    }
}