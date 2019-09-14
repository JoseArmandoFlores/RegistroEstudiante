using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RegistroEstudiante.Entidades
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }
        public DateTime Fecha { get; set; }
        public string Comentarios { get; set; }
        public decimal Monto { get; set; }
        public decimal Deposito { get; set; }
        public decimal Balance { get; set; }

        public Inscripciones(){ }
        public Inscripciones(int inscripcionId, int estudianteId, DateTime fecha, string comentarios, decimal monto, decimal deposito, decimal balance)
        {
            InscripcionId = inscripcionId;
            EstudianteId = estudianteId;
            Fecha = fecha;
            Comentarios = comentarios;
            Monto = monto;
            Deposito = deposito;
            Balance = balance;
        }
    }
}
