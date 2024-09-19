using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlDeAsistencia.Controlador;
using ControlDeAsistencia.Modelo;

namespace ControlDeAsistencia.Vista
{
    public partial class PersonalCRUD : Form
    {

        public Conexion dbContext;
        public PersonalController controlador;
        


        public PersonalCRUD()
        {
            InitializeComponent();
            dbContext = new Conexion();
            controlador = new PersonalController();
            MostrarPersonal();
        }

       
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Metodo Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Personal nuevoPersonal = new Personal()
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = int.Parse(txtEdad.Text),
                Cargo = cbxCargo.Text,
                Saldo = int.Parse(txtSaldo.Text),
                Fecha = txtFecha.Text


            };
            controlador.ModificarPersonal(nuevoPersonal);
            MostrarPersonal();
            MessageBox.Show("Personal Agregado Correctamente.");
        }
        // Metodo Mostrar

        public void MostrarPersonal()
        {
            var personal = dbContext.Personal.ToList();
            dataGridView1.DataSource = personal;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var personal = dataGridView1.SelectedRows[0].DataBoundItem as Personal;
                if (personal != null) 
                {
                    personal.Nombre = txtNombre.Text;
                    personal.Apellido = txtApellido.Text;
                    personal.Edad = int.Parse(txtEdad.Text);
                    personal.Cargo = cbxCargo.Text;
                    personal.Saldo = int.Parse(txtSaldo.Text);
                    personal.Fecha = txtFecha.Text;

                    controlador.ModificarPersonal(personal);
                    MostrarPersonal();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Metodo Eliminar

            if (dataGridView1.SelectedRows.Count > 0)
            {
                var personal = dataGridView1.SelectedRows[0].DataBoundItem as Personal;
                if (personal != null)
                {
                    MessageBox.Show("Personal eliminado");
                    controlador.EliminarPersonal(personal.PersonalId);
                    MostrarPersonal();
                }
            }
        }
    }
}
