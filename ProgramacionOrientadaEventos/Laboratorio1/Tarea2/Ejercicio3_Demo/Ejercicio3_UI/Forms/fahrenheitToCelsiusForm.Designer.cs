namespace Ejercicio3_UI.Forms
{
    partial class fahrenheitToCelsiusForm
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
            resultadoFahrenheitCelsiusLabel = new Label();
            convertirFahrenheitCelsiusButton = new Button();
            fahrenheitCelsiusTextBox = new TextBox();
            indicacionFahrenheitCelsiusLabel = new Label();
            titleFahrenheitCelsiusLabel = new Label();
            SuspendLayout();
            // 
            // resultadoFahrenheitCelsiusLabel
            // 
            resultadoFahrenheitCelsiusLabel.AutoSize = true;
            resultadoFahrenheitCelsiusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoFahrenheitCelsiusLabel.Location = new Point(28, 219);
            resultadoFahrenheitCelsiusLabel.Name = "resultadoFahrenheitCelsiusLabel";
            resultadoFahrenheitCelsiusLabel.Size = new Size(456, 21);
            resultadoFahrenheitCelsiusLabel.TabIndex = 9;
            resultadoFahrenheitCelsiusLabel.Text = "Cuando haya ingresado los grados presione el botón \"convertir\".";
            // 
            // convertirFahrenheitCelsiusButton
            // 
            convertirFahrenheitCelsiusButton.FlatStyle = FlatStyle.Popup;
            convertirFahrenheitCelsiusButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            convertirFahrenheitCelsiusButton.Location = new Point(212, 155);
            convertirFahrenheitCelsiusButton.Name = "convertirFahrenheitCelsiusButton";
            convertirFahrenheitCelsiusButton.Size = new Size(100, 30);
            convertirFahrenheitCelsiusButton.TabIndex = 8;
            convertirFahrenheitCelsiusButton.Text = "convertir";
            convertirFahrenheitCelsiusButton.UseVisualStyleBackColor = true;
            convertirFahrenheitCelsiusButton.Click += convertirFahrenheitCelsiusButton_Click;
            // 
            // fahrenheitCelsiusTextBox
            // 
            fahrenheitCelsiusTextBox.BorderStyle = BorderStyle.FixedSingle;
            fahrenheitCelsiusTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fahrenheitCelsiusTextBox.Location = new Point(212, 103);
            fahrenheitCelsiusTextBox.Name = "fahrenheitCelsiusTextBox";
            fahrenheitCelsiusTextBox.Size = new Size(100, 29);
            fahrenheitCelsiusTextBox.TabIndex = 7;
            // 
            // indicacionFahrenheitCelsiusLabel
            // 
            indicacionFahrenheitCelsiusLabel.AutoSize = true;
            indicacionFahrenheitCelsiusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionFahrenheitCelsiusLabel.Location = new Point(95, 61);
            indicacionFahrenheitCelsiusLabel.Name = "indicacionFahrenheitCelsiusLabel";
            indicacionFahrenheitCelsiusLabel.Size = new Size(320, 21);
            indicacionFahrenheitCelsiusLabel.TabIndex = 6;
            indicacionFahrenheitCelsiusLabel.Text = "Ingrese la temperatura en grados Fahrenheit:";
            // 
            // titleFahrenheitCelsiusLabel
            // 
            titleFahrenheitCelsiusLabel.AutoSize = true;
            titleFahrenheitCelsiusLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleFahrenheitCelsiusLabel.Location = new Point(66, 19);
            titleFahrenheitCelsiusLabel.Name = "titleFahrenheitCelsiusLabel";
            titleFahrenheitCelsiusLabel.Size = new Size(376, 25);
            titleFahrenheitCelsiusLabel.TabIndex = 5;
            titleFahrenheitCelsiusLabel.Text = "Conversor de grados Fahrenheit a Celsius";
            // 
            // fahrenheitToCelsiusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 272);
            Controls.Add(resultadoFahrenheitCelsiusLabel);
            Controls.Add(convertirFahrenheitCelsiusButton);
            Controls.Add(fahrenheitCelsiusTextBox);
            Controls.Add(indicacionFahrenheitCelsiusLabel);
            Controls.Add(titleFahrenheitCelsiusLabel);
            Name = "fahrenheitToCelsiusForm";
            Text = "fahrenheitToCelsiusForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultadoFahrenheitCelsiusLabel;
        private Button convertirFahrenheitCelsiusButton;
        private TextBox fahrenheitCelsiusTextBox;
        private Label indicacionFahrenheitCelsiusLabel;
        private Label titleFahrenheitCelsiusLabel;
    }
}