using System;
using System.Linq.Expressions;

namespace BaseVM
{
    static public class SymbolHelpers
    {
        static public string GetPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null || propertyExpression.Body == null)
                return string.Empty;

            var memberExpression = propertyExpression.Body as MemberExpression;
            var propertyName = memberExpression.Member.Name;
            return propertyName;
        }
    }
}
