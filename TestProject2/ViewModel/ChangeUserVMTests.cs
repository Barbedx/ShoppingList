namespace ShoppingList.Tests.ViewModel
{
    using ShoppingList.ViewModel;
    using System;
    using NUnit.Framework;
    using NSubstitute;
    using System.Collections.Generic;
    using ShoppingList.BLL.Model;
    using System.Windows.Input;

    [TestFixture]
    public class ChangeUserVMTests
    {
        private ChangeUserVM _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ChangeUserVM();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new ChangeUserVM();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanGetAvailableUsers()
        {
            Assert.That(_testClass.AvailableUsers, Is.InstanceOf<List<User>>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanSetAndGetSelectedUser()
        {
            _testClass.CheckProperty(x => x.SelectedUser, new User { ID = 1867293750, UserName = "TestValue366937539", HashPassword = "TestValue1531752288", LastLogin = new DateTime(1736262237), ShopLists = Substitute.For<ICollection<ShopList>>() }, new User { ID = 460662276, UserName = "TestValue1983840274", HashPassword = "TestValue338427802", LastLogin = new DateTime(540613285), ShopLists = Substitute.For<ICollection<ShopList>>() });
        }

        [Test]
        public void CanGetChangeUserCommand()
        {
            Assert.That(_testClass.ChangeUserCommand, Is.InstanceOf<ICommand>());
            Assert.Fail("Create or modify test");
        }
    }
}