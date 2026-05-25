using Abc.Aids;

namespace Abc.Tests.Aids
{
    [TestClass]
    public sealed class GetRandomTests
    {
        private const sbyte min = sbyte.MinValue;
        private const sbyte max = sbyte.MaxValue;

        [TestMethod]
        public void Int32Test()
        {
            var x = GetRandom.Int32(min, max);
            var y = GetRandom.Int32(min, max);
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void Int64Test()
        {
            var x = GetRandom.Int64(min, max);
            var y = GetRandom.Int64(min, max);
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void DoubleTest()
        {
            var x = GetRandom.Double(min, max);
            var y = GetRandom.Double(min, max);
            Assert.AreNotEqual(x, y);
        }
        [TestMethod]
        public void Int8Test()
        {
            var x = GetRandom.Int8(min, max);
            var y = GetRandom.Int8(min, max);
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void Int16Test()
        {
            var x = GetRandom.Int16(min, max);
            var y = GetRandom.Int16(min, max);
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void UInt8Test()
        {
            var x = GetRandom.UInt8();
            var y = GetRandom.UInt8();
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void UInt16Test()
        {
            var x = GetRandom.UInt16();
            var y = GetRandom.UInt16();
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void UInt32Test()
        {
            var x = GetRandom.UInt32();
            var y = GetRandom.UInt32();
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void UInt64Test()
        {
            var x = GetRandom.UInt64();
            var y = GetRandom.UInt64();
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void DecimalTest()
        {
            var x = GetRandom.Decimal(min, max);
            var y = GetRandom.Decimal(min, max);
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void FloatTest()
        {
            var x = GetRandom.Float(min, max);
            var y = GetRandom.Float(min, max);
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void StringTest()
        {
            var x = GetRandom.String();
            var y = GetRandom.String();
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void CharTest()
        {
            var x = GetRandom.Char();
            var y = GetRandom.Char();
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void BoolTest()
        {
            for (int i = 0; i < 100; i++)
            {
                var b = GetRandom.Bool();
                Assert.IsTrue(b == true || b == false);
            }
        }

        [TestMethod]
        public void DateTimeTest()
        {
            var x = GetRandom.DateTime();
            var y = GetRandom.DateTime();
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void TimeSpanTest()
        {
            var x = GetRandom.TimeSpan();
            var y = GetRandom.TimeSpan();
            Assert.AreNotEqual(x, y);
        }

        [TestMethod]
        public void GuidTest()
        {
            var x = GetRandom.Guid();
            var y = GetRandom.Guid();
            Assert.AreNotEqual(x, y);
        }
    }
}
