namespace RegistroEstudiante
{
    partial class MainForm
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
            this.RegistroMenuStrip = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudiantesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistroMenuStrip
            // 
            this.RegistroMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.RegistroMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.RegistroMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.RegistroMenuStrip.Name = "RegistroMenuStrip";
            this.RegistroMenuStrip.Size = new System.Drawing.Size(627, 28);
            this.RegistroMenuStrip.TabIndex = 0;
            this.RegistroMenuStrip.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem,
            this.inscripcionesToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // estudiantesToolStripMenuItem
            // 
            this.estudiantesToolStripMenuItem.Image = global::RegistroEstudiante.Properties.Resources.depositphotos_101541302_stock_illustration_user_icon_team_people_vector;
            this.estudiantesToolStripMenuItem.Name = "estudiantesToolStripMenuItem";
            this.estudiantesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.estudiantesToolStripMenuItem.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem.Click += new System.EventHandler(this.EstudiantesToolStripMenuItem_Click);
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.Image = global::RegistroEstudiante.Properties.Resources.insc;
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inscripcionesToolStripMenuItem.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.InscripcionesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiantesToolStripMenuItem1,
            this.inscripcionesToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.ConsultasToolStripMenuItem_Click);
            // 
            // estudiantesToolStripMenuItem1
            // 
            this.estudiantesToolStripMenuItem1.Image = global::RegistroEstudiante.Properties.Resources.depositphotos_101541302_stock_illustration_user_icon_team_people_vector;
            this.estudiantesToolStripMenuItem1.Name = "estudiantesToolStripMenuItem1";
            this.estudiantesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.estudiantesToolStripMenuItem1.Text = "Estudiantes";
            this.estudiantesToolStripMenuItem1.Click += new System.EventHandler(this.EstudiantesToolStripMenuItem1_Click);
            // 
            // inscripcionesToolStripMenuItem1
            // 
            this.inscripcionesToolStripMenuItem1.Image = global::RegistroEstudiante.Properties.Resources.insc;
            this.inscripcionesToolStripMenuItem1.Name = "inscripcionesToolStripMenuItem1";
            this.inscripcionesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.inscripcionesToolStripMenuItem1.Text = "Inscripciones";
            this.inscripcionesToolStripMenuItem1.Click += new System.EventHandler(this.InscripcionesToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistroEstudiante.Properties.Resources.estudiante_universitaria_con_smartphone_en_biblioteca;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(627, 618);
            this.Controls.Add(this.RegistroMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.RegistroMenuStrip;
            this.Name = "MainForm";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.RegistroMenuStrip.ResumeLayout(false);
            this.RegistroMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip RegistroMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudiantesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem1;
    }
}

