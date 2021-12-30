namespace ShoppingList.Tests.ViewModel
{
 

    using System;
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Windows.Input;
    using ShoppingList.ViewModel;

    [TestFixture]
    public class ShopListCatalogVMTests
    {
        private ShopListCatalogVM _testClass;

        [SetUp]
        public void SetUp()
        {
            _testClass = new ShopListCatalogVM();
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new ShopListCatalogVM();
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CanGetAvailableShopList()
        {
            Assert.That(_testClass.AvailableShopList, Is.InstanceOf<List<ShopListVM>>());
            Assert.Fail("Create or modify test");
        }

        [Test]
        public void CanSetAndGetSelectedShopList()
        {
            _testClass.CheckProperty(x => x.SelectedShopList, new ShopListVM(), new ShopListVM());
        }

        [Test]
        public void CanGetChangeShopListCommand()
        {
            Assert.That(_testClass.ChangeShopListCommand, Is.InstanceOf<ICommand>());
            Assert.Fail("Create or modify test");
        }
    }
}