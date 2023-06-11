using System;
using NUnit.Framework;

namespace Task1.UnitTests
{
    [TestFixture]
    public class Vector2Tests
    {
        [TestCase(1, 1)]
        [TestCase(-1, 1)]
        [TestCase(1.5f, 1.2f)]
        public void ConstructorTest(float x, float y)
        {
            var vector = new Vector2D(x, y);
            Assert.That(vector.X, Is.EqualTo(x));
            Assert.That(vector.Y, Is.EqualTo(y));
        }

        [TestCase(1, 1.5f)]
        [TestCase(0, 0)]
        [TestCase(-1, -1)]
        [TestCase(3, 4)]
        public void LengthTest(float x, float y)
        {
            var vector = new Vector2D(x, y);
            var expected = (float)Math.Sqrt(x * x + y * y);
            Assert.That(vector.Length, Is.EqualTo(expected));
        }

        [TestCase(1, 1, 1, 1, true)]
        [TestCase(1, 1, -1, 1, false)]
        [TestCase(1, 1, -1, -1, false)]
        [TestCase(1, 1.5f, 1, 1.49f, false)]
        public void EqualTest(float x1, float y1, float x2, float y2, bool answer)
        {
            var a = new Vector2D(x1, y1);
            var b = new Vector2D(x2, y2);
            Assert.That(a.Equals(b), Is.EqualTo(answer));
        }
        
        [TestCase(1.5f, 1.5f, 1, 1, 2.5f, 2.5f)]
        [TestCase(1, 1, -1, -1, 0, 0)]
        public void AdditionTest(float x1, float y1, float x2, float y2, float cx, float cy)
        {
            var a = new Vector2D(x1, y1);
            var b = new Vector2D(x2, y2);
            var c = a + b;
            Assert.That(c.X, Is.EqualTo(cx));
            Assert.That(c.Y, Is.EqualTo(cy));
        }
        
        [TestCase(1.5f, 1.5f, 1, 1, 0.5f, 0.5f)]
        [TestCase(1, 1, -1, -1, 2, 2)]
        [TestCase(1, 1, 5, -5, -4, 6)]
        public void SubtractionTest(float x1, float y1, float x2, float y2, float cx, float cy)
        {
            var a = new Vector2D(x1, y1);
            var b = new Vector2D(x2, y2);
            var c = a - b;
            Assert.That(c.X, Is.EqualTo(cx));
            Assert.That(c.Y, Is.EqualTo(cy));
        }
        
        [TestCase(1, 2.5f, 3, 3, 7.5f)]
        [TestCase(-1, 2, -3, 3, -6)]
        public void FloatMultiplicationTest(float x1, float y1, float n, float cx, float cy)
        {
            var a = new Vector2D(x1, y1);
            var c = n * a;
            Assert.That(c.X, Is.EqualTo(cx));
            Assert.That(c.Y, Is.EqualTo(cy));
        }
        
        [TestCase(1, 2.5f, 3, 3, 10.5f)]
        [TestCase(-1, 2, -1, 2, 5)]
        [TestCase(1, 0, 0, 1, 0)]
        public void VectorMultiplicationTest(float x1, float y1, float x2, float y2, float answer)
        {
            var a = new Vector2D(x1, y1);
            var b = new Vector2D(x2, y2);
            var c = a * b;
            Assert.That(c, Is.EqualTo(answer));
        }
    }
}