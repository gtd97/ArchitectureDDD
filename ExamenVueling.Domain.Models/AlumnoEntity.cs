using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenVueling.Domain.Models
{
    public class AlumnoEntity
    {
        public partial class Alumno
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Apellidos { get; set; }
            public string Dni { get; set; }
            public DateTime Fecha { get; set; }
            public int Edad { get; set; }
        }
    }
}
