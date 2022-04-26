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
    public partial class FormEditarGruposEntidades : Form
    {
        MantenimientoGruposEntidades _mantenimiento;

        GruposEntidades entidad = new GruposEntidades();

        private int id;

        private int Eliminable = 0;
        public FormEditarGruposEntidades()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoGruposEntidades(connection);
        }

        private void FormEditarGruposEntidades_Load(object sender, EventArgs e)
        {
            DgvGruposEntidades.Refresh();
            DgvGruposEntidades.DataSource = _mantenimiento.Listar();
            DgvGruposEntidades.Columns[0].Visible = false;
            DgvGruposEntidades.ClearSelection();
        }

        private void LoadData()
        {
            DgvGruposEntidades.Refresh();
            DgvGruposEntidades.DataSource = _mantenimiento.Listar();
            DgvGruposEntidades.ClearSelection();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                if (_mantenimiento.Editar(_mantenimiento.CrearObjeto(id, TxtDescripcion.Text, TxtComentario.Text, CmbStatus.Text, Eliminable, DateTime.Now)))
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

        private void DgvGruposEntidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                try
                {
                    id = Convert.ToInt32(DgvGruposEntidades.Rows[e.RowIndex].Cells[0].Value.ToString());
                    entidad = _mantenimiento.EnlistarPorId(id);
                    TxtDescripcion.Text = entidad.Descripcion;
                    TxtComentario.Text = entidad.Comentario;
                    CmbStatus.Text = entidad.Status;
                }
                catch
                {
                }



            }
        }

        private void DgvGruposEntidades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
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
