using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculatorApp
{
    /// <summary>
    /// A simple calculator application
    /// </summary>
    public partial class CalculatorForm : Form
    {
        #region Constructor

        /// <summary>
        /// Default consstructor
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Calculator Load Method

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Deleting Methods

        /// <summary>
        /// Deletes the user input text and returns to the UI a deffault of 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = "0";
            OnFocusInputText();
        }

        /// <summary>
        /// Deletes the last number(index) of the User Input Text Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelButton_Click(object sender, EventArgs e)
        {
            if (this.UserInputText.Text.Length > 0)
            {
                int lastIndex = this.UserInputText.Text.Length - 1;
                this.UserInputText.Text = this.UserInputText.Text.Remove(lastIndex);
            }
            OnFocusInputText();
        }

        #endregion

        #region Operator Methods

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (!IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += $" {Operators.Divide} ";
            }
            else
            {
                ReplaceOperator(Operators.Divide);
            }
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            if (!IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += $" {Operators.Multi} ";
            }
            else
            {
                ReplaceOperator(Operators.Multi);
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (!IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += $" {Operators.Minus} ";
            }
            else
            {
                ReplaceOperator(Operators.Minus);
            }
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (!IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += $" {Operators.Plus} ";
            }
            else
            {
                ReplaceOperator(Operators.Plus);
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (IsResultable(this.UserInputText.Text))
            {
                this.UserInputText.Text = ExpressionResult.GetExpressionResult(this.UserInputText.Text);
            }
        }

        #endregion

        #region EqualsButton main verifications method(s)

        private bool IsResultable(string text)
        {            
            if (IsValidExpression(text))
            {
                return true;
            }
            else
            {

                ShowMessageBox("Not a valid expression!");
                return false;
            }
        }

        /// <summary>
        /// spliting the string with the operators and by this getting the array with two operands.
        /// example. 100 + 200 , returning array with two values . More or less values in the string
        /// is accepted as a bad format input text , bad expression
        /// </summary>
        /// <param name="text"> user input text </param>
        /// <returns></returns>
        private bool IsValidExpression(string text)
        {
            string[] values = text.Split(new char[] { '+', '-', 'x', '/' },StringSplitOptions.RemoveEmptyEntries);
            double un = 0;
            if (text.Length < 3)
            {
                return false;
            }
            else if (values.Length != 2) 
            {
                return false;
            }

            else if ((double.TryParse(values[0], out un)) && (double.TryParse(values[1], out un)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void ShowMessageBox(string text)
        {
            MessageBox.Show(text);
        }

        #endregion

        #region Number Methods

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            AddNumberToUserInputTextBox("0");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            AddNumberToUserInputTextBox("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            AddNumberToUserInputTextBox("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            AddNumberToUserInputTextBox("3");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            AddNumberToUserInputTextBox("4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            AddNumberToUserInputTextBox("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            AddNumberToUserInputTextBox("6");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            AddNumberToUserInputTextBox("7");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            AddNumberToUserInputTextBox("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            AddNumberToUserInputTextBox("9");
        }

        #endregion
        //remove bug where cant have 2 dots in the separate 2,0 + 2,1
        #region Dot Method

        /// <summary>
        /// checking if there is already "." in the User Input String Box 
        /// and if so do nothing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButton_Click_1(object sender, EventArgs e)
        {
            if (this.UserInputText.Text.Contains("."))
            {
                // do nothing
            }
            else
            {
                this.UserInputText.Text += ".";
            }

        }
        #endregion

        #region Private Helper Methods

        /// <summary>
        /// using this method to focus the User Input Text Box 
        /// </summary>
        private void OnFocusInputText()
        {
            UserInputText.Focus();
        }

        /// <summary>
        /// using this method to prevent the repeats of the 0 in the User Input Text Box 
        /// not using this method because the method UserInputBoxAddNumber() is having the job done
        /// </summary>
        private bool IsZero(string text)
        {
            if (text.Length == 1)
            {
                if (text[0] == '0')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// using this method to add the button clicked number to the User Input Text Box
        /// </summary>
        /// <param name="value">get the string to write in the UIBox</param>
        private void AddNumberToUserInputTextBox(string value)
        {
            string userInput = this.UserInputText.Text;
            int cursorIndex = this.UserInputText.SelectionStart;
            NumberButtonMethods.UserInputBoxAddNumber(ref userInput, value, cursorIndex);
            this.UserInputText.Text = userInput;
        }

        #endregion

        #region Operator Helper Methods

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
                int lastIndex = s.Length;
                int index = s.Length - 3;
                if ((s.Contains(Operators.Divide)) ||
                        (s.Contains(Operators.Minus)) ||
                        (s.Contains(Operators.Multi)) ||
                        (s.Contains(Operators.Plus)))
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

       /// <summary>
       /// replacing the operator in the user input box 
       /// </summary>
       /// <param name="op"></param>
        private void ReplaceOperator(string op)
        {
            if (this.UserInputText.Text.Contains("+"))
            {
                int operatorIndex = this.UserInputText.Text.IndexOf('+');
                this.UserInputText.Text = this.UserInputText.Text.Replace('+', op[0]);
            }
            else if (this.UserInputText.Text.Contains("-"))
            {
                int operatorIndex = this.UserInputText.Text.IndexOf('-');
                this.UserInputText.Text = this.UserInputText.Text.Replace('-', op[0]);
            }
            else if (this.UserInputText.Text.Contains("x"))
            {
                int operatorIndex = this.UserInputText.Text.IndexOf('x');
                this.UserInputText.Text = this.UserInputText.Text.Replace('x', op[0]);
            }
            else
            {
                int operatorIndex = this.UserInputText.Text.IndexOf('/');
                this.UserInputText.Text = this.UserInputText.Text.Replace('/', op[0]);
            }
        }

        #endregion
    }
}
