using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESFE.Calculadora.UnitTest.AppxUnit
{
    public class CalculadoraTests
    {
        [Fact]
        public void Add_ShoulReturnCorrectSum() {
            //Arrange 
            Calculator calculator = new Calculator();
            double num1 = 5.0;
            double num2 = 3.0;

            // Act
            double result = calculator.Add(num1, num2);

            //Assert
            Assert.Equal(8, result);
        }


        [Fact]
        public void SubTract_ShoulReturnCorrectDifference()
        {
            //Arrange 
            Calculator calculator = new Calculator();
            double num1 = 8.0;
            double num2 = 3.0;

            // Act
            double result = calculator.Subtract(num1, num2);

            //Assert
            Assert.Equal(5.0, result);
        }


        [Fact]
        public void Multiply_ShoulReturnCorrectProduct()
        {
            //Arrange 
            Calculator calculator = new Calculator();
            double num1 = 4.0;
            double num2 = 2.0;

            // Act
            double result = calculator.Multiply(num1, num2);

            //Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Divide_ShoulReturnCorrectQuotient()
        {
            //Arrange 
            Calculator calculator = new Calculator();
            double num1 = 10.0;
            double num2 = 2.0;

            // Act
            double result = calculator.Divide(num1, num2);

            //Assert
            Assert.Equal(5.0, result);
        }

        [Fact]
        public void Divide_ByZero_ShoulThrowException()
        {
            //Arrange 
            Calculator calculator = new Calculator();
            double num1 = 5.0;
            double num2 = 0.0;

            // Act
           Assert.Throws<ArgumentException>(()=> calculator.Divide(num1, num2));

        }
    }
}
