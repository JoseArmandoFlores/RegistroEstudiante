using RegistroEstudiante.BLL;
using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroEstudiante.UI.Consultas
{
    public partial class ConsultaInscripcionesForm : Form
    {
        public ConsultaInscripcionesForm()
        {
            InitializeComponent();
        }

        private void ConsultaInscripcionesForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            var listado = new List<Inscripciones>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0://Todo
                        listado = InscripcionesBLL.GetList(p => true);
                        break;
                    case 1://ID
                        int id = Convert.ToInt32(CriterioTextBox.Text);
                        listado = InscripcionesBLL.GetList(p => p.InscripcionId == id);
                        break;
                    case 2://Monto
                        decimal monto = Convert.ToDecimal(CriterioTextBox.Text);
                        listado = InscripcionesBLL.GetList(p => p.Monto == monto);
                        break;
                    case 3://Deposito
                        decimal deposito = Convert.ToDecimal(CriterioTextBox.Text);
                        listado = InscripcionesBLL.GetList(p => p.Deposito == deposito);
                        break;
                    case 4:
                        decimal balance = Convert.ToDecimal(CriterioTextBox.Text);
                        listado = InscripcionesBLL.GetList(p => p.Balance == balance);
                        break;
                }
                listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = InscripcionesBLL.GetList(p => true);
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
