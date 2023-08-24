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
    public partial class fahrenheitToKelvinForm : Form
    {
        public fahrenheitToKelvinForm()
        {
            InitializeComponent();
        }

        private void convertirFahrenheitKelvinButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fahrenheitKelvinTextBox.Text) && double.TryParse(fahrenheitKelvinTextBox.Text, out double n))
            {
                Conversion fahrenheit = new Conversion();
                fahrenheit.Grados = double.Parse(fahrenheitKelvinTextBox.Text);
                double kelvin = (5 / 9) * (fahrenheit.Grados - 32) + 273.15;
                resultadoFahrenheitKelvinLabel.Text = $"La conversión a grados Kelvin (°K) es {kelvin}";
            }
            else
            {
                MessageBox.Show("Solo se permiten números enteros o decimales");
            }
        }
    }
}
