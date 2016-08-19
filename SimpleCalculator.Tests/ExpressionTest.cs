using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        //Expression user_expression = new Expression();

        [TestMethod]
        public void ExtractOperator()
        {
            //Arrange

            //Act
            Expression user_expression = new Expression();
            string expressionOperator = user_expression.getOperator("1 + 2");

            //Assert
            Assert.IsNotNull(user_expression);
            Assert.AreEqual("+", expressionOperator);
        }
    }
}
