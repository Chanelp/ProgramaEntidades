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
using Capa_Datos.Modelos;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class FormEditarElimnar_TiposEntidades : Form
    {
        MantenimientoTiposEntidades _mantenimiento;

        TiposEntidades entidad = new TiposEntidades();

        private int id;

        private int Eliminable = 0;


        public FormEditarElimnar_TiposEntidades()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoTiposEntidades(connection);

            cargar_datos(connection);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                if (_mantenimiento.Editar(_mantenimiento.CrearObjeto(id, TxtDescripcion.Text, (int)CmbGrupo.SelectedValue, txtComentario.Text, CmbStatus.Text, Eliminable, DateTime.Now)))
                {
                    MessageBox.Show("Editado con exito", "notificacion");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error inesperado. Intentalo de nuevo", "advertencia");
                }
            }
        }

        private void FormEditarElimnar_TiposEntidades_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DgvTiposEntidades.Refresh();
            DgvTiposEntidades.DataSource = _mantenimiento.Listar();
            DgvTiposEntidades.Columns[0].Visible = false;
            DgvTiposEntidades.ClearSelection();
        }

        private void DgvTiposEntidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    id = Convert.ToInt32(DgvTiposEntidades.Rows[e.RowIndex].Cells[0].Value.ToString());
                    entidad = _mantenimiento.EnlistarPorId(id);
                    TxtDescripcion.Text = entidad.Descripcion;
                    CmbGrupo.SelectedItem = entidad.IdGrupoEntidad;
                    txtComentario.Text = entidad.Comentario;
                    CmbStatus.Text = entidad.Status;
                }
            }
            catch
            {
            }
        }

        public void cargar_datos(SqlConnection conexion)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("SELECT IdGrupoEntidad,Descripcion as Nombre From GruposEntidades", conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["Nombre"] = "Selecciona un Grupo";
            dt.Rows.InsertAt(fila, 0);

            CmbGrupo.ValueMember = "IdGrupoEntidad";
            CmbGrupo.DisplayMember = "Nombre";
            CmbGrupo.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                _mantenimiento.Eliminar(id);
                LoadData();
                MessageBox.Show("Eliminar con exito", "notificacion");
            }
            catch
            {
                MessageBox.Show("Ocurrio un error inesperado. Intentalo de nuevo", "advertencia");
            }
        }
    }
}
