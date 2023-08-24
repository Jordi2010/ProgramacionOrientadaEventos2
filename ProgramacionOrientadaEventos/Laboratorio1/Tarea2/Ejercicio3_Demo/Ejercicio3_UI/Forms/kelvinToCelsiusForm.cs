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
    public partial class kelvinToCelsiusForm : Form
    {
        public kelvinToCelsiusForm()
        {
            InitializeComponent();
        }

        private void convertirKelvinCelsiusButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kelvinCelsiusTextBox.Text) && double.TryParse(kelvinCelsiusTextBox.Text, out double n))
            {
                Conversion kelvin = new Conversion();
                kelvin.Grados = double.Parse(kelvinCelsiusTextBox.Text);
                double celsius = (kelvin.Grados - 273.15);
                resultadoKelvinCelsiusLabel.Text = $"La conversión a grados Celsius (°C) es {celsius}";
            }
            else
            {
                MessageBox.Show("Solo se permiten números enteros o decimales");
            }
        }
    }
}
