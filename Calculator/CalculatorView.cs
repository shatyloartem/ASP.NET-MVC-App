using System.Drawing;
using System.Windows.Forms;

namespace Graph
{
    public partial class CalculatorView : Form
    {
        public CalculatorView(CalculatorController controller)
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

        public void changeButtonTheme(ButtonType buttonType, ButtonThemeType themeType)
        {
            Button button = plusButton;

            switch (buttonType)
            {
                case ButtonType.Plus:
                    button = plusButton;
                    break;
                
                case ButtonType.Minus:
                    button = subtractButton;
                    break;
                
                case ButtonType.Multiply:
                    button = multiplyButton;
                    break;
                
                case ButtonType.Division:
                    button = divisionButton;
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
