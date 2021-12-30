namespace ShoppingList.Tests.ViewModel
{
    using ShoppingList.ViewModel;
    using System;
    using NUnit.Framework;
    using NSubstitute;
    using ShoppingList.BLL.Model;
    using System.Collections.Generic;

    [TestFixture]
    public class ShopListItemVMTests
    {
        private ShopListItemVM _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ShopListItemVM();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new ShopListItemVM();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanSetAndGetIsNew()
        {
            _testClass.CheckProperty(x => x.IsNew);
        }

        [Test]
        public void CanSetAndGetInnerValue()
        {
            _testClass.CheckProperty(x => x.InnerValue, new ShopListItem { ShopListId = 1926153633, UserId = 1920767917, ItemId = 1792508283, IsChecked = false, Count = 1835305834.23, User = new User { ID = 727590587, UserName = "TestValue643639260", HashPassword = "TestValue1476886173", LastLogin = new DateTime(818291882), ShopLists = Substitute.For<ICollection<ShopList>>() }, ShopList = new ShopList { ID = 1162397125, UserId = 736998531, Name = "TestValue306281070", IsActive = true, User = new User { ID = 1116922727, UserName = "TestValue795190643", HashPassword = "TestValue1513368425", LastLogin = new DateTime(2126776925), ShopLists = Substitute.For<ICollection<ShopList>>() }, ShopListItems = Substitute.For<ICollection<ShopListItem>>() }, Item = new Item { CategoryId = 1426172144, Name = "TestValue303363973", Price = 858388936.68, ItemCategory = new ItemCategory { ID = 298374699, Name = "TestValue36348995", Items = Substitute.For<ICollection<Item>>() }, ShopListItems = Substitute.For<ICollection<ShopListItem>>() } }, new ShopListItem { ShopListId = 992582976, UserId = 317182068, ItemId = 1188983521, IsChecked = true, Count = 124955808.12, User = new User { ID = 971663685, UserName = "TestValue1642742999", HashPassword = "TestValue553977142", LastLogin = new DateTime(1424892419), ShopLists = Substitute.For<ICollection<ShopList>>() }, ShopList = new ShopList { ID = 1898754648, UserId = 898115661, Name = "TestValue1953689625", IsActive = false, User = new User { ID = 779961857, UserName = "TestValue30113914", HashPassword = "TestValue1422405737", LastLogin = new DateTime(945275967), ShopLists = Substitute.For<ICollection<ShopList>>() }, ShopListItems = Substitute.For<ICollection<ShopListItem>>() }, Item = new Item { CategoryId = 1461342094, Name = "TestValue520195232", Price = 1192169320.65, ItemCategory = new ItemCategory { ID = 694811486, Name = "TestValue479201458", Items = Substitute.For<ICollection<Item>>() }, ShopListItems = Substitute.For<ICollection<ShopListItem>>() } });
        }

        [Test]
        public void CanGetItem()
        {
            Assert.That(_testClass.Item, Is.InstanceOf<Item>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanSetAndGetIsChecked()
        {
            _testClass.CheckProperty(x => x.IsChecked);
        }

        [Test]
        public void CanSetAndGetCount()
        {
            _testClass.CheckProperty(x => x.Count, 2118556659.78, 1870234539.03);
        }
    }
}