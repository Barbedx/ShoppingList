namespace BaseVM.Tests.Mediator
{
    using BaseVM.Mediator;
    using T = System.String;
    using System;
    using NUnit.Framework;

    [TestFixture]
    public static class EventRaiserTests
    {
        [Test]
        public static void CanCallRaiseWithHanderAndSender()
        {
            var hander = default(EventHandler);
            var sender = new object();
            hander.Raise(sender);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallRaiseWithHanderAndSenderWithNullHander()
        {
            Assert.Throws<ArgumentNullException>(() => default(EventHandler).Raise(new object()));
        }

        [Test]
        public static void CannotCallRaiseWithHanderAndSenderWithNullSender()
        {
            Assert.Throws<ArgumentNullException>(() => default(EventHandler).Raise(default(object)));
        }

        [Test]
        public static void CanCallRaiseWithEventHandlerOfEventArgsOfTAndObjectAndT()
        {
            var hander = default(EventHandler<EventArgs<T>>);
            var sender = new object();
            var Value = "TestValue1237404555";
            hander.Raise(sender, Value);
            Assert.Fail("Create or modify test");
        }

        [Test]
        public static void CannotCallRaiseWithEventHandlerOfEventArgsOfTAndObjectAndTWithNullHander()
        {
            Assert.Throws<ArgumentNullException>(() => default(EventHandler<EventArgs<T>>).Raise(new object(), "TestValue1260319157"));
        }

        [Test]
        public static void CannotCallRaiseWithEventHandlerOfEventArgsOfTAndObjectAndTWithNullSender()
        {
            Assert.Throws<ArgumentNullException>(() => default(EventHandler<EventArgs<T>>).Raise(default, "TestValue2066185633"));
        }    
    }
}