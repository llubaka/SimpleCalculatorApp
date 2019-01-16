using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    class NumberButtonMethods
    {
        #region User Input Box Add Number

        /// <summary>
        /// The method is checking if the first digit is 0 as (044)
        /// and if so removing the 0
        /// if its not this method is adding the digit (button clicked) to the sequence
        /// </summary>
        /// <param name="userInputText"></param>
        public static void UserInputBoxAddNumber(ref string userInputText, string digit, int cursorIndex)
        {
            if (userInputText.Length == 1 && userInputText[0] == '0')
            {
                userInputText = digit;
            }
            else
            {
                userInputText += digit;

            }
        }

        #endregion


        /// <summary>
        /// Revering the string 
        /// </summary>
        /// <param name="userInputText"></param>
        /// <returns></returns>
        private static string ReverseString(string userInputText)
        {
            StringBuilder sb = new StringBuilder();
            int lastIndex = userInputText.Length - 1;
            for (int i = 0; i <= lastIndex; i++)
            {
                sb.Append(userInputText[lastIndex]);
                lastIndex--;
            }
            return sb.ToString();
        }

        #region Bool Method For Repeats of the operators

        /// <summary>
        /// return true if the last button used is from Operator Buttons i.e.
        /// used to prevent from stacking operators signs in the user unput text box 
        /// </summary>
        /// <param name="s"> user input text </param>
        /// <returns></returns>
        public static bool IsRepeating(string s)
        {
            if (s.Length > 2)
            {
                int index = s.Length - 3;
                if ((s.Substring(index).Equals(Operators.Divide)) ||
                        (s.Substring(index).Equals(Operators.Minus)) ||
                        (s.Substring(index).Equals(Operators.Multi)) ||
                        (s.Substring(index).Equals(Operators.Plus)))
                {
                    return true;
                }
                else return false;
            }
            else if (s.Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
