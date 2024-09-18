using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlDeAsistencia.Controlador;
using System.Data.Entity;

namespace ControlDeAsistencia.Modelo
{
    public class Conexion : DbContext
    {
       public DbSet <Personal> Personal { get; set; }

        public Conexion() : base("Data Source=DESKTOP-1V6BG7R; Initial Catalog=GestorControl1; Integrated Security=True;")
        {
        }
    }
}
