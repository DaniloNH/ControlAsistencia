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

        // Metodo Mostrar
        
        public void MostrarPersonal()
        {
            var personal = dbContext.Personal.ToList();
            dataGridView1.DataSource = personal;
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
            PersonalCRUD nuevoPersonal = new PersonalCRUD()
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
    }
}
