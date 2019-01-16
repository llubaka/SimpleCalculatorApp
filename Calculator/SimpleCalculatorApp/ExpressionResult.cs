using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    class ExpressionResult
    {
        public static void GetExpressionResult(string userInputText)
        {
            string[] values = userInputText.Split(new char[] { '+', 'x', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
            string firstOperand = RemoveWhiteSpaces(values[0]);
            string secondOperand = RemoveWhiteSpaces(values[1]);

            GetOperator(userInputText);
        }

        private static string GetOperator(string s)
        {            
            if (s.Contains(Operators.Plus))
            {

            }
            else if (s.Contains(Operators.Minus))
            {

            }
            else if (s.Contains(Operators.Multi))
            {

            }
            else if(s.Contains(Operators.Divide))
            {

            }
        }

        private static string RemoveWhiteSpaces(string s)
        {
            string referedStr = s;
            CallRecursiveMethod(ref referedStr, 0, s.Length);
            return referedStr;
        }

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
}
