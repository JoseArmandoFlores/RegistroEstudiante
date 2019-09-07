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
    public partial class RegistroEstudianteForm : Form
    {
        public RegistroEstudianteForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDNumericUpDown.Value = 0;
            MatriculaMaskedTextBox.Text = string.Empty;
            NombresTextBox.Text = string.Empty;
            ApellidosTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            FechaNacimientoDateTimePicker.Value = DateTime.Now;
            SexoComboBox.Text = string.Empty;
            BalanceTextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = Convert.ToInt32(IDNumericUpDown.Value);
            estudiante.Matricula = MatriculaMaskedTextBox.Text;
            estudiante.Nombres = NombresTextBox.Text;
            estudiante.Apellidos = ApellidosTextBox.Text;
            estudiante.Cedula = CedulaMaskedTextBox.Text;
            estudiante.Telefono = TelefonoMaskedTextBox.Text;
            estudiante.Celular = CelularMaskedTextBox.Text;
            estudiante.Email = EmailTextBox.Text;
            estudiante.FechaNacimiento = FechaNacimientoDateTimePicker.Value;
            estudiante.Sexo = SexoComboBox.SelectedIndex;
            estudiante.Balance = Convert.ToSingle(BalanceTextBox.Text);

            return estudiante;
        }

        private void LlenaCampo(Estudiantes estudiante)
        {
            IDNumericUpDown.Value = estudiante.EstudianteId;
            MatriculaMaskedTextBox.Text = estudiante.Matricula;
            NombresTextBox.Text = estudiante.Nombres;
            ApellidosTextBox.Text = estudiante.Apellidos;
            CedulaMaskedTextBox.Text = estudiante.Cedula;
            TelefonoMaskedTextBox.Text = estudiante.Telefono;
            CelularMaskedTextBox.Text = estudiante.Celular;
            EmailTextBox.Text = estudiante.Email;
            FechaNacimientoDateTimePicker.Value = estudiante.FechaNacimiento;
            SexoComboBox.SelectedIndex = estudiante.Sexo;
            BalanceTextBox.Text = Convert.ToString(estudiante.Balance);
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                MyErrorProvider.SetError(NombresTextBox, "El campo Nombres no puede estar vacío.");
                NombresTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(ApellidosTextBox.Text))
            {
                MyErrorProvider.SetError(ApellidosTextBox, "El campo Apellidos no puede estar vacío.");
                ApellidosTextBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(MatriculaMaskedTextBox.Text.Replace("-", "")))
            {
                MyErrorProvider.SetError(MatriculaMaskedTextBox, "El campo Matrícula no puede estar vacío.");
                MatriculaMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CedulaMaskedTextBox.Text.Replace("-","")))
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "El campo Cédula no puede estar vacío.");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(TelefonoMaskedTextBox.Text.Replace("-", "")))
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox, "El campo Teléfono no puede estar vacío.");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CelularMaskedTextBox.Text.Replace("-", "")))
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "El campo Celular no puede estar vacío.");
                CelularMaskedTextBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(FechaNacimientoDateTimePicker.Text))
            {
                MyErrorProvider.SetError(FechaNacimientoDateTimePicker, "El campo Fecha no puede estar vacío.");
                FechaNacimientoDateTimePicker.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(SexoComboBox.Text))
            {
                MyErrorProvider.SetError(SexoComboBox, "El campo Sexo no puede estar vacío.");
                SexoComboBox.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(BalanceTextBox.Text))
            {
                MyErrorProvider.SetError(BalanceTextBox, "El campo Balance no puede estar vacío.");
                BalanceTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Estudiantes estudiante = EstudiantesBLL.Buscar((int)IDNumericUpDown.Value);
            return (estudiante != null);
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void RegistroEstudianteForm_Load(object sender, EventArgs e)
        {

        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante;
            bool paso = false;

            if (!Validar())
                return;
            estudiante = LlenaClase();

            if (IDNumericUpDown.Value == 0)
                paso = EstudiantesBLL.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un estudiante que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EstudiantesBLL.Modificar(estudiante);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            estudiante = EstudiantesBLL.Buscar(id);

            if(estudiante != null)
            {
                LlenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("Persona no encontrada");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IDNumericUpDown.Text, out id);

            Limpiar();

            if (EstudiantesBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider.SetError(IDNumericUpDown, "No se puede eliminar un estudiante que no existe");
        }
    }
}
