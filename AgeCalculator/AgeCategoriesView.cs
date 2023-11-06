using System.Drawing;
using System.Windows.Forms;

namespace Graph
{
    public partial class AgeCategoriesView : Form
    {
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
        
        public void changeButtonTheme(ButtonType buttonType, ButtonThemeType themeType)
        {
            Button button = calculateButton;

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
