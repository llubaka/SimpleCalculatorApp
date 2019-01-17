using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    #region Calculate Methods

    /// <summary>
    /// The main methods needed to get the result of the expression in the user input box
    /// no error handling in this class
    /// </summary>
    class ExpressionResult
    {
        /// <summary>
        /// the public method used to calculate an expression , by calling the other private methods in this class
        /// </summary>
        /// <param name="userInputText"></param>
        /// <returns></returns>
        public static string GetExpressionResult(string userInputText)
        {
            string[] values = userInputText.Split(new char[] { '+', 'x', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
            string firstOperand = RemoveWhiteSpaces(values[0]);
            string secondOperand = RemoveWhiteSpaces(values[1]);
            string operation = GetOperator(userInputText);
            string result = CalculateExpression(firstOperand,secondOperand,operation);
            return result;
        }

        /// <summary>
        /// the calculating method
        /// </summary>
        /// <param name="firstOperand"></param>
        /// <param name="secondOperand"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        private static string CalculateExpression(string firstOperand, string secondOperand, string operation)
        {
            decimal f = decimal.Parse(firstOperand);
            decimal s = decimal.Parse(secondOperand);

            if (s==0)
            {
                return "-Infinity";
            }
            else if (operation.Equals("+")) 
            {
                return (f + s).ToString();
            }
            else if (operation.Equals("x"))
            {
                return (f * s).ToString();
            }
            else if (operation.Equals("/"))
            {
                return (f / s).ToString();
            }
            else 
            {
                return (f - s).ToString();
            }
        }

        /// <summary>
        /// checking an expression (the given string s) and returning the operator coitaned
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string GetOperator(string s)
        {            
            if (s.Contains(Operators.Plus))
            {
                return Operators.Plus;
            }
            else if (s.Contains(Operators.Minus))
            {
                return Operators.Minus;
            }
            else if (s.Contains(Operators.Multi))
            {
                return Operators.Multi;
            }
            else 
            {
                return Operators.Divide;
            }           
        }

        /// <summary>
        /// Removing the white spaces from the given string , by calling the Recursive method CallRecursiveMethod()
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string RemoveWhiteSpaces(string s)
        {
            string referedStr = s;
            CallRecursiveMethod(ref referedStr, 0, s.Length);
            return referedStr;
        }

        /// <summary>
        /// Recursively checking all the symbols in the given string and removing the white space
        /// </summary>
        /// <param name="s"></param>
        /// <param name="index"></param>
        /// <param name="length"></param>
        private static void CallRecursiveMethod(ref string s, int index, int length)
        {
            if (index == length)
            {
                return;
            }
            else
            {
                if (s[index] == ' ')
                {
                    s = s.Remove(index, 1);
                    CallRecursiveMethod(ref s, index, length - 1);
                }
                else
                {
                    CallRecursiveMethod(ref s, index + 1, length);
                }
            }
        }
    }

    #endregion
}
