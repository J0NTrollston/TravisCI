using System;
using NUnit.Framework;

namespace TravisCILab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }
        
        [Test]
        public void Subtract_valid()
        {
            Assert.AreEqual(3, Program.Subtract("5", "2"));
        }

        [Test]
        public void Multiply_valid()
        {
            Assert.AreEqual(10, Program.Multiply("5", "2"));
        }

        [Test]
        public void Divide_valid()
        {
            Assert.AreEqual(5, Program.Divide("10", "2"));
        }

        [Test]
        public void Power_valid()
        {
            Assert.AreEqual(16, Program.Power("2", "4"));

            //make this test fail
            Assert.AreEqual(13, Program.Power("2", "2"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));

            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));

            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));

            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
    }
}
