using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaycheckCalculator
{
    public partial class Paycheck : Form
    {
        public Paycheck()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            double hoursWorked = Convert.ToDouble(hoursTextBox.Text);
            double wages = Convert.ToDouble(wageTextBox.Text);
            double total = (hoursWorked * wages) * 0.77365;
            total = Math.Round(total, 2);

            totalCheckBox.Text = total.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            hoursTextBox.Clear();
            wageTextBox.Clear();
            totalCheckBox.Clear();
        }
    }
}
