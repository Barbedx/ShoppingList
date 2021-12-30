namespace BaseVM.Tests
{
    using BaseVM;
    using T = System.String;
    using System;
    using NUnit.Framework;
    using System.Linq.Expressions;

    [TestFixture]
    public class CommandHolderTests
    {
        private CommandHolder _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new CommandHolder();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new CommandHolder();
            Assert.That(instance, Is.Not.Null);
        }
         
        [Test]
        public void CannotCallGetOrCreateCommandWithExpressionOfFuncOfTAndActionOfObjectWithNullCommandNameExpression()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.GetOrCreateCommand<T>(default(Expression<Func<T>>), default(Action<object>)));
        }
          

        [Test]
        public void CannotCallGetOrCreateCommandWithExpressionOfFuncOfTAndActionOfObjectAndFuncOfObjectAndBoolWithNullCommandNameExpression()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.GetOrCreateCommand<T>(default(Expression<Func<T>>), default(Action<object>), default(Func<object, bool>)));
        }  
        [Test]
        public void CannotCallGetOrCreateCommandWithExpressionOfFuncOfTAndActionAndFuncOfBoolWithNullCommandNameExpression()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.GetOrCreateCommand<T>(default(Expression<Func<T>>), default(Action), default(Func<bool>)));
        }
         
        [Test]
        public void CannotCallGetOrCreateCommandWithExpressionOfFuncOfTAndActionWithNullCommandNameExpression()
        {
            Assert.Throws<ArgumentNullException>(() => _testClass.GetOrCreateCommand<T>(default(Expression<Func<T>>), default(Action)));
        }
         
    }
}