using NUnit.Framework;
using Test2;

namespace Test2.Test
{
    [TestFixture]
    public class SoChanLeTest
    {
        SoChanLe soChanLe;

        [SetUp]
        public void Setup()
        {
            soChanLe = new SoChanLe();
        }

        [Test]
        public void Test_SoChan()
        {
            var result = soChanLe.KiemTraChanLe(2);
            Assert.That(result, Is.EqualTo("Chẵn"));
        }

        [Test]
        public void Test_SoLe()
        {
            var result = soChanLe.KiemTraChanLe(3);
            Assert.That(result, Is.EqualTo("Lẻ"));
        }

        [Test]
        public void Test_So0()
        {
            var result = soChanLe.KiemTraChanLe(0);
            Assert.That(result, Is.EqualTo("Chẵn"));
        }

        [Test]
        public void Test_SoAmChan()
        {
            var result = soChanLe.KiemTraChanLe(-4);
            Assert.That(result, Is.EqualTo("Chẵn"));
        }

        [Test]
        public void Test_SoAmLe()
        {
            var result = soChanLe.KiemTraChanLe(-5);
            Assert.That(result, Is.EqualTo("Lẻ"));
        }
    }
}