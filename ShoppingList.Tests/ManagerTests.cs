namespace ShoppingList.Tests.BLL
{
    using ShoppingList.BLL;
    using System;
    using NUnit.Framework;
    using NSubstitute;
    using ShoppingList.BLL.Model;
    using System.Collections.Generic;
    using ShoppingList.ViewModel;

    [TestFixture]
    public class ManagerTests
    {
        private Manager _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = Manager.Instance;
        }

        [Test]
        public void CanCallGetAllUsers()
        {
            var result = _testClass.GetAllUsers();
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanCallGetShopLists()
        {
            var result = _testClass.GetShopLists();
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetInstance()
        {
            Assert.That(Manager.Instance, Is.InstanceOf<Manager>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanSetAndGetCurrentUser()
        {
            var testValue = new User { ID = 1641598583, UserName = "TestValue729471106", HashPassword = "TestValue47923220", LastLogin = new DateTime(1645723015), ShopLists = Substitute.For<ICollection<ShopList>>() };
            _testClass.CurrentUser = testValue;
            Assert.That(_testClass.CurrentUser, Is.EqualTo(testValue));
        }

        [Test]
        public void CanSetAndGetCurrentShopList()
        {
            var testValue = new ShopListVM();
            _testClass.CurrentShopList = testValue;
            Assert.That(_testClass.CurrentShopList, Is.EqualTo(testValue));
        }
    }
}