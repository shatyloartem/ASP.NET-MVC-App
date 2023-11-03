using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class MultiplicationTableView : Form, IButtonThemeChangeable, IOutputPrintable
    {
        public MultiplicationTableView(MultiplicationTableController controller)
        {
            InitializeComponent(controller);
        }

        /// <summary>
        /// Used to show result message
        /// </summary>
        /// <param name="message">Message. Invalid Input if null</param>
        public void printResult(string message)
        {
            if (message == null)
            {
                outputLabel.Text = "Invalid input";
                outputLabel.ForeColor = Color.Red;
                return;
            }

            outputLabel.ForeColor = Color.White;
            outputLabel.Text = message;
        }
        
        /// <summary>
        /// Used to change specific button theme
        /// </summary>
        /// <param name="buttonType">Type of the button to change</param>
        /// <param name="themeType">Theme to change the button</param>
        public void changeButtonTheme(ButtonType buttonType, ButtonThemeType themeType)
        {
            Button button = default;

            switch (buttonType)
            {
                case ButtonType.Calculate:
                    button = calculateButton;
                    break;
            }

            switch (themeType)
            {
                case ButtonThemeType.Inactive:
                    button.BackColor = Color.Black;
                    button.ForeColor = Color.White;
                    break;
                
                case ButtonThemeType.Active:
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                    break;
                
                case ButtonThemeType.Pressed:
                    button.BackColor = Color.DarkCyan;
                    button.ForeColor = Color.Black;
                    break;
            }
        }
    }
}
