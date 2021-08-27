using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            {
                string codigo = lbCodigo.Text;
                string dni = txtDNI.Text;
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string direccion = txtDireccion.Text;
                string telefono = txtTelefono.Text;
                string email = txtEmail.Text;
                string fecha = dtpFecNac.Text;
                string departamento = cboDepartamento.Text;
                dgvUsuarios.Rows.Add(codigo, dni, nombre, apellido, direccion, telefono, email, fecha, departamento);
            }
        }
    }
}
