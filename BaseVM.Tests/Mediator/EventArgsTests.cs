namespace BaseVM.Tests.Mediator
{
    using BaseVM.Mediator;
    using T = System.String;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class EventArgs_1Tests
    {
        private EventArgs<T> _testClass;
        private T _value;

        [SetUp]
        public void SetUp()
        {
            _value = "TestValue1796388260";
            _testClass = new EventArgs<T>(_value);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new EventArgs<T>(_value);
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void ValueIsInitializedCorrectly()
        {
            Assert.That(_testClass.Value, Is.EqualTo(_value));
        }
    }
}