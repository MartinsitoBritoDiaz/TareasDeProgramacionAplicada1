namespace EjerciciosLibroProgramadorTotal.Tarea3
{
    partial class Ejercicio5Form
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
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NumeroTextBox = new System.Windows.Forms.TextBox();
            this.CursoTextBox = new System.Windows.Forms.TextBox();
            this.EdadTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.CursoLabel = new System.Windows.Forms.Label();
            this.EdadLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(181, 334);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(126, 58);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NumeroTextBox
            // 
            this.NumeroTextBox.Location = new System.Drawing.Point(180, 264);
            this.NumeroTextBox.Name = "NumeroTextBox";
            this.NumeroTextBox.Size = new System.Drawing.Size(328, 22);
            this.NumeroTextBox.TabIndex = 21;
            // 
            // CursoTextBox
            // 
            this.CursoTextBox.Location = new System.Drawing.Point(180, 212);
            this.CursoTextBox.Name = "CursoTextBox";
            this.CursoTextBox.Size = new System.Drawing.Size(327, 22);
            this.CursoTextBox.TabIndex = 20;
            // 
            // EdadTextBox
            // 
            this.EdadTextBox.Location = new System.Drawing.Point(180, 157);
            this.EdadTextBox.Name = "EdadTextBox";
            this.EdadTextBox.Size = new System.Drawing.Size(326, 22);
            this.EdadTextBox.TabIndex = 19;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(180, 109);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(328, 22);
            this.NombreTextBox.TabIndex = 18;
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroLabel.Location = new System.Drawing.Point(58, 268);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(62, 18);
            this.NumeroLabel.TabIndex = 16;
            this.NumeroLabel.Text = "Numero";
            // 
            // CursoLabel
            // 
            this.CursoLabel.AutoSize = true;
            this.CursoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CursoLabel.Location = new System.Drawing.Point(58, 212);
            this.CursoLabel.Name = "CursoLabel";
            this.CursoLabel.Size = new System.Drawing.Size(49, 18);
            this.CursoLabel.TabIndex = 15;
            this.CursoLabel.Text = "Curso";
            // 
            // EdadLabel
            // 
            this.EdadLabel.AutoSize = true;
            this.EdadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdadLabel.Location = new System.Drawing.Point(58, 157);
            this.EdadLabel.Name = "EdadLabel";
            this.EdadLabel.Size = new System.Drawing.Size(42, 18);
            this.EdadLabel.TabIndex = 14;
            this.EdadLabel.Text = "Edad";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(58, 109);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(62, 18);
            this.NombreLabel.TabIndex = 13;
            this.NombreLabel.Text = "Nombre";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(111, 23);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(370, 50);
            this.TituloLabel.TabIndex = 12;
            this.TituloLabel.Text = "Crear una clase para llevar la información\r\nde los estudiantes de una escuela.";
            // 
            // Ejercicio5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 428);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NumeroTextBox);
            this.Controls.Add(this.CursoTextBox);
            this.Controls.Add(this.EdadTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NumeroLabel);
            this.Controls.Add(this.CursoLabel);
            this.Controls.Add(this.EdadLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.TituloLabel);
            this.Name = "Ejercicio5Form";
            this.Text = "Ejercicio5Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox NumeroTextBox;
        private System.Windows.Forms.TextBox CursoTextBox;
        private System.Windows.Forms.TextBox EdadTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label NumeroLabel;
        private System.Windows.Forms.Label CursoLabel;
        private System.Windows.Forms.Label EdadLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label TituloLabel;
    }
}