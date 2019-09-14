namespace EjerciciosLibroProgramadorTotal.Tarea3
{
    partial class Ejercicio2Form
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
            this.MyDataGridView = new System.Windows.Forms.DataGridView();
            this.NombrePersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadPersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CedulaPersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadMasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.CedulaTextBox = new System.Windows.Forms.TextBox();
            this.EdadPersTextBox = new System.Windows.Forms.TextBox();
            this.NombrePersTextBox = new System.Windows.Forms.TextBox();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.EdadLabel = new System.Windows.Forms.Label();
            this.NombrePersLabel = new System.Windows.Forms.Label();
            this.TituloLabel = new System.Windows.Forms.Label();
            this.RazaTextBox = new System.Windows.Forms.TextBox();
            this.EdadMasTextBox = new System.Windows.Forms.TextBox();
            this.NombreMasTextBox = new System.Windows.Forms.TextBox();
            this.RazaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DatosPersLabel = new System.Windows.Forms.Label();
            this.DatosMasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MyDataGridView
            // 
            this.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombrePersColumn,
            this.EdadPersColumn,
            this.CedulaPersColumn,
            this.NombreMasColumn,
            this.EdadMasColumn,
            this.RazaColumn});
            this.MyDataGridView.Location = new System.Drawing.Point(12, 406);
            this.MyDataGridView.Name = "MyDataGridView";
            this.MyDataGridView.RowHeadersWidth = 51;
            this.MyDataGridView.RowTemplate.Height = 24;
            this.MyDataGridView.Size = new System.Drawing.Size(759, 199);
            this.MyDataGridView.TabIndex = 17;
            // 
            // NombrePersColumn
            // 
            this.NombrePersColumn.HeaderText = "Nombre dueño";
            this.NombrePersColumn.MinimumWidth = 6;
            this.NombrePersColumn.Name = "NombrePersColumn";
            this.NombrePersColumn.Width = 125;
            // 
            // EdadPersColumn
            // 
            this.EdadPersColumn.HeaderText = "Edad dueño";
            this.EdadPersColumn.MinimumWidth = 6;
            this.EdadPersColumn.Name = "EdadPersColumn";
            this.EdadPersColumn.Width = 125;
            // 
            // CedulaPersColumn
            // 
            this.CedulaPersColumn.HeaderText = "Cedula";
            this.CedulaPersColumn.MinimumWidth = 6;
            this.CedulaPersColumn.Name = "CedulaPersColumn";
            this.CedulaPersColumn.Width = 125;
            // 
            // NombreMasColumn
            // 
            this.NombreMasColumn.HeaderText = "Nombre mascota";
            this.NombreMasColumn.MinimumWidth = 6;
            this.NombreMasColumn.Name = "NombreMasColumn";
            this.NombreMasColumn.Width = 125;
            // 
            // EdadMasColumn
            // 
            this.EdadMasColumn.HeaderText = "Edad mascota";
            this.EdadMasColumn.MinimumWidth = 6;
            this.EdadMasColumn.Name = "EdadMasColumn";
            this.EdadMasColumn.Width = 125;
            // 
            // RazaColumn
            // 
            this.RazaColumn.HeaderText = "Raza";
            this.RazaColumn.MinimumWidth = 6;
            this.RazaColumn.Name = "RazaColumn";
            this.RazaColumn.Width = 125;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(318, 339);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(116, 40);
            this.GuardarButton.TabIndex = 16;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // CedulaTextBox
            // 
            this.CedulaTextBox.Location = new System.Drawing.Point(142, 275);
            this.CedulaTextBox.Name = "CedulaTextBox";
            this.CedulaTextBox.Size = new System.Drawing.Size(195, 22);
            this.CedulaTextBox.TabIndex = 15;
            // 
            // EdadPersTextBox
            // 
            this.EdadPersTextBox.Location = new System.Drawing.Point(142, 202);
            this.EdadPersTextBox.Name = "EdadPersTextBox";
            this.EdadPersTextBox.Size = new System.Drawing.Size(195, 22);
            this.EdadPersTextBox.TabIndex = 14;
            // 
            // NombrePersTextBox
            // 
            this.NombrePersTextBox.Location = new System.Drawing.Point(142, 141);
            this.NombrePersTextBox.Name = "NombrePersTextBox";
            this.NombrePersTextBox.Size = new System.Drawing.Size(195, 22);
            this.NombrePersTextBox.TabIndex = 13;
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaLabel.Location = new System.Drawing.Point(39, 273);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(61, 20);
            this.CedulaLabel.TabIndex = 12;
            this.CedulaLabel.Text = "Cedula";
            // 
            // EdadLabel
            // 
            this.EdadLabel.AutoSize = true;
            this.EdadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdadLabel.Location = new System.Drawing.Point(39, 206);
            this.EdadLabel.Name = "EdadLabel";
            this.EdadLabel.Size = new System.Drawing.Size(47, 20);
            this.EdadLabel.TabIndex = 11;
            this.EdadLabel.Text = "Edad";
            // 
            // NombrePersLabel
            // 
            this.NombrePersLabel.AutoSize = true;
            this.NombrePersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePersLabel.Location = new System.Drawing.Point(39, 141);
            this.NombrePersLabel.Name = "NombrePersLabel";
            this.NombrePersLabel.Size = new System.Drawing.Size(68, 20);
            this.NombrePersLabel.TabIndex = 10;
            this.NombrePersLabel.Text = "Nombre";
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(71, 22);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(643, 25);
            this.TituloLabel.TabIndex = 9;
            this.TituloLabel.Text = "Crear una estructura para guardar la información de mascota y su dueño.";
            // 
            // RazaTextBox
            // 
            this.RazaTextBox.Location = new System.Drawing.Point(536, 277);
            this.RazaTextBox.Name = "RazaTextBox";
            this.RazaTextBox.Size = new System.Drawing.Size(195, 22);
            this.RazaTextBox.TabIndex = 23;
            // 
            // EdadMasTextBox
            // 
            this.EdadMasTextBox.Location = new System.Drawing.Point(536, 208);
            this.EdadMasTextBox.Name = "EdadMasTextBox";
            this.EdadMasTextBox.Size = new System.Drawing.Size(195, 22);
            this.EdadMasTextBox.TabIndex = 22;
            // 
            // NombreMasTextBox
            // 
            this.NombreMasTextBox.Location = new System.Drawing.Point(536, 143);
            this.NombreMasTextBox.Name = "NombreMasTextBox";
            this.NombreMasTextBox.Size = new System.Drawing.Size(195, 22);
            this.NombreMasTextBox.TabIndex = 21;
            this.NombreMasTextBox.TextChanged += new System.EventHandler(this.NombreMasTextBox_TextChanged);
            // 
            // RazaLabel
            // 
            this.RazaLabel.AutoSize = true;
            this.RazaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RazaLabel.Location = new System.Drawing.Point(433, 275);
            this.RazaLabel.Name = "RazaLabel";
            this.RazaLabel.Size = new System.Drawing.Size(48, 20);
            this.RazaLabel.TabIndex = 20;
            this.RazaLabel.Text = "Raza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre";
            // 
            // DatosPersLabel
            // 
            this.DatosPersLabel.AutoSize = true;
            this.DatosPersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosPersLabel.Location = new System.Drawing.Point(138, 87);
            this.DatosPersLabel.Name = "DatosPersLabel";
            this.DatosPersLabel.Size = new System.Drawing.Size(117, 24);
            this.DatosPersLabel.TabIndex = 24;
            this.DatosPersLabel.Text = "Datos dueño";
            // 
            // DatosMasLabel
            // 
            this.DatosMasLabel.AutoSize = true;
            this.DatosMasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosMasLabel.Location = new System.Drawing.Point(532, 87);
            this.DatosMasLabel.Name = "DatosMasLabel";
            this.DatosMasLabel.Size = new System.Drawing.Size(132, 24);
            this.DatosMasLabel.TabIndex = 25;
            this.DatosMasLabel.Text = "Datos mascota";
            // 
            // Ejercicio2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 617);
            this.Controls.Add(this.DatosMasLabel);
            this.Controls.Add(this.DatosPersLabel);
            this.Controls.Add(this.RazaTextBox);
            this.Controls.Add(this.EdadMasTextBox);
            this.Controls.Add(this.NombreMasTextBox);
            this.Controls.Add(this.RazaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MyDataGridView);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.CedulaTextBox);
            this.Controls.Add(this.EdadPersTextBox);
            this.Controls.Add(this.NombrePersTextBox);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.EdadLabel);
            this.Controls.Add(this.NombrePersLabel);
            this.Controls.Add(this.TituloLabel);
            this.Name = "Ejercicio2Form";
            this.Text = "Ejercicio2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MyDataGridView;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.TextBox CedulaTextBox;
        private System.Windows.Forms.TextBox EdadPersTextBox;
        private System.Windows.Forms.TextBox NombrePersTextBox;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label EdadLabel;
        private System.Windows.Forms.Label NombrePersLabel;
        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.TextBox RazaTextBox;
        private System.Windows.Forms.TextBox EdadMasTextBox;
        private System.Windows.Forms.TextBox NombreMasTextBox;
        private System.Windows.Forms.Label RazaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadPersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaPersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadMasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazaColumn;
        private System.Windows.Forms.Label DatosPersLabel;
        private System.Windows.Forms.Label DatosMasLabel;
    }
}