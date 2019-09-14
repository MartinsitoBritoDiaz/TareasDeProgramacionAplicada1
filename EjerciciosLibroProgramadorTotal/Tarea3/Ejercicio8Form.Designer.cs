namespace EjerciciosLibroProgramadorTotal.Tarea3
{
    partial class Ejercicio8Form
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
            this.TituloLabel = new System.Windows.Forms.Label();
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.FactorialLabel = new System.Windows.Forms.Label();
            this.FactorialTextBox = new System.Windows.Forms.TextBox();
            this.CalcularButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(76, 31);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(331, 75);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Usar la depuración paso a paso para\r\nobservar cómo cambia el valor de la\r\nvariabl" +
    "e en el programa del factorial";
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroLabel.Location = new System.Drawing.Point(60, 196);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(68, 20);
            this.NumeroLabel.TabIndex = 1;
            this.NumeroLabel.Text = "Numero";
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(172, 196);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(235, 22);
            this.NumeroTextBox.TabIndex = 2;
            // 
            // FactorialLabel
            // 
            this.FactorialLabel.AutoSize = true;
            this.FactorialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactorialLabel.Location = new System.Drawing.Point(60, 277);
            this.FactorialLabel.Name = "FactorialLabel";
            this.FactorialLabel.Size = new System.Drawing.Size(74, 20);
            this.FactorialLabel.TabIndex = 3;
            this.FactorialLabel.Text = "Factorial";
            // 
            // FactorialTextBox
            // 
            this.FactorialTextBox.Location = new System.Drawing.Point(172, 277);
            this.FactorialTextBox.Name = "FactorialTextBox";
            this.FactorialTextBox.ReadOnly = true;
            this.FactorialTextBox.Size = new System.Drawing.Size(235, 22);
            this.FactorialTextBox.TabIndex = 4;
            // 
            // CalcularButton
            // 
            this.CalcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularButton.Location = new System.Drawing.Point(187, 360);
            this.CalcularButton.Name = "CalcularButton";
            this.CalcularButton.Size = new System.Drawing.Size(125, 48);
            this.CalcularButton.TabIndex = 5;
            this.CalcularButton.Text = "Calcular";
            this.CalcularButton.UseVisualStyleBackColor = true;
            this.CalcularButton.Click += new System.EventHandler(this.CalcularButton_Click);
            // 
            // Ejercicio8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.CalcularButton);
            this.Controls.Add(this.FactorialTextBox);
            this.Controls.Add(this.FactorialLabel);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.NumeroLabel);
            this.Controls.Add(this.TituloLabel);
            this.Name = "Ejercicio8Form";
            this.Text = "Ejercicio8Form";
            this.Load += new System.EventHandler(this.Ejercicio8Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Label NumeroLabel;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.Label FactorialLabel;
        private System.Windows.Forms.TextBox FactorialTextBox;
        private System.Windows.Forms.Button CalcularButton;
    }
}