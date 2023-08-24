using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_UI.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void celsiusToFahrenheitButton_Click(object sender, EventArgs e)
        {
            celsiusToFahrenheitForm celsiusFahrenheitForm = new celsiusToFahrenheitForm();
            celsiusFahrenheitForm.Show();
        }

        private void fahrenheitToCelsiusButton_Click(object sender, EventArgs e)
        {
            fahrenheitToCelsiusForm fahrenheitCelsiusForm = new fahrenheitToCelsiusForm();
            fahrenheitCelsiusForm.Show();
        }

        private void kelvinToCelsiusButton_Click(object sender, EventArgs e)
        {
            kelvinToCelsiusForm kelvinCelsiusForm = new kelvinToCelsiusForm();
            kelvinCelsiusForm.Show();
        }

        private void celsiusToKelvinButton_Click(object sender, EventArgs e)
        {
            celsiusToKelvinForm celsiusKelvinForm = new celsiusToKelvinForm();
            celsiusKelvinForm.Show();
        }

        private void kelvinToFahrenheitButton_Click(object sender, EventArgs e)
        {
            kelvinToFahrenheitForm kelvinFahrenheitForm = new kelvinToFahrenheitForm();
            kelvinFahrenheitForm.Show();
        }

        private void fahrenheitToKelvinButton_Click(object sender, EventArgs e)
        {
            fahrenheitToKelvinForm fahrenheitKelvinForm = new fahrenheitToKelvinForm();
            fahrenheitKelvinForm.Show();
        }
    }
}
