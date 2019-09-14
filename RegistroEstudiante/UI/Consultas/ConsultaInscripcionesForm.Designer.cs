namespace RegistroEstudiante.UI.Consultas
{
    partial class ConsultaInscripcionesForm
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
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.FiltroComboBox = new System.Windows.Forms.ComboBox();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.CriterioLabel = new System.Windows.Forms.Label();
            this.FiltroLabel = new System.Windows.Forms.Label();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioTextBox.Location = new System.Drawing.Point(424, 52);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(390, 27);
            this.CriterioTextBox.TabIndex = 66;
            // 
            // FiltroComboBox
            // 
            this.FiltroComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroComboBox.FormattingEnabled = true;
            this.FiltroComboBox.Items.AddRange(new object[] {
            "Todo",
            "ID",
            "Monto",
            "Deposito",
            "Balance"});
            this.FiltroComboBox.Location = new System.Drawing.Point(274, 52);
            this.FiltroComboBox.Name = "FiltroComboBox";
            this.FiltroComboBox.Size = new System.Drawing.Size(144, 26);
            this.FiltroComboBox.TabIndex = 65;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(12, 52);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(125, 27);
            this.DesdeDateTimePicker.TabIndex = 64;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(143, 52);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(125, 27);
            this.HastaDateTimePicker.TabIndex = 63;
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Image = global::RegistroEstudiante.Properties.Resources.depositphotos_25597209_stock_photo_search_blue_circle_glossy_icon;
            this.ConsultarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarButton.Location = new System.Drawing.Point(819, 51);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(109, 31);
            this.ConsultarButton.TabIndex = 62;
            this.ConsultarButton.Text = "Consultar";
            this.ConsultarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // CriterioLabel
            // 
            this.CriterioLabel.AutoSize = true;
            this.CriterioLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CriterioLabel.Location = new System.Drawing.Point(420, 21);
            this.CriterioLabel.Name = "CriterioLabel";
            this.CriterioLabel.Size = new System.Drawing.Size(73, 22);
            this.CriterioLabel.TabIndex = 61;
            this.CriterioLabel.Text = "Criterio";
            // 
            // FiltroLabel
            // 
            this.FiltroLabel.AutoSize = true;
            this.FiltroLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltroLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FiltroLabel.Location = new System.Drawing.Point(270, 21);
            this.FiltroLabel.Name = "FiltroLabel";
            this.FiltroLabel.Size = new System.Drawing.Size(55, 22);
            this.FiltroLabel.TabIndex = 60;
            this.FiltroLabel.Text = "Filtro";
            // 
            // HastaLabel
            // 
            this.HastaLabel.AutoSize = true;
            this.HastaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.HastaLabel.Location = new System.Drawing.Point(139, 21);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(55, 22);
            this.HastaLabel.TabIndex = 59;
            this.HastaLabel.Text = "Hasta";
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.AutoSize = true;
            this.DesdeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DesdeLabel.Location = new System.Drawing.Point(12, 21);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(60, 22);
            this.DesdeLabel.TabIndex = 58;
            this.DesdeLabel.Text = "Desde";
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(12, 85);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.RowHeadersWidth = 51;
            this.ConsultaDataGridView.RowTemplate.Height = 24;
            this.ConsultaDataGridView.Size = new System.Drawing.Size(917, 510);
            this.ConsultaDataGridView.TabIndex = 57;
            // 
            // ConsultaInscripcionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(938, 602);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.FiltroComboBox);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.ConsultarButton);
            this.Controls.Add(this.CriterioLabel);
            this.Controls.Add(this.FiltroLabel);
            this.Controls.Add(this.HastaLabel);
            this.Controls.Add(this.DesdeLabel);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Name = "ConsultaInscripcionesForm";
            this.Text = "Consulta de Inscripciones";
            this.Load += new System.EventHandler(this.ConsultaInscripcionesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.ComboBox FiltroComboBox;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.Label CriterioLabel;
        private System.Windows.Forms.Label FiltroLabel;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
    }
}