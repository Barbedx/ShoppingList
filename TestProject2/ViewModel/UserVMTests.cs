namespace ShoppingList.Tests.ViewModel
{
    using ShoppingList.ViewModel;
    using System;
    using NUnit.Framework;
    using NSubstitute;
    using ShoppingList.BLL.Model;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [TestFixture]
    public class UserVMTests
    {
        private UserVM _testClass;
        private User _innerValue;

        [SetUp]
        public void SetUp()
        {
            _innerValue = new User { ID = 985727530, UserName = "TestValue1555649056", HashPassword = "TestValue532190019", LastLogin = new DateTime(960350817), ShopLists = Substitute.For<ICollection<ShopList>>() };
            _testClass = new UserVM(_innerValue);
        }

        [Test]
        public void CanConstruct()
        {
            var instance = new UserVM(_innerValue);
            Assert.That(instance, Is.Not.Null);
        }

        [Test]
        public void CannotConstructWithNullInnerValue()
        {
            Assert.Throws<ArgumentNullException>(() => new UserVM(default(User)));
        }

        [Test]
        public async Task CanCallSaveChanges()
        {
            await _testClass.SaveChanges();
            Assert.Fail("Create or modify test");
        }
    }
}