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
            if (!NumberButtonMethods.IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += $" {Operators.Divide} ";
            }
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            if (!NumberButtonMethods.IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += $" {Operators.Multi} ";
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (!NumberButtonMethods.IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += $" {Operators.Minus} ";
            }
        }


        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (!NumberButtonMethods.IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += $" {Operators.Plus} ";
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            ExpressionResult.GetExpressionResult(this.UserInputText.Text);
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

        #region Private Helpers Methods

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

    }
}
