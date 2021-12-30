namespace BaseVM.Tests
{
    using BaseVM;
    using T = System.String;
    using System;
    using NUnit.Framework;
    using System.Linq.Expressions;

    [TestFixture]
    public static class SymbolHelpersTests
    {  
        [Test]
        public static void CannotCallGetPropertyNameWithNullPropertyExpression()
        {
            Assert.Throws<ArgumentNullException>(() => SymbolHelpers.GetPropertyName<T>(default(Expression<Func<T>>)));
        }
    }
}