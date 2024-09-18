using ControlDeAsistencia.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeAsistencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtContrasena.PasswordChar = '*';
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            
            //administrador
            var usuario = "admin";
            var contrasena = "admin";

            //Trabajador
            var usuarioTrabajador = "trabajador";
            var contrasenaTrabajador = "123";



            //Admin
            if (txtUsuario.Text == usuario && txtContrasena.Text == contrasena)
            {
                MessageBox.Show("Has ingresado correctamente",
                        "Bienvenido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                Seleccion seleccion = new Seleccion();
                this.Hide(); // ocultar formulario
                seleccion.ShowDialog();
                this.Show(); //Si vuelvo, se vuelve abrir el login asi no se me buguea de nuevo
            }


            //Trabajador
            else if (txtUsuario.Text == usuarioTrabajador && txtContrasena.Text == contrasenaTrabajador)
            {
                MessageBox.Show("Has ingresado correctamente",
                    "Bienvenido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                SeleccionTrabajador seleccionTrabajador = new SeleccionTrabajador();
                this.Hide();
                seleccionTrabajador.ShowDialog();
                this.Show(); 
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrecta",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                txtUsuario.Clear();
                txtContrasena.Clear();


            }
            
        }
    }
}
