namespace Ejercicio3_UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ejercicio3Label = new Label();
            indicacionEjercicio3Label = new Label();
            tipoConversionGroupBox = new GroupBox();
            fahrenheitToKelvinButton = new Button();
            celsiusToFahrenheitButton = new Button();
            kelvinToCelsiusButton = new Button();
            fahrenheitToCelsiusButton = new Button();
            celsiusToKelvinButton = new Button();
            kelvinToFahrenheitButton = new Button();
            tipoConversionGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ejercicio3Label
            // 
            ejercicio3Label.AutoSize = true;
            ejercicio3Label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ejercicio3Label.Location = new Point(72, 22);
            ejercicio3Label.Name = "ejercicio3Label";
            ejercicio3Label.Size = new Size(409, 30);
            ejercicio3Label.TabIndex = 0;
            ejercicio3Label.Text = "EJERCICIO 3 - Conversor de temperatura";
            // 
            // indicacionEjercicio3Label
            // 
            indicacionEjercicio3Label.AutoSize = true;
            indicacionEjercicio3Label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionEjercicio3Label.Location = new Point(21, 71);
            indicacionEjercicio3Label.Name = "indicacionEjercicio3Label";
            indicacionEjercicio3Label.Size = new Size(517, 25);
            indicacionEjercicio3Label.TabIndex = 1;
            indicacionEjercicio3Label.Text = "Seleccione la conversión de temperatura que desea realizar:";
            // 
            // tipoConversionGroupBox
            // 
            tipoConversionGroupBox.Controls.Add(fahrenheitToKelvinButton);
            tipoConversionGroupBox.Controls.Add(celsiusToFahrenheitButton);
            tipoConversionGroupBox.Controls.Add(kelvinToCelsiusButton);
            tipoConversionGroupBox.Controls.Add(fahrenheitToCelsiusButton);
            tipoConversionGroupBox.Controls.Add(celsiusToKelvinButton);
            tipoConversionGroupBox.Controls.Add(kelvinToFahrenheitButton);
            tipoConversionGroupBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tipoConversionGroupBox.Location = new Point(50, 108);
            tipoConversionGroupBox.Name = "tipoConversionGroupBox";
            tipoConversionGroupBox.Size = new Size(460, 192);
            tipoConversionGroupBox.TabIndex = 2;
            tipoConversionGroupBox.TabStop = false;
            // 
            // fahrenheitToKelvinButton
            // 
            fahrenheitToKelvinButton.FlatStyle = FlatStyle.Flat;
            fahrenheitToKelvinButton.Location = new Point(242, 127);
            fahrenheitToKelvinButton.Name = "fahrenheitToKelvinButton";
            fahrenheitToKelvinButton.Size = new Size(200, 32);
            fahrenheitToKelvinButton.TabIndex = 5;
            fahrenheitToKelvinButton.Text = "Fahrenheit a Kelvin";
            fahrenheitToKelvinButton.UseVisualStyleBackColor = true;
            fahrenheitToKelvinButton.Click += fahrenheitToKelvinButton_Click;
            // 
            // celsiusToFahrenheitButton
            // 
            celsiusToFahrenheitButton.FlatStyle = FlatStyle.Flat;
            celsiusToFahrenheitButton.Location = new Point(18, 32);
            celsiusToFahrenheitButton.Name = "celsiusToFahrenheitButton";
            celsiusToFahrenheitButton.Size = new Size(200, 32);
            celsiusToFahrenheitButton.TabIndex = 0;
            celsiusToFahrenheitButton.Text = "Celsius a Fahrenheit";
            celsiusToFahrenheitButton.UseVisualStyleBackColor = true;
            celsiusToFahrenheitButton.Click += celsiusToFahrenheitButton_Click;
            // 
            // kelvinToCelsiusButton
            // 
            kelvinToCelsiusButton.FlatStyle = FlatStyle.Flat;
            kelvinToCelsiusButton.Location = new Point(18, 79);
            kelvinToCelsiusButton.Name = "kelvinToCelsiusButton";
            kelvinToCelsiusButton.Size = new Size(200, 32);
            kelvinToCelsiusButton.TabIndex = 2;
            kelvinToCelsiusButton.Text = "Kelvin a Celsius";
            kelvinToCelsiusButton.UseVisualStyleBackColor = true;
            kelvinToCelsiusButton.Click += kelvinToCelsiusButton_Click;
            // 
            // fahrenheitToCelsiusButton
            // 
            fahrenheitToCelsiusButton.FlatStyle = FlatStyle.Flat;
            fahrenheitToCelsiusButton.Location = new Point(242, 32);
            fahrenheitToCelsiusButton.Name = "fahrenheitToCelsiusButton";
            fahrenheitToCelsiusButton.Size = new Size(200, 32);
            fahrenheitToCelsiusButton.TabIndex = 1;
            fahrenheitToCelsiusButton.Text = "Fahrenheit a Celsius";
            fahrenheitToCelsiusButton.UseVisualStyleBackColor = true;
            fahrenheitToCelsiusButton.Click += fahrenheitToCelsiusButton_Click;
            // 
            // celsiusToKelvinButton
            // 
            celsiusToKelvinButton.FlatStyle = FlatStyle.Flat;
            celsiusToKelvinButton.Location = new Point(242, 79);
            celsiusToKelvinButton.Name = "celsiusToKelvinButton";
            celsiusToKelvinButton.Size = new Size(200, 32);
            celsiusToKelvinButton.TabIndex = 3;
            celsiusToKelvinButton.Text = "Celsius a Kelvin";
            celsiusToKelvinButton.UseVisualStyleBackColor = true;
            celsiusToKelvinButton.Click += celsiusToKelvinButton_Click;
            // 
            // kelvinToFahrenheitButton
            // 
            kelvinToFahrenheitButton.FlatStyle = FlatStyle.Flat;
            kelvinToFahrenheitButton.Location = new Point(18, 127);
            kelvinToFahrenheitButton.Name = "kelvinToFahrenheitButton";
            kelvinToFahrenheitButton.Size = new Size(200, 32);
            kelvinToFahrenheitButton.TabIndex = 4;
            kelvinToFahrenheitButton.Text = "Kelvin a Fahrenheit";
            kelvinToFahrenheitButton.UseVisualStyleBackColor = true;
            kelvinToFahrenheitButton.Click += kelvinToFahrenheitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 335);
            Controls.Add(tipoConversionGroupBox);
            Controls.Add(indicacionEjercicio3Label);
            Controls.Add(ejercicio3Label);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            tipoConversionGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ejercicio3Label;
        private Label indicacionEjercicio3Label;
        private GroupBox tipoConversionGroupBox;
        private Button fahrenheitToCelsiusButton;
        private Button celsiusToFahrenheitButton;
        private Button fahrenheitToKelvinButton;
        private Button kelvinToFahrenheitButton;
        private Button celsiusToKelvinButton;
        private Button kelvinToCelsiusButton;
    }
}