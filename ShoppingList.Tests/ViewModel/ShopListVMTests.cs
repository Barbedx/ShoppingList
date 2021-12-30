namespace ShoppingList.Tests.ViewModel
{
    using ShoppingList.ViewModel;
    using System;
    using NUnit.Framework;
    using NSubstitute;
    using ShoppingList.BLL.Model;
    using System.Collections.Generic;
    using System.Windows.Input;

    [TestFixture]
    public class ShopListVMTests
    {
        private ShopListVM _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ShopListVM();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new ShopListVM();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanCallAddItem()
        {
            _testClass.AddItem();
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanSetAndGetInnerValue()
        {
            _testClass.CheckProperty(x => x.InnerValue, new ShopList { ID = 1307327018, UserId = 750371023, Name = "TestValue1719230543", IsActive = true, User = new User { ID = 1756968959, UserName = "TestValue1181973779", HashPassword = "TestValue1680476301", LastLogin = new DateTime(1618851917), ShopLists = Substitute.For<ICollection<ShopList>>() }, ShopListItems = Substitute.For<ICollection<ShopListItem>>() }, new ShopList { ID = 242238586, UserId = 1889804638, Name = "TestValue928184941", IsActive = true, User = new User { ID = 1620898184, UserName = "TestValue1633228344", HashPassword = "TestValue601372599", LastLogin = new DateTime(1819459222), ShopLists = Substitute.For<ICollection<ShopList>>() }, ShopListItems = Substitute.For<ICollection<ShopListItem>>() });
        }

        [Test]
        public void CanGetItems()
        {
            Assert.That(_testClass.Items, Is.InstanceOf<List<ShopListItemVM>>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetItemCount()
        {
            Assert.That(_testClass.ItemCount, Is.InstanceOf<int>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetCurrentItemCount()
        {
            Assert.That(_testClass.CurrentItemCount, Is.InstanceOf<int>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetName()
        {
            Assert.That(_testClass.Name, Is.InstanceOf<string>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetAllItems()
        {
            Assert.That(_testClass.AllItems, Is.InstanceOf<List<Item>>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanSetAndGetNewItemName()
        {
            _testClass.CheckProperty(x => x.NewItemName);
        }

        [Test]
        public void CanSetAndGetCount()
        {
            _testClass.CheckProperty(x => x.Count, 1961810552.79, 261671592.6);
        }

        [Test]
        public void CanGetAddItemCommand()
        {
            Assert.That(_testClass.AddItemCommand, Is.InstanceOf<ICommand>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetHasErrors()
        {
            Assert.That(_testClass.HasErrors, Is.InstanceOf<bool>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetError()
        {
            Assert.That(_testClass.Error, Is.InstanceOf<string>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanGetIndexer()
        {
            Assert.That(_testClass["TestValue1884988353"], Is.InstanceOf<string>());
            Assert.Fail("Create or modify test");
        }
    }
}