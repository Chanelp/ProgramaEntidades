using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormAgregarEntidades : Form
    {
        private int Eliminable = 0;
        private int id;

        private MantenimientoEntidades _mantenimiento;
        public FormAgregarEntidades()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoEntidades(connection);

            cargar_datos(connection);
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (CmbTipoDoc.SelectedText == "RNC")
            {
                TxtNumDocumento.Mask = "000-00000-0";
            }
            else if (CmbTipoDoc.SelectedText == "Cedula")
            {
                TxtNumDocumento.Mask = "000-0000000-0";
            }
            else if (CmbTipoDoc.SelectedText == "Pasaporte")
            {
                TxtNumDocumento.Mask = "ZAB000000";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CkbNo.Checked = false;
            Eliminable = 1;
        }

        private void CkbNo_CheckedChanged(object sender, EventArgs e)
        {
            CkbYes.Checked = false;
            Eliminable = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (_mantenimiento.Agregar(
                _mantenimiento.CrearObjeto
                (1,
                TxtDescripcion.Text,
                TxtComentarios.Text,
                TxtDireccion.Text,
                TxtLocalidad.Text,
                CmbEntidad.Text,
                CmbTipoDoc.Text,
                TxtNumDocumento.Text,
                TxtTelefono.Text,
                TxtFacebook.Text,
                TxtTwitter.Text,
                TxtInstagram.Text,
                TxtTikTok.Text,
                TxtPaginaWeb.Text,
                1,
                1,
                Convert.ToInt32(TxtLimite.Text),
                TxtUsuario.Text,
                TxtContraseña.Text,
                CmbRol.Text,
                CmbStatus.Text,
                0,
                DateTime.Now)))
            {
                MessageBox.Show("Se ha agregado con éxito", "notificacion");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error inesperado. Intentalo de nuevo", "advertencia");
            }



        }

        private bool Validations()
        {
            bool isEmpty = true;

            if (TxtDescripcion.Text == "")
            {
                MessageBox.Show("Debe insertar una descripcion", "Advertencia");
            }
            else if (TxtDireccion.Text == "")
            {
                MessageBox.Show("Debe insertar una direccion", "Advertencia");
            }
            else if (TxtLocalidad.Text == "")
            {
                MessageBox.Show("Debe insertar una localidad", "Advertencia");
            }
            else if (TxtNumDocumento.Text == "")
            {
                MessageBox.Show("Debe insertar un numero de documento", "Advertencia");
            }
            else if (TxtTelefono.Text == "")
            {
                MessageBox.Show("Debe insertar un telefono", "Advertencia");
            }
            else if (TxtUsuario.Text == "")
            {
                MessageBox.Show("Debe insertar un nombre de usuario", "Advertencia");
            }
            else if (TxtContraseña.Text == "")
            {
                MessageBox.Show("Debe insertar una contraseña", "Advertencia");
            }
            else if (TxtLimite.Text == "")
            {
                MessageBox.Show("Debe insertar un limite", "Advertencia");
            }
            else
            {
                isEmpty = false;
            }

            return isEmpty;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormAgregarEntidades_Load(object sender, EventArgs e)
        {

        }

        public void cargar_datos(SqlConnection conexion)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdGrupoEntidad,Descripcion From GruposEntidades", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["Descripcion"] = "Selecciona un Grupo";
            dt.Rows.InsertAt(fila, 0);

            CmbGrupo.ValueMember = "IdGrupoEntidad";
            CmbGrupo.DisplayMember = "Descripcion";
            CmbGrupo.DataSource = dt;
        }

        public void cargar_Tipo(string id_Grupo, SqlConnection conexion)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Select IdTipoEntidad,Descripcion From TiposEntidades where IdGrupoEntidad = @IdGrupoEntidad", conexion);
            cmd.Parameters.AddWithValue("@IdGrupoEntidad", id_Grupo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow dr = dt.NewRow();
            dr["Descripcion"] = "Selecciona un tipo";
            dt.Rows.InsertAt(dr, 0);

            CmbTipo.ValueMember = "IdTipoEntidad";
            CmbTipo.DisplayMember = "Descripcion";
            CmbTipo.DataSource = dt;
        }

        private void CmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbGrupo.SelectedValue.ToString() != null)
            {
                string id_Grupo = CmbGrupo.SelectedValue.ToString();
                cargar_Tipo(id_Grupo, _mantenimiento.conexion());
            }
        }
    }
}
