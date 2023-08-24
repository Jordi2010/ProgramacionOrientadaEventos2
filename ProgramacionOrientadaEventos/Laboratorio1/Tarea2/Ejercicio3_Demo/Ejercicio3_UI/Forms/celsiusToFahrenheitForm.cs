using Ejercicio3Library;
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
    public partial class celsiusToFahrenheitForm : Form
    {
        public celsiusToFahrenheitForm()
        {
            InitializeComponent();
        }

        private void convertirCelsiusFahrenheitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(celsiusFahrenheitTextBox.Text) && double.TryParse(celsiusFahrenheitTextBox.Text, out double n)){

                Conversion celsius = new Conversion();
                celsius.Grados = double.Parse(celsiusFahrenheitTextBox.Text);
                double fahrenheit = (celsius.Grados * 1.8) + 32;
                resultadoCelsiusFahrenheitLabel.Text = $"La conversión a grados Fahrenheit (°F) es {fahrenheit}";
            }
            else
            {
                MessageBox.Show("Solo se permiten números enteros o decimales");
            }
        }
    }
}
