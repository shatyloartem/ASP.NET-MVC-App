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
    public partial class multiplicationTable : Form
    {
        public multiplicationTable()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            String userInput = inputNum.Text;
            double userNum;
            if (double.TryParse(userInput, out userNum))
            {
                outputLabel1.ForeColor = Color.White;
            }
            else
            {
                outputLabel1.Text = "Invalid input";
                outputLabel1.ForeColor = Color.Red;
                return;
            }
            String table = "";

            for (int i = 1; i < 11; i++)
            {
                table += (i + " * " + userNum + " = " + i * userNum + "\n");
            }
            outputLabel1.Text = table;
        }
    }
}
