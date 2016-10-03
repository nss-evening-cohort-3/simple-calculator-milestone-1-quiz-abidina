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
            Expression expression = new Expression();
            //Assert
            Assert.IsNotNull(expression);

        }

        [TestMethod]
        public void ExtractOperator()
        {         
            Expression expression = new Expression();
            string expressionOperator = expression.getOperator("1 + 2");
            Assert.AreEqual("+", expressionOperator);
        }

        [TestMethod]
        public void ExtractOperandL()
        {
            Expression expression = new Expression();
            int expressionOperandL = expression.getOperandL("1 + 2");

            Assert.AreEqual(1, expressionOperandL);
        }

        [TestMethod]
        public void ExtractOperandR()
        {
            Expression expression = new Expression();
            int expressionOperandR = expression.getOperandR("1 + 2");

            Assert.AreEqual(2, expressionOperandR);
        }
    }
}
