using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PantallaDeLogin
{
    public partial class Usuarios: Form
    {
        private string cadenaConexion = ConfigurationManager.ConnectionStrings["MiconexionBD"].ConnectionString;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void TbNombreU_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GuardarUsuario();
        }
        private void GuardarUsuario()
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                string query = "INSERT INTO catUsuarios VALUES (@id,@nombre,@telefono,@nombreusuario,@contraseña,@sexo,@fechanac,@domicilio)";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", tbID.Text);
                    comando.Parameters.AddWithValue("@nombre", TbNombre.Text);
                    comando.Parameters.AddWithValue("@telefono", TBTel.Text);
                    comando.Parameters.AddWithValue("@nombreusuario", TBNombreususario.Text);
                    comando.Parameters.AddWithValue("@contraseña", tbPass.Text);
                    comando.Parameters.AddWithValue("@sexo", tbSexo.Text);
                    comando.Parameters.AddWithValue("@fechanac", tbFechaNac.Text);
                    comando.Parameters.AddWithValue("@domicilio", TbDomicilio.Text);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Guardado correctamente ");
                }
            }
        }
    }
}
