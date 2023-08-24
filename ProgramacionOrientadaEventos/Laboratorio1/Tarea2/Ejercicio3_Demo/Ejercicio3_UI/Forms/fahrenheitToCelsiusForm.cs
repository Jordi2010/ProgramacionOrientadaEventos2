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
    public partial class fahrenheitToCelsiusForm : Form
    {
        public fahrenheitToCelsiusForm()
        {
            InitializeComponent();
        }

        private void convertirFahrenheitCelsiusButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(fahrenheitCelsiusTextBox.Text) && double.TryParse(fahrenheitCelsiusTextBox.Text, out double n))
            {
                Conversion fahrenheit = new Conversion();
                fahrenheit.Grados = double.Parse(fahrenheitCelsiusTextBox.Text);
                double celsius = (fahrenheit.Grados - 32) / 1.8;
                resultadoFahrenheitCelsiusLabel.Text = $"La conversión a grados Celsius (°C) es {celsius}";
            }
            else
            {
                MessageBox.Show("Solo se permiten números enteros o decimales");
            }
        }
    }
}
