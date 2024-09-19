using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAsistencia.Modelo
{
    public class Personal
    {
        
            public int PersonalId { get; set; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }

            public int Edad { get; set; }

            public string Cargo { get; set; }
            public int Saldo { get; set; }
            public string Fecha { get; set; }

        
    }
}
