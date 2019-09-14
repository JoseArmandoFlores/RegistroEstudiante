using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistroEstudiante.BLL;
using RegistroEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroEstudiante.BLL.Tests
{
    [TestClass()]
    public class EstudiantesBLLTests
    {
        [TestMethod()]
        public void GuardarBalanceTest()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante = EstudiantesBLL.Buscar(2);
            estudiante.Balance = 5;
            Assert.AreEqual(estudiante != null, true);
        }

        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = 0;
            estudiante.Matricula = "2017-0599";
            estudiante.Nombres = "Jose Armando";
            estudiante.Apellidos = "Flores Baldera";
            estudiante.Cedula = "402-1296518-6";
            estudiante.Telefono = "809-290-8910";
            estudiante.Celular = "829-690-2801";
            estudiante.Email = "floresbaldera@gmail.com";
            estudiante.Sexo = 0;
            estudiante.FechaNacimiento = DateTime.Parse("28/01/2001");

            paso = EstudiantesBLL.Guardar(estudiante);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = 2;
            estudiante.Matricula = "2017-0599";
            estudiante.Nombres = "Jose Armando";
            estudiante.Apellidos = "Flores Baldera";
            estudiante.Cedula = "402-1296518-6";
            estudiante.Telefono = "809-290-8910";
            estudiante.Celular = "829-690-2801";
            estudiante.Email = "jose_flores3@ucne.edu.do";
            estudiante.Sexo = 0;
            estudiante.FechaNacimiento = DateTime.Parse("28/01/2001");

            paso = EstudiantesBLL.Modificar(estudiante);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            bool paso;
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = 1;
            estudiante.Matricula = "2017-0599";
            estudiante.Nombres = "Jose Armando";
            estudiante.Apellidos = "Flores Baldera";
            estudiante.Cedula = "402-1296518-6";
            estudiante.Telefono = "809-290-8910";
            estudiante.Celular = "829-690-2801";
            estudiante.Email = "floresbaldera@gmail.com";
            estudiante.Sexo = 0;
            estudiante.FechaNacimiento = DateTime.Parse("28/01/2001");

            paso = EstudiantesBLL.Eliminar(estudiante.EstudianteId);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante = EstudiantesBLL.Buscar(2);
            Assert.AreEqual(estudiante != null, true);
        }

        [TestMethod()]
        public void GetListTest()
        {
            Assert.Fail();
        }
    }
}