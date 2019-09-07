using RegistroEstudiante.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiante
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEstudianteForm regEstudiante = new RegistroEstudianteForm();
            regEstudiante.Show();
        }

        private void ConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EstudiantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaEstudianteForm consultaEstudiante = new ConsultaEstudianteForm();
            consultaEstudiante.Show();
        }
    }
}
