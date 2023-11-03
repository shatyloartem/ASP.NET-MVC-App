using System.Drawing;
using System.Windows.Forms;

namespace Graph
{
    public partial class CalculatorView : Form, IOutputPrintable
    {
        public enum ButtonType
        {
            Plus,
            Minus,
            Multiply,
            Division
        }

        public enum ThemeType
        {
            Active,
            Inactive,
            Pressed
        }
        
        
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

        public void changeButtonTheme(ButtonType buttonType, ThemeType themeType)
        {
            Button button = default;

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
    }
}
