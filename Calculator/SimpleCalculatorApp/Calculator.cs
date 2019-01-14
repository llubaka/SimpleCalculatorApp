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
        }

        #endregion

        #region Operator Methods

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (!NumberButtonMethods.IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += Operators.Plus;
            }
        }

        private void MultiButton_Click(object sender, EventArgs e)
        {
            if (!NumberButtonMethods.IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += Operators.Multi;
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (!NumberButtonMethods.IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += Operators.Minus;
            }
        }


        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (!NumberButtonMethods.IsRepeating(this.UserInputText.Text))
            {
                this.UserInputText.Text += Operators.Plus;
            }
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            //to return answer
        }

        #endregion

        #region Number Methods

        private void ZeroButton_Click(object sender, EventArgs e)
        {

        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            string userInput = this.UserInputText.Text;
            NumberButtonMethods.UserInputBoxAddNumber(ref userInput, "1");
            this.UserInputText.Text = userInput;
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            string userInput = this.UserInputText.Text;
            NumberButtonMethods.UserInputBoxAddNumber(ref userInput, "2");
            this.UserInputText.Text = userInput;
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            string userInput = this.UserInputText.Text;
            NumberButtonMethods.UserInputBoxAddNumber(ref userInput, "3");
            this.UserInputText.Text = userInput;
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            string userInput = this.UserInputText.Text;
            NumberButtonMethods.UserInputBoxAddNumber(ref userInput, "4");
            this.UserInputText.Text = userInput;
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            string userInput = this.UserInputText.Text;
            NumberButtonMethods.UserInputBoxAddNumber(ref userInput, "5");
            this.UserInputText.Text = userInput;
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            string userInput = this.UserInputText.Text;
            NumberButtonMethods.UserInputBoxAddNumber(ref userInput, "6");
            this.UserInputText.Text = userInput;
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            string userInput = this.UserInputText.Text;
            NumberButtonMethods.UserInputBoxAddNumber(ref userInput, "7");
            this.UserInputText.Text = userInput;
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            string userInput = this.UserInputText.Text;
            NumberButtonMethods.UserInputBoxAddNumber(ref userInput, "8");
            this.UserInputText.Text = userInput;
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            string userInput = this.UserInputText.Text;
            NumberButtonMethods.UserInputBoxAddNumber(ref userInput, "9");
            this.UserInputText.Text = userInput;
        }

        #endregion

        #region Dot Method

        /// <summary>
        /// checking if there is already "." in the User Input String Box 
        /// and if so do nothing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DotButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Private Helpers Methods

        private void OnFocusInputText()
        {
            UserInputText.Focus();
        }

        #endregion
    }
}
