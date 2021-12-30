namespace BaseVM.Tests.Custom
{
    using BaseVM.Custom;
    using T = System.String;
    using System;
    using NUnit.Framework;
    using System.Threading.Tasks;

    [TestFixture]
    public class EditableDataVM_1Tests
    {
        private class TestEditableDataVM : EditableDataVM<T>
        {
            public TestEditableDataVM(T innerValue) : base(innerValue)
            {
            }

            public override Task SaveChanges()
            {
                return default(Task);
            }
        }

        private TestEditableDataVM _testClass;
        private T _innerValue;

        [SetUp]
        public void SetUp()
        {
            _innerValue = "TestValue1299712782";
            _testClass = new TestEditableDataVM(_innerValue);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new TestEditableDataVM(_innerValue);
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CannotConstructWithNullInnerValue()
        {
            Assert.Throws<ArgumentNullException>(() => new TestEditableDataVM(default(T)));
        }

        [Test]
        public void InnerValueIsInitializedCorrectly()
        {
            Assert.That(_testClass.InnerValue, Is.EqualTo(_innerValue));
        }
    }
}