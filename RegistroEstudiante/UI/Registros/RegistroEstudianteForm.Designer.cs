namespace RegistroEstudiante.UI.Registros
{
    partial class RegistroEstudianteForm
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
            this.components = new System.ComponentModel.Container();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.FechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.ApellidosTextBox = new System.Windows.Forms.TextBox();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoLabel = new System.Windows.Forms.Label();
            this.CelularLabel = new System.Windows.Forms.Label();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MatriculaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.SexoLabel = new System.Windows.Forms.Label();
            this.FechaNacimientoLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.CedulaLabel = new System.Windows.Forms.Label();
            this.MatriculaLabel = new System.Windows.Forms.Label();
            this.ApellidosLabel = new System.Windows.Forms.Label();
            this.NombresLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.SexoComboBox.Location = new System.Drawing.Point(199, 290);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(238, 24);
            this.SexoComboBox.TabIndex = 52;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(199, 234);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(238, 22);
            this.EmailTextBox.TabIndex = 47;
            // 
            // FechaNacimientoDateTimePicker
            // 
            this.FechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientoDateTimePicker.Location = new System.Drawing.Point(199, 262);
            this.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker";
            this.FechaNacimientoDateTimePicker.Size = new System.Drawing.Size(238, 22);
            this.FechaNacimientoDateTimePicker.TabIndex = 46;
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Location = new System.Drawing.Point(199, 318);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.Size = new System.Drawing.Size(238, 22);
            this.BalanceTextBox.TabIndex = 45;
            // 
            // ApellidosTextBox
            // 
            this.ApellidosTextBox.Location = new System.Drawing.Point(199, 123);
            this.ApellidosTextBox.Name = "ApellidosTextBox";
            this.ApellidosTextBox.Size = new System.Drawing.Size(238, 22);
            this.ApellidosTextBox.TabIndex = 44;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(199, 95);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(238, 22);
            this.NombresTextBox.TabIndex = 43;
            // 
            // TelefonoLabel
            // 
            this.TelefonoLabel.AutoSize = true;
            this.TelefonoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TelefonoLabel.Location = new System.Drawing.Point(19, 178);
            this.TelefonoLabel.Name = "TelefonoLabel";
            this.TelefonoLabel.Size = new System.Drawing.Size(80, 22);
            this.TelefonoLabel.TabIndex = 42;
            this.TelefonoLabel.Text = "Teléfono";
            // 
            // CelularLabel
            // 
            this.CelularLabel.AutoSize = true;
            this.CelularLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelularLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CelularLabel.Location = new System.Drawing.Point(19, 205);
            this.CelularLabel.Name = "CelularLabel";
            this.CelularLabel.Size = new System.Drawing.Size(69, 22);
            this.CelularLabel.TabIndex = 41;
            this.CelularLabel.Text = "Celular";
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(199, 179);
            this.TelefonoMaskedTextBox.Mask = "000-000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(238, 22);
            this.TelefonoMaskedTextBox.TabIndex = 40;
            // 
            // CelularMaskedTextBox
            // 
            this.CelularMaskedTextBox.Location = new System.Drawing.Point(199, 206);
            this.CelularMaskedTextBox.Mask = "000-000-0000";
            this.CelularMaskedTextBox.Name = "CelularMaskedTextBox";
            this.CelularMaskedTextBox.Size = new System.Drawing.Size(238, 22);
            this.CelularMaskedTextBox.TabIndex = 39;
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(199, 151);
            this.CedulaMaskedTextBox.Mask = "000-0000000-0";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(238, 22);
            this.CedulaMaskedTextBox.TabIndex = 38;
            // 
            // MatriculaMaskedTextBox
            // 
            this.MatriculaMaskedTextBox.Location = new System.Drawing.Point(199, 67);
            this.MatriculaMaskedTextBox.Mask = "0000-0000";
            this.MatriculaMaskedTextBox.Name = "MatriculaMaskedTextBox";
            this.MatriculaMaskedTextBox.Size = new System.Drawing.Size(238, 22);
            this.MatriculaMaskedTextBox.TabIndex = 37;
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(199, 24);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.ReadOnly = true;
            this.IDNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.IDNumericUpDown.TabIndex = 36;
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BalanceLabel.Location = new System.Drawing.Point(19, 317);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(74, 22);
            this.BalanceLabel.TabIndex = 35;
            this.BalanceLabel.Text = "Balance";
            // 
            // SexoLabel
            // 
            this.SexoLabel.AutoSize = true;
            this.SexoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SexoLabel.Location = new System.Drawing.Point(19, 289);
            this.SexoLabel.Name = "SexoLabel";
            this.SexoLabel.Size = new System.Drawing.Size(49, 22);
            this.SexoLabel.TabIndex = 34;
            this.SexoLabel.Text = "Sexo";
            // 
            // FechaNacimientoLabel
            // 
            this.FechaNacimientoLabel.AutoSize = true;
            this.FechaNacimientoLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaNacimientoLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FechaNacimientoLabel.Location = new System.Drawing.Point(19, 263);
            this.FechaNacimientoLabel.Name = "FechaNacimientoLabel";
            this.FechaNacimientoLabel.Size = new System.Drawing.Size(148, 22);
            this.FechaNacimientoLabel.TabIndex = 33;
            this.FechaNacimientoLabel.Text = "Fecha nacimiento";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmailLabel.Location = new System.Drawing.Point(19, 233);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(57, 22);
            this.EmailLabel.TabIndex = 32;
            this.EmailLabel.Text = "Email";
            // 
            // CedulaLabel
            // 
            this.CedulaLabel.AutoSize = true;
            this.CedulaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CedulaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CedulaLabel.Location = new System.Drawing.Point(19, 150);
            this.CedulaLabel.Name = "CedulaLabel";
            this.CedulaLabel.Size = new System.Drawing.Size(66, 22);
            this.CedulaLabel.TabIndex = 31;
            this.CedulaLabel.Text = "Cédula";
            // 
            // MatriculaLabel
            // 
            this.MatriculaLabel.AutoSize = true;
            this.MatriculaLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatriculaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.MatriculaLabel.Location = new System.Drawing.Point(19, 66);
            this.MatriculaLabel.Name = "MatriculaLabel";
            this.MatriculaLabel.Size = new System.Drawing.Size(87, 22);
            this.MatriculaLabel.TabIndex = 30;
            this.MatriculaLabel.Text = "Matrícula";
            // 
            // ApellidosLabel
            // 
            this.ApellidosLabel.AutoSize = true;
            this.ApellidosLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidosLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ApellidosLabel.Location = new System.Drawing.Point(19, 122);
            this.ApellidosLabel.Name = "ApellidosLabel";
            this.ApellidosLabel.Size = new System.Drawing.Size(89, 22);
            this.ApellidosLabel.TabIndex = 29;
            this.ApellidosLabel.Text = "Apellidos";
            // 
            // NombresLabel
            // 
            this.NombresLabel.AutoSize = true;
            this.NombresLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombresLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NombresLabel.Location = new System.Drawing.Point(19, 94);
            this.NombresLabel.Name = "NombresLabel";
            this.NombresLabel.Size = new System.Drawing.Size(82, 22);
            this.NombresLabel.TabIndex = 28;
            this.NombresLabel.Text = "Nombres";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.IDLabel.Location = new System.Drawing.Point(19, 22);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(30, 22);
            this.IDLabel.TabIndex = 27;
            this.IDLabel.Text = "ID";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BuscarButton.Image = global::RegistroEstudiante.Properties.Resources.depositphotos_25597209_stock_photo_search_blue_circle_glossy_icon;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(336, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(101, 45);
            this.BuscarButton.TabIndex = 51;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GuardarButton.Image = global::RegistroEstudiante.Properties.Resources._55078678_guardar_icono_del_disquete_botón_cuadrado_azul_cian;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(217, 365);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 55);
            this.GuardarButton.TabIndex = 50;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EliminarButton.Image = global::RegistroEstudiante.Properties.Resources.depositphotos_59534697_stock_illustration_delete_icon;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(362, 365);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 55);
            this.EliminarButton.TabIndex = 49;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NuevoButton.Image = global::RegistroEstudiante.Properties.Resources.depositphotos_87132830_stock_illustration_new_tag_flat_icon;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(75, 365);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 55);
            this.NuevoButton.TabIndex = 48;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // RegistroEstudianteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(473, 432);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.FechaNacimientoDateTimePicker);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.ApellidosTextBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.TelefonoLabel);
            this.Controls.Add(this.CelularLabel);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.CelularMaskedTextBox);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.MatriculaMaskedTextBox);
            this.Controls.Add(this.IDNumericUpDown);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.SexoLabel);
            this.Controls.Add(this.FechaNacimientoLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.CedulaLabel);
            this.Controls.Add(this.MatriculaLabel);
            this.Controls.Add(this.ApellidosLabel);
            this.Controls.Add(this.NombresLabel);
            this.Controls.Add(this.IDLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "RegistroEstudianteForm";
            this.Text = "Registro Estudiante";
            this.Load += new System.EventHandler(this.RegistroEstudianteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox SexoComboBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.DateTimePicker FechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.TextBox ApellidosTextBox;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.Label TelefonoLabel;
        private System.Windows.Forms.Label CelularLabel;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CelularMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox MatriculaMaskedTextBox;
        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label SexoLabel;
        private System.Windows.Forms.Label FechaNacimientoLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label CedulaLabel;
        private System.Windows.Forms.Label MatriculaLabel;
        private System.Windows.Forms.Label ApellidosLabel;
        private System.Windows.Forms.Label NombresLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}