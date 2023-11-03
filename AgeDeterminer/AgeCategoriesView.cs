using System;
using System.Drawing;
using System.Windows.Forms;

namespace Graph
{
    public partial class AgeCategoriesView : Form, IOutputPrintable
    {
        public enum ButtonType
        {
            Calculate
        }

        public enum ThemeType
        {
            Active,
            Inactive,
            Pressed
        }
        
        public AgeCategoriesView(AgeCategoriesController controller)
        {
            InitializeComponent(controller);
        }

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
        
        
        public void changeButtonTheme(ButtonType buttonType, ThemeType themeType)
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
                case ThemeType.Inactive:
                    button.BackColor = Color.Black;
                    button.ForeColor = Color.White;
                    break;
                
                case ThemeType.Active:
                    button.BackColor = Color.White;
                    button.ForeColor = Color.Black;
                    break;
                
                case ThemeType.Pressed:
                    button.BackColor = Color.DarkCyan;
                    button.ForeColor = Color.Black;
                    break;
            }
        }
        
        
        
        
        
        
        private void OKButton_Click(object sender, EventArgs e)
        {
            String userInput = InputAge.Text;
            double userAge;
            if (double.TryParse(userInput, out userAge) && userAge > 0)
            {
                outputLabel.ForeColor = Color.White;
            }
            else
            {
                outputLabel.Text = "Invalid input";
                outputLabel.ForeColor = Color.Red;
                return;
            }
            if (userAge > 10 && userAge < 17)
            {
                outputLabel.Text = "Teenager";
            }
            else if (userAge <= 10)
            {
                outputLabel.Text = "Child";
            }
            else
            {
                outputLabel.Text = "Adult";
            }
        }
    }
}
