namespace Ejercicio3_UI.Forms
{
    partial class kelvinToFahrenheitForm
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
            resultadoKelvinFahrenheitLabel = new Label();
            convertirKelvinFahrenheitButton = new Button();
            kelvinFahrenheitTextBox = new TextBox();
            indicacionKelvinFahrenheitLabel = new Label();
            titleKelvinFahrenheitLabel = new Label();
            SuspendLayout();
            // 
            // resultadoKelvinFahrenheitLabel
            // 
            resultadoKelvinFahrenheitLabel.AutoSize = true;
            resultadoKelvinFahrenheitLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            resultadoKelvinFahrenheitLabel.Location = new Point(26, 226);
            resultadoKelvinFahrenheitLabel.Name = "resultadoKelvinFahrenheitLabel";
            resultadoKelvinFahrenheitLabel.Size = new Size(456, 21);
            resultadoKelvinFahrenheitLabel.TabIndex = 9;
            resultadoKelvinFahrenheitLabel.Text = "Cuando haya ingresado los grados presione el botón \"convertir\".";
            // 
            // convertirKelvinFahrenheitButton
            // 
            convertirKelvinFahrenheitButton.FlatStyle = FlatStyle.Popup;
            convertirKelvinFahrenheitButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            convertirKelvinFahrenheitButton.Location = new Point(210, 162);
            convertirKelvinFahrenheitButton.Name = "convertirKelvinFahrenheitButton";
            convertirKelvinFahrenheitButton.Size = new Size(100, 30);
            convertirKelvinFahrenheitButton.TabIndex = 8;
            convertirKelvinFahrenheitButton.Text = "convertir";
            convertirKelvinFahrenheitButton.UseVisualStyleBackColor = true;
            convertirKelvinFahrenheitButton.Click += convertirKelvinFahrenheitButton_Click;
            // 
            // kelvinFahrenheitTextBox
            // 
            kelvinFahrenheitTextBox.BorderStyle = BorderStyle.FixedSingle;
            kelvinFahrenheitTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            kelvinFahrenheitTextBox.Location = new Point(210, 110);
            kelvinFahrenheitTextBox.Name = "kelvinFahrenheitTextBox";
            kelvinFahrenheitTextBox.Size = new Size(100, 29);
            kelvinFahrenheitTextBox.TabIndex = 7;
            // 
            // indicacionKelvinFahrenheitLabel
            // 
            indicacionKelvinFahrenheitLabel.AutoSize = true;
            indicacionKelvinFahrenheitLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            indicacionKelvinFahrenheitLabel.Location = new Point(107, 66);
            indicacionKelvinFahrenheitLabel.Name = "indicacionKelvinFahrenheitLabel";
            indicacionKelvinFahrenheitLabel.Size = new Size(289, 21);
            indicacionKelvinFahrenheitLabel.TabIndex = 6;
            indicacionKelvinFahrenheitLabel.Text = "Ingrese la temperatura en grados Kelvin:";
            // 
            // titleKelvinFahrenheitLabel
            // 
            titleKelvinFahrenheitLabel.AutoSize = true;
            titleKelvinFahrenheitLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleKelvinFahrenheitLabel.Location = new Point(64, 26);
            titleKelvinFahrenheitLabel.Name = "titleKelvinFahrenheitLabel";
            titleKelvinFahrenheitLabel.Size = new Size(370, 25);
            titleKelvinFahrenheitLabel.TabIndex = 5;
            titleKelvinFahrenheitLabel.Text = "Conversor de grados Kelvin a Fahrenheit";
            // 
            // kelvinToFahrenheitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 280);
            Controls.Add(resultadoKelvinFahrenheitLabel);
            Controls.Add(convertirKelvinFahrenheitButton);
            Controls.Add(kelvinFahrenheitTextBox);
            Controls.Add(indicacionKelvinFahrenheitLabel);
            Controls.Add(titleKelvinFahrenheitLabel);
            Name = "kelvinToFahrenheitForm";
            Text = "kelvinToFahrenheitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultadoKelvinFahrenheitLabel;
        private Button convertirKelvinFahrenheitButton;
        private TextBox kelvinFahrenheitTextBox;
        private Label indicacionKelvinFahrenheitLabel;
        private Label titleKelvinFahrenheitLabel;
    }
}