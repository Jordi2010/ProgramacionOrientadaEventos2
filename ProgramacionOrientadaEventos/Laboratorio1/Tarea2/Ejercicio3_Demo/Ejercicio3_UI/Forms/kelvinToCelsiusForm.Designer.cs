namespace Ejercicio3_UI.Forms
{
    partial class kelvinToCelsiusForm
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
            resultadoKelvinCelsiusLabel = new Label();
            convertirKelvinCelsiusButton = new Button();
            kelvinCelsiusTextBox = new TextBox();
            indicacionKelvinCelsiusLabel = new Label();
            titleKelvinCelsiusLabel = new Label();
            SuspendLayout();
            // 
            // resultadoKelvinCelsiusLabel
            // 
            resultadoKelvinCelsiusLabel.AutoSize = true;
            resultadoKelvinCelsiusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoKelvinCelsiusLabel.Location = new Point(28, 222);
            resultadoKelvinCelsiusLabel.Name = "resultadoKelvinCelsiusLabel";
            resultadoKelvinCelsiusLabel.Size = new Size(456, 21);
            resultadoKelvinCelsiusLabel.TabIndex = 14;
            resultadoKelvinCelsiusLabel.Text = "Cuando haya ingresado los grados presione el botón \"convertir\".";
            // 
            // convertirKelvinCelsiusButton
            // 
            convertirKelvinCelsiusButton.FlatStyle = FlatStyle.Popup;
            convertirKelvinCelsiusButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            convertirKelvinCelsiusButton.Location = new Point(212, 158);
            convertirKelvinCelsiusButton.Name = "convertirKelvinCelsiusButton";
            convertirKelvinCelsiusButton.Size = new Size(100, 30);
            convertirKelvinCelsiusButton.TabIndex = 13;
            convertirKelvinCelsiusButton.Text = "convertir";
            convertirKelvinCelsiusButton.UseVisualStyleBackColor = true;
            convertirKelvinCelsiusButton.Click += convertirKelvinCelsiusButton_Click;
            // 
            // kelvinCelsiusTextBox
            // 
            kelvinCelsiusTextBox.BorderStyle = BorderStyle.FixedSingle;
            kelvinCelsiusTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kelvinCelsiusTextBox.Location = new Point(212, 106);
            kelvinCelsiusTextBox.Name = "kelvinCelsiusTextBox";
            kelvinCelsiusTextBox.Size = new Size(100, 29);
            kelvinCelsiusTextBox.TabIndex = 12;
            // 
            // indicacionKelvinCelsiusLabel
            // 
            indicacionKelvinCelsiusLabel.AutoSize = true;
            indicacionKelvinCelsiusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionKelvinCelsiusLabel.Location = new Point(108, 62);
            indicacionKelvinCelsiusLabel.Name = "indicacionKelvinCelsiusLabel";
            indicacionKelvinCelsiusLabel.Size = new Size(289, 21);
            indicacionKelvinCelsiusLabel.TabIndex = 11;
            indicacionKelvinCelsiusLabel.Text = "Ingrese la temperatura en grados Kelvin:";
            // 
            // titleKelvinCelsiusLabel
            // 
            titleKelvinCelsiusLabel.AutoSize = true;
            titleKelvinCelsiusLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleKelvinCelsiusLabel.Location = new Point(85, 22);
            titleKelvinCelsiusLabel.Name = "titleKelvinCelsiusLabel";
            titleKelvinCelsiusLabel.Size = new Size(337, 25);
            titleKelvinCelsiusLabel.TabIndex = 10;
            titleKelvinCelsiusLabel.Text = "Conversor de grados Kelvin a Celsius";
            // 
            // kelvinToCelsiusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 276);
            Controls.Add(resultadoKelvinCelsiusLabel);
            Controls.Add(convertirKelvinCelsiusButton);
            Controls.Add(kelvinCelsiusTextBox);
            Controls.Add(indicacionKelvinCelsiusLabel);
            Controls.Add(titleKelvinCelsiusLabel);
            Name = "kelvinToCelsiusForm";
            Text = "kelvinToCelsiusForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultadoKelvinCelsiusLabel;
        private Button convertirKelvinCelsiusButton;
        private TextBox kelvinCelsiusTextBox;
        private Label indicacionKelvinCelsiusLabel;
        private Label titleKelvinCelsiusLabel;
    }
}