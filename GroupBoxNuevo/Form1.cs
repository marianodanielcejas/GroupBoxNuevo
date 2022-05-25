using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxNuevo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            grb1.Enabled = true;
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tus valores de entrada: " + " Nombre " + txtNombre.Text + " Email " + txtEmail.Text + " Contacto " + txtContacto.Text);
            grb1.Enabled = false;
        }
    }
}
