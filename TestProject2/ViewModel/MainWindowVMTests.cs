namespace ShoppingList.Tests.ViewModel
{
    using ShoppingList.ViewModel;
    using System;
    using NUnit.Framework;
    using ShoppingList.BLL.Model;
    using BaseVM;
    using System.Windows.Input;

    [TestFixture]
    public class MainWindowVMTests
    {
        private MainWindowVM _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new MainWindowVM();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new MainWindowVM();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanGetCurrentShopList()
        {
            Assert.That(_testClass.CurrentShopList, Is.InstanceOf<ShopListVM>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetCurrentUser()
        {
            Assert.That(_testClass.CurrentUser, Is.InstanceOf<User>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetUserSelected()
        {
            Assert.That(_testClass.UserSelected, Is.InstanceOf<bool>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetShopListSelected()
        {
            Assert.That(_testClass.ShopListSelected, Is.InstanceOf<bool>());
            Assert.Fail("Create or modify test");
        }
          
        [Test]
        public void CanGetLogOutCommand()
        {
            Assert.That(_testClass.LogOutCommand, Is.InstanceOf<ICommand>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetChangeShopListCommand()
        {
            Assert.That(_testClass.ChangeShopListCommand, Is.InstanceOf<ICommand>());
            Assert.Fail("Create or modify test");
        }
    }
}