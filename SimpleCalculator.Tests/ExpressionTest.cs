using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class ExpressionTest
    {
        
        [TestMethod]
        public void ExpressionEnsureICanCreateAnInstance()
        {
            //Arrange

            //Act
            Expression user_expression = new Expression();
            //Assert
            Assert.IsNotNull(user_expression);

        }

        [TestMethod]
        public void ExtractOperator()
        {         
            Expression user_expression = new Expression();
            string expressionOperator = user_expression.getOperator("1 + 2");

            Assert.AreEqual("+", expressionOperator);
        }

        [TestMethod]
        public void ExtractOperandL()
        {
            Expression user_expression = new Expression();
            string expressionOperandL = user_expression.getOperandL("1 + 2");

            Assert.AreEqual("1", expressionOperandL);
        }

        [TestMethod]
        public void ExtractOperandR()
        {
            Expression user_expression = new Expression();
            string expressionOperandR = user_expression.getOperandR("1 + 2");

            Assert.AreEqual("2", expressionOperandR);
        }
    }
}
