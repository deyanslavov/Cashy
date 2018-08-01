namespace Cashy.Core
{
    using System;
    using System.Reflection;
    using System.Linq.Expressions;

    /// <summary>
    /// A helper for expressions
    /// </summary>
    public static class ExpressionHelpers
    {
        /// <summary>
        /// Compiles an expression and get the function's return value
        /// </summary>
        /// <typeparam name="T">The type of return value</typeparam>
        /// <param name="lambda">The expression to compile</param>
        /// <returns></returns>
        public static T GetPropertyValue<T>(this Expression<Func<T>> lambda)
        {
            return lambda.Compile().Invoke();
        }

        /// <summary>
        /// Sets the underlying properties value to the given value
        /// from an expression that contains the property
        /// </summary>
        /// <typeparam name="T">The type of return value</typeparam>
        /// <param name="lambda">The expression to compile</param>
        /// <param name="value">The value to set the property to</param>
        /// <returns></returns>
        public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value)
        {
            // Converts a lambda () => some.Property, to some.Property
            MemberExpression expression = (lambda as LambdaExpression).Body as MemberExpression;

            // Get the property information so we can set it
            PropertyInfo propertyInfo = (PropertyInfo)expression.Member;

            object target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();

            // Set the property value
            propertyInfo.SetValue(target, value);
        }
    }
}
