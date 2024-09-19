using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeAsistencia.Vista
{
    public partial class Seleccion : Form
    {
        public Seleccion()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PersonalCRUD personalventana = new PersonalCRUD();
            this.Hide(); // ocultar formulario
            personalventana.ShowDialog();
            this.Show();

        }
    }
}
