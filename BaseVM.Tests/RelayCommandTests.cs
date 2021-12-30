namespace BaseVM.Tests
{
    using BaseVM;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class RelayCommandTests
    {
        private RelayCommand _testClass;
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

        [SetUp]
        public void SetUp()
        {
            _execute = default(Action<object>);
            _canExecute = default(Func<object, bool>);
            _testClass = new RelayCommand(_execute, _canExecute);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new RelayCommand(_execute);
            Assert.That(instance, Is.Not.Null);
            instance = new RelayCommand(_execute, _canExecute);
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CannotConstructWithNullExecute()
        {
            Assert.Throws<ArgumentNullException>(() => new RelayCommand(default(Action<object>)));
            Assert.Throws<ArgumentNullException>(() => new RelayCommand(default(Action<object>), default(Func<object, bool>)));
        }

        [Test]
        public void CannotConstructWithNullCanExecute()
        {
            Assert.Throws<ArgumentNullException>(() => new RelayCommand(default(Action<object>), default(Func<object, bool>)));
        }

        [Test]
        public void CanCallCanExecute()
        {
            var parameter = new object();
            var result = _testClass.CanExecute(parameter);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallCanExecuteWithNullParameter()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.CanExecute(default(object)));
        }

        [Test]
        public void CanCallExecute()
        {
            var parameter = new object();
            _testClass.Execute(parameter);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CannotCallExecuteWithNullParameter()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.Execute(default(object)));
        }
    }
}