namespace Ejercicio3_UI.Forms
{
    partial class celsiusToFahrenheitForm
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
            titleCelsiusFahrenheitLabel = new Label();
            indicacionCelsiusFahrenheitLabel = new Label();
            celsiusFahrenheitTextBox = new TextBox();
            convertirCelsiusFahrenheitButton = new Button();
            resultadoCelsiusFahrenheitLabel = new Label();
            SuspendLayout();
            // 
            // titleCelsiusFahrenheitLabel
            // 
            titleCelsiusFahrenheitLabel.AutoSize = true;
            titleCelsiusFahrenheitLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleCelsiusFahrenheitLabel.Location = new Point(67, 18);
            titleCelsiusFahrenheitLabel.Name = "titleCelsiusFahrenheitLabel";
            titleCelsiusFahrenheitLabel.Size = new Size(376, 25);
            titleCelsiusFahrenheitLabel.TabIndex = 0;
            titleCelsiusFahrenheitLabel.Text = "Conversor de grados Celsius a Fahrenheit";
            // 
            // indicacionCelsiusFahrenheitLabel
            // 
            indicacionCelsiusFahrenheitLabel.AutoSize = true;
            indicacionCelsiusFahrenheitLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionCelsiusFahrenheitLabel.Location = new Point(113, 58);
            indicacionCelsiusFahrenheitLabel.Name = "indicacionCelsiusFahrenheitLabel";
            indicacionCelsiusFahrenheitLabel.Size = new Size(296, 21);
            indicacionCelsiusFahrenheitLabel.TabIndex = 1;
            indicacionCelsiusFahrenheitLabel.Text = "Ingrese la temperatura en grados Celsius:";
            // 
            // celsiusFahrenheitTextBox
            // 
            celsiusFahrenheitTextBox.BorderStyle = BorderStyle.FixedSingle;
            celsiusFahrenheitTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            celsiusFahrenheitTextBox.Location = new Point(213, 102);
            celsiusFahrenheitTextBox.Name = "celsiusFahrenheitTextBox";
            celsiusFahrenheitTextBox.Size = new Size(100, 29);
            celsiusFahrenheitTextBox.TabIndex = 2;
            // 
            // convertirCelsiusFahrenheitButton
            // 
            convertirCelsiusFahrenheitButton.FlatStyle = FlatStyle.Popup;
            convertirCelsiusFahrenheitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            convertirCelsiusFahrenheitButton.Location = new Point(213, 154);
            convertirCelsiusFahrenheitButton.Name = "convertirCelsiusFahrenheitButton";
            convertirCelsiusFahrenheitButton.Size = new Size(100, 30);
            convertirCelsiusFahrenheitButton.TabIndex = 3;
            convertirCelsiusFahrenheitButton.Text = "convertir";
            convertirCelsiusFahrenheitButton.UseVisualStyleBackColor = true;
            convertirCelsiusFahrenheitButton.Click += convertirCelsiusFahrenheitButton_Click;
            // 
            // resultadoCelsiusFahrenheitLabel
            // 
            resultadoCelsiusFahrenheitLabel.AutoSize = true;
            resultadoCelsiusFahrenheitLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoCelsiusFahrenheitLabel.Location = new Point(29, 218);
            resultadoCelsiusFahrenheitLabel.Name = "resultadoCelsiusFahrenheitLabel";
            resultadoCelsiusFahrenheitLabel.Size = new Size(456, 21);
            resultadoCelsiusFahrenheitLabel.TabIndex = 4;
            resultadoCelsiusFahrenheitLabel.Text = "Cuando haya ingresado los grados presione el botón \"convertir\".";
            // 
            // celsiusToFahrenheitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 270);
            Controls.Add(resultadoCelsiusFahrenheitLabel);
            Controls.Add(convertirCelsiusFahrenheitButton);
            Controls.Add(celsiusFahrenheitTextBox);
            Controls.Add(indicacionCelsiusFahrenheitLabel);
            Controls.Add(titleCelsiusFahrenheitLabel);
            Name = "celsiusToFahrenheitForm";
            Text = "celsiusToFahrenheitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleCelsiusFahrenheitLabel;
        private Label indicacionCelsiusFahrenheitLabel;
        private TextBox celsiusFahrenheitTextBox;
        private Button convertirCelsiusFahrenheitButton;
        private Label resultadoCelsiusFahrenheitLabel;
    }
}