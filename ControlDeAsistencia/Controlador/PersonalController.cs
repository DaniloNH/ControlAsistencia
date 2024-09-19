using ControlDeAsistencia.Modelo;
using ControlDeAsistencia.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControlDeAsistencia.Controlador
{
    public class PersonalController
    {
        public Conexion dbContext;

        // Constructor
        public PersonalController()
        {
            dbContext = new Conexion();
        }

        // Metedo Agregar

        public void AgregarPersonal(Personal nuevoPersonal)
        {
            dbContext.Personal.Add(nuevoPersonal);
            dbContext.SaveChanges();
        }

        // Metodo Modificar

        public void ModificarPersonal(Personal personalModificar)
        {
            dbContext.Entry(personalModificar).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        // Metedo Eliminar

        public void EliminarPersonal(int id)
        {
            var personalEliminar = dbContext.Personal.Find(id);
            if (personalEliminar != null)
            {
                dbContext.Personal.Remove(personalEliminar);
                dbContext.SaveChanges();
            }
        }

       
    }
}
