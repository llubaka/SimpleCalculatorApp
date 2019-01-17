using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    /// <summary>
    /// some main methods used for the NumberButtons
    /// </summary>
    class MainButtonMethods
    {       
        #region User Input Box Add Number

        /// <summary>
        /// The method is checking if the first digit is 0 as (044)
        /// and if so removing the 0
        /// if its not this method is adding the digit (button clicked) to the sequence
        /// </summary>
        /// <param name="userInputText"></param>
        public static void UserInputBoxAddNumber(ref string userInputText, string digit)
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

        #region Not Used reverse string method

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

        #endregion             
    }
}
