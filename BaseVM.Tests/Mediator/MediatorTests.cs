namespace BaseVM.Tests.Mediator
{
    using BaseVM.Mediator;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public static class MediatorTests
    {
        [Test]
        public static void CanCallRegister()
        {
            var token = "TestValue78922703";
            var callback = default(Action<object>);
            Mediator.Register(token, callback);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallRegisterWithNullCallback()
        {
            Assert.Throws<ArgumentNullException>(() => Mediator.Register("TestValue602856529", default(Action<object>)));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallRegisterWithInvalidToken(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Mediator.Register(value, default(Action<object>)));
        }

        [Test]
        public static void CanCallUnregister()
        {
            var token = "TestValue738519346";
            var callback = default(Action<object>);
            Mediator.Unregister(token, callback);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallUnregisterWithNullCallback()
        {
            Assert.Throws<ArgumentNullException>(() => Mediator.Unregister("TestValue1457827340", default(Action<object>)));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallUnregisterWithInvalidToken(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Mediator.Unregister(value, default(Action<object>)));
        }

        [Test]
        public static void CanCallNotifyCollegues()
        {
            var token = "TestValue1357557928";
            var args = new[] { new object(), new object(), new object() };
            Mediator.NotifyCollegues(token, args);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallNotifyColleguesWithNullArgs()
        {
            Assert.Throws<ArgumentNullException>(() => Mediator.NotifyCollegues("TestValue2136151929", default(object[])));
        }

        [TestCase(null)]
        [TestCase("")]
        [TestCase("   ")]
        public static void CannotCallNotifyColleguesWithInvalidToken(string value)
        {
            Assert.Throws<ArgumentNullException>(() => Mediator.NotifyCollegues(value, new[] { new object(), new object(), new object() }));
        }
    }
}