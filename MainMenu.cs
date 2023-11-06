using System;
using System.Windows.Forms;

namespace Graph
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void calculatorButton(object sender, EventArgs e)
        {
            loadPageForm(new CalculatorController().getViewForm());
        }

        private void multiplicationTableButton(object sender, EventArgs e)
        {
            loadPageForm(new MultiplicationTableController().getViewForm());
        } 

        private void ageCategoriesButton(object sender, EventArgs e)
        {
            loadPageForm(new AgeCategoriesController().getViewForm());
        }

        private void loadPageForm(Form form)
        {
            Hide();
            
            if(form.ShowDialog() == DialogResult.Cancel)
                Show();
        }
    }
}
