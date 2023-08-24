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
    public partial class celsiusToKelvinForm : Form
    {
        public celsiusToKelvinForm()
        {
            InitializeComponent();
        }

        private void convertirCelsiusKelvinButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(celsiusKelvinTextBox.Text) && double.TryParse(celsiusKelvinTextBox.Text, out double n))
            {
                Conversion celsius = new Conversion();
                celsius.Grados = double.Parse(celsiusKelvinTextBox.Text);
                double kelvin = (celsius.Grados + 273.15);
                resultadoCelsiusKelvinLabel.Text = $"La conversión a grados Kelvin (°K) es {kelvin}";
            }
            else
            {
                MessageBox.Show("Solo se permiten números enteros o decimales");
            }
        }
    }
}
