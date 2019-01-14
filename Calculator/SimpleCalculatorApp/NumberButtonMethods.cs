using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    class NumberButtonMethods
    {
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

        /// <summary>
        /// return true if the last button used is from Operator Buttons i.e.
        /// used to prevent from stacking operators signs in the user unput text box 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsRepeating(string s)
        {
            //index of last possible operator . Used  s.Length-2 ,because the operators are followed
            // by space etc. " 
            int index = s.Length - 3;
            if ((s.Substring(index).Equals(Operators.Divide)) ||
                    (s.Substring(index).Equals(Operators.Minus)) ||
                    (s.Substring(index).Equals(Operators.Multi)) ||
                    (s.Substring(index).Equals(Operators.Plus)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
