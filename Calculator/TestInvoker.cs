using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
   public class TestInvoker
    {
        private CalculatorPage calculatorPage;

        public TestInvoker(CalculatorPage calculatorPage)
        {
            this.calculatorPage = calculatorPage;
        }

        public string GetResult(string expression)
        {
            calculatorPage.LoadPage();
            ExecuteExpression(expression);

            return calculatorPage.GetCurrentResult();
        }

        public string GetResultAndExpression(string expression)
        {
            calculatorPage.LoadPage();
            ExecuteExpression(expression);

            return calculatorPage.GetCurrentExpressionAndResult();
        }

        private void ExecuteExpression(string expression)
        {
            foreach (char buttonName in expression)
            {
                calculatorPage.ClickButtonByName(buttonName);
            }

            calculatorPage.ClickButtonByName('=');
        }

        /*private void ExecuteExpression(string expression)
        {
            foreach (string buttonName in expression.Split(' '))
            {
                calculatorPage.ClickButtonByName(buttonName);
            }

            calculatorPage.ClickButtonByName("=");
        }*/
    }
}
