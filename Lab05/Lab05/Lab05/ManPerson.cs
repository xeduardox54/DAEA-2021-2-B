using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab05
{
    public partial class ManPerson : Form
    {
        SqlConnection conn;
        public ManPerson()
        {
            InitializeComponent();
        }

        private void ManPerson_Load(object sender, EventArgs e)
        {
            String str = "server=DESKTOP-D6EC5HS\\LOCAL;DataBase=School;integrated Security=true;";
            conn = new SqlConnection(str);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT * FROM Person";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvListado.DataSource = dt;
            dgvListado.Refresh();
            conn.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sp = "InsertPerson";
            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtNombre.Text);
            cmd.Parameters.AddWithValue("@LastName", txtApellido.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Text);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Text);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Se ha registrado nueva persona con el codigo: " + codigo);
            conn.Close();

            btnListar.PerformClick();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sp = "DeletePerson";
            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);
            try
            {
                int resultado = cmd.ExecuteNonQuery();
                if (resultado > 0)
                {
                    MessageBox.Show("se ha eliminado el registro correctamente");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error al eliminar : \n" + ex.Errors[0].Number + " - " + ex.Errors[0].ToString());
            }
            conn.Close();

            btnListar.PerformClick();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sp = "UpdatePerson";
            SqlCommand cmd = new SqlCommand(sp, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtNombre.Text);
            cmd.Parameters.AddWithValue("@LastName", txtApellido.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Text);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Text);

            int resultado = cmd.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Se ha modificado el registro correctamente");
            }
            conn.Close();

            btnListar.PerformClick();
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtNombre.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtApellido.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                txtHireDate.Text = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                txtEnrollmentDate.Text = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtHireDate.Value = DateTime.Now;
            txtEnrollmentDate.Value = DateTime.Now;
            txtPersonID.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            conn.Open();
            String sql = "SELECT * FROM Person WHERE FirstName LIKE @nombre AND LastName LIKE @apellido";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@nombre", "%" + txtNombre.Text + "%");
            cmd.Parameters.AddWithValue("@apellido", "%" + txtApellido.Text + "%");
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(reader);

            dgvListado.DataSource = dt;
            dgvListado.Refresh();
            conn.Close();
        }
    }
}
