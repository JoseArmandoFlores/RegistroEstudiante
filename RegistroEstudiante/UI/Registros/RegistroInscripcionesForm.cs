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

namespace RegistroEstudiante.UI.Registros
{
    public partial class RegistroInscripcionesForm : Form
    {
        public RegistroInscripcionesForm()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            InscripcionIDNumericUpDown.Value = 0;
            EstudianteIDNumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
            MontoTextBox.Text = string.Empty;
            DepositoTextBox.Text = string.Empty;
            BalanceTextBox.Text = string.Empty;
            ComentariosRichTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private Inscripciones LlenaClase()
        {
            Inscripciones inscripcion = new Inscripciones();
            inscripcion.InscripcionId = Convert.ToInt32(InscripcionIDNumericUpDown.Value);
            inscripcion.EstudianteId = Convert.ToInt32(EstudianteIDNumericUpDown.Value);
            inscripcion.Fecha = FechaDateTimePicker.Value;
            inscripcion.Monto = Convert.ToDecimal(MontoTextBox.Text);
            inscripcion.Deposito = Convert.ToDecimal(DepositoTextBox.Text);
            inscripcion.Comentarios = ComentariosRichTextBox.Text;

            if(Convert.ToDecimal(BalanceTextBox.Text + "0") > 0)
            {
                EstudiantesBLL.GuardarBalance((int)EstudianteIDNumericUpDown.Value, (-1 * inscripcion.Deposito));
                inscripcion.Balance = (Convert.ToDecimal(BalanceTextBox.Text) - inscripcion.Deposito);
            }
            else
            {
                EstudiantesBLL.GuardarBalance((int)EstudianteIDNumericUpDown.Value, (inscripcion.Monto - inscripcion.Deposito));
                inscripcion.Balance = inscripcion.Monto - inscripcion.Deposito;
            }
            return inscripcion;
        }

        private void LlenaCampo(Inscripciones inscripcion)
        {
            InscripcionIDNumericUpDown.Value = inscripcion.InscripcionId;
            EstudianteIDNumericUpDown.Value = inscripcion.EstudianteId;
            FechaDateTimePicker.Value = inscripcion.Fecha;
            MontoTextBox.Text = Convert.ToString(inscripcion.Monto);
            DepositoTextBox.Text = Convert.ToString(inscripcion.Deposito);
            ComentariosRichTextBox.Text = inscripcion.Comentarios;
            BalanceTextBox.Text = Convert.ToString(inscripcion.Balance);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(MontoTextBox.Text))
            {
                MyErrorProvider.SetError(MontoTextBox, "El campo Monto no puede estar vacío.");
                MontoTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(DepositoTextBox.Text))
            {
                MyErrorProvider.SetError(DepositoTextBox, "El campo Apellidos no puede estar vacío.");
                DepositoTextBox.Focus();
                paso = false;
            }
            
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Inscripciones inscripcion = InscripcionesBLL.Buscar((int)InscripcionIDNumericUpDown.Value);
            return (inscripcion != null);
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Inscripciones inscripcion;
            bool paso = false;
          
            if (!Validar())
                return;
            inscripcion = LlenaClase();

            if (EstudiantesBLL.Buscar(inscripcion.EstudianteId) != null)
            {               
                if (InscripcionIDNumericUpDown.Value == 0)
                    paso = InscripcionesBLL.Guardar(inscripcion);
                else
                {
                    if (!ExisteEnLaBaseDeDatos())
                    {
                        MessageBox.Show("No se puede modificar una inscripcion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    paso = InscripcionesBLL.Modificar(inscripcion);
                }

                if (paso)
                {
                    Limpiar();
                    MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("No existe ese estudiante", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Inscripciones inscripcion = new Inscripciones();
            MyErrorProvider.Clear();
            int id;
            int.TryParse(InscripcionIDNumericUpDown.Text, out id);
            Limpiar();

            inscripcion = InscripcionesBLL.Buscar(id);
            if (InscripcionesBLL.Eliminar(id))
            {
                EstudiantesBLL.GuardarBalance(inscripcion.EstudianteId, (0 * inscripcion.Balance));
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MyErrorProvider.SetError(InscripcionIDNumericUpDown, "No se puede eliminar una inscripcion que no existe");
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Inscripciones inscripcion = new Inscripciones();
            int.TryParse(InscripcionIDNumericUpDown.Text, out id);

            Limpiar();

            inscripcion = InscripcionesBLL.Buscar(id);

            if (inscripcion != null)
            {
                LlenaCampo(inscripcion);
            }
            else
            {
                MessageBox.Show("Inscripcion no encontrada", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistroInscripcionesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
