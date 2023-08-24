namespace Ejercicio3_UI.Forms
{
    partial class fahrenheitToKelvinForm
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
            resultadoFahrenheitKelvinLabel = new Label();
            convertirFahrenheitKelvinButton = new Button();
            fahrenheitKelvinTextBox = new TextBox();
            indicacionFahrenheitKelvinLabel = new Label();
            titleFahrenheitKelvinLabel = new Label();
            SuspendLayout();
            // 
            // resultadoFahrenheitKelvinLabel
            // 
            resultadoFahrenheitKelvinLabel.AutoSize = true;
            resultadoFahrenheitKelvinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoFahrenheitKelvinLabel.Location = new Point(29, 225);
            resultadoFahrenheitKelvinLabel.Name = "resultadoFahrenheitKelvinLabel";
            resultadoFahrenheitKelvinLabel.Size = new Size(456, 21);
            resultadoFahrenheitKelvinLabel.TabIndex = 14;
            resultadoFahrenheitKelvinLabel.Text = "Cuando haya ingresado los grados presione el botón \"convertir\".";
            // 
            // convertirFahrenheitKelvinButton
            // 
            convertirFahrenheitKelvinButton.FlatStyle = FlatStyle.Popup;
            convertirFahrenheitKelvinButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            convertirFahrenheitKelvinButton.Location = new Point(213, 161);
            convertirFahrenheitKelvinButton.Name = "convertirFahrenheitKelvinButton";
            convertirFahrenheitKelvinButton.Size = new Size(100, 30);
            convertirFahrenheitKelvinButton.TabIndex = 13;
            convertirFahrenheitKelvinButton.Text = "convertir";
            convertirFahrenheitKelvinButton.UseVisualStyleBackColor = true;
            convertirFahrenheitKelvinButton.Click += convertirFahrenheitKelvinButton_Click;
            // 
            // fahrenheitKelvinTextBox
            // 
            fahrenheitKelvinTextBox.BorderStyle = BorderStyle.FixedSingle;
            fahrenheitKelvinTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            fahrenheitKelvinTextBox.Location = new Point(213, 109);
            fahrenheitKelvinTextBox.Name = "fahrenheitKelvinTextBox";
            fahrenheitKelvinTextBox.Size = new Size(100, 29);
            fahrenheitKelvinTextBox.TabIndex = 12;
            // 
            // indicacionFahrenheitKelvinLabel
            // 
            indicacionFahrenheitKelvinLabel.AutoSize = true;
            indicacionFahrenheitKelvinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionFahrenheitKelvinLabel.Location = new Point(96, 64);
            indicacionFahrenheitKelvinLabel.Name = "indicacionFahrenheitKelvinLabel";
            indicacionFahrenheitKelvinLabel.Size = new Size(320, 21);
            indicacionFahrenheitKelvinLabel.TabIndex = 11;
            indicacionFahrenheitKelvinLabel.Text = "Ingrese la temperatura en grados Fahrenheit:";
            // 
            // titleFahrenheitKelvinLabel
            // 
            titleFahrenheitKelvinLabel.AutoSize = true;
            titleFahrenheitKelvinLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleFahrenheitKelvinLabel.Location = new Point(67, 25);
            titleFahrenheitKelvinLabel.Name = "titleFahrenheitKelvinLabel";
            titleFahrenheitKelvinLabel.Size = new Size(370, 25);
            titleFahrenheitKelvinLabel.TabIndex = 10;
            titleFahrenheitKelvinLabel.Text = "Conversor de grados Fahrenheit a Kelvin";
            // 
            // fahrenheitToKelvinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 274);
            Controls.Add(resultadoFahrenheitKelvinLabel);
            Controls.Add(convertirFahrenheitKelvinButton);
            Controls.Add(fahrenheitKelvinTextBox);
            Controls.Add(indicacionFahrenheitKelvinLabel);
            Controls.Add(titleFahrenheitKelvinLabel);
            Name = "fahrenheitToKelvinForm";
            Text = "fahrenheitToKelvinForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultadoFahrenheitKelvinLabel;
        private Button convertirFahrenheitKelvinButton;
        private TextBox fahrenheitKelvinTextBox;
        private Label indicacionFahrenheitKelvinLabel;
        private Label titleFahrenheitKelvinLabel;
    }
}