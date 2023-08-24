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
    public partial class kelvinToFahrenheitForm : Form
    {
        public kelvinToFahrenheitForm()
        {
            InitializeComponent();
        }

        private void convertirKelvinFahrenheitButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kelvinFahrenheitTextBox.Text) && double.TryParse(kelvinFahrenheitTextBox.Text, out double n))
            {
                Conversion kelvin = new Conversion();
                kelvin.Grados = double.Parse(kelvinFahrenheitTextBox.Text);
                double fahrenheit = 1.8 * (kelvin.Grados - 273.15) + 32;
                resultadoKelvinFahrenheitLabel.Text = $"La conversión a grados Fahrenheit (°F) es {fahrenheit}";
            }
            else
            {
                MessageBox.Show("Solo se permiten números enteros o decimales");
            }
        }
    }
}
