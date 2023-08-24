namespace Ejercicio3_UI.Forms
{
    partial class celsiusToKelvinForm
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
            resultadoCelsiusKelvinLabel = new Label();
            convertirCelsiusKelvinButton = new Button();
            celsiusKelvinTextBox = new TextBox();
            indicacionCelsiusKelvinLabel = new Label();
            titleCelsiusKelvinLabel = new Label();
            SuspendLayout();
            // 
            // resultadoCelsiusKelvinLabel
            // 
            resultadoCelsiusKelvinLabel.AutoSize = true;
            resultadoCelsiusKelvinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoCelsiusKelvinLabel.Location = new Point(28, 226);
            resultadoCelsiusKelvinLabel.Name = "resultadoCelsiusKelvinLabel";
            resultadoCelsiusKelvinLabel.Size = new Size(456, 21);
            resultadoCelsiusKelvinLabel.TabIndex = 19;
            resultadoCelsiusKelvinLabel.Text = "Cuando haya ingresado los grados presione el botón \"convertir\".";
            // 
            // convertirCelsiusKelvinButton
            // 
            convertirCelsiusKelvinButton.FlatStyle = FlatStyle.Popup;
            convertirCelsiusKelvinButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            convertirCelsiusKelvinButton.Location = new Point(212, 162);
            convertirCelsiusKelvinButton.Name = "convertirCelsiusKelvinButton";
            convertirCelsiusKelvinButton.Size = new Size(100, 30);
            convertirCelsiusKelvinButton.TabIndex = 18;
            convertirCelsiusKelvinButton.Text = "convertir";
            convertirCelsiusKelvinButton.UseVisualStyleBackColor = true;
            convertirCelsiusKelvinButton.Click += convertirCelsiusKelvinButton_Click;
            // 
            // celsiusKelvinTextBox
            // 
            celsiusKelvinTextBox.BorderStyle = BorderStyle.FixedSingle;
            celsiusKelvinTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            celsiusKelvinTextBox.Location = new Point(212, 110);
            celsiusKelvinTextBox.Name = "celsiusKelvinTextBox";
            celsiusKelvinTextBox.Size = new Size(100, 29);
            celsiusKelvinTextBox.TabIndex = 17;
            // 
            // indicacionCelsiusKelvinLabel
            // 
            indicacionCelsiusKelvinLabel.AutoSize = true;
            indicacionCelsiusKelvinLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionCelsiusKelvinLabel.Location = new Point(110, 66);
            indicacionCelsiusKelvinLabel.Name = "indicacionCelsiusKelvinLabel";
            indicacionCelsiusKelvinLabel.Size = new Size(296, 21);
            indicacionCelsiusKelvinLabel.TabIndex = 16;
            indicacionCelsiusKelvinLabel.Text = "Ingrese la temperatura en grados Celsius:";
            // 
            // titleCelsiusKelvinLabel
            // 
            titleCelsiusKelvinLabel.AutoSize = true;
            titleCelsiusKelvinLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleCelsiusKelvinLabel.Location = new Point(88, 26);
            titleCelsiusKelvinLabel.Name = "titleCelsiusKelvinLabel";
            titleCelsiusKelvinLabel.Size = new Size(337, 25);
            titleCelsiusKelvinLabel.TabIndex = 15;
            titleCelsiusKelvinLabel.Text = "Conversor de grados Celsius a Kelvin";
            // 
            // celsiusToKelvinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 275);
            Controls.Add(resultadoCelsiusKelvinLabel);
            Controls.Add(convertirCelsiusKelvinButton);
            Controls.Add(celsiusKelvinTextBox);
            Controls.Add(indicacionCelsiusKelvinLabel);
            Controls.Add(titleCelsiusKelvinLabel);
            Name = "celsiusToKelvinForm";
            Text = "celsiusToKelvinForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultadoCelsiusKelvinLabel;
        private Button convertirCelsiusKelvinButton;
        private TextBox celsiusKelvinTextBox;
        private Label indicacionCelsiusKelvinLabel;
        private Label titleCelsiusKelvinLabel;
    }
}