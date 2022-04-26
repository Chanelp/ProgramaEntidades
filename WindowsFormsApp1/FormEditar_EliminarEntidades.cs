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
    public partial class FormEditar_EliminarEntidades : Form
    {
        MantenimientoEntidades _mantenimiento;

        private Entidades entidad = new Entidades();

        private int id;
        private int IdGrupoEntidad;
        private int IdTipoEntidad;
        private string Telefonos;
        private int Eliminable = 0;
        public FormEditar_EliminarEntidades()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["StringConnectionSQLServer"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _mantenimiento = new MantenimientoEntidades(connection);
        }

        private void FormEditar_EliminarEntidades_Load(object sender, EventArgs e)
        {
            DgvEntidades.Refresh();
            DgvEntidades.DataSource = _mantenimiento.Listar();
            DgvEntidades.Columns[0].Visible = false;
            DgvEntidades.ClearSelection();
        }

        private void LoadData()
        {
            DgvEntidades.Refresh();
            DgvEntidades.DataSource = _mantenimiento.Listar();
            DgvEntidades.ClearSelection();
        }

        private void DgvEntidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(DgvEntidades.Rows[e.RowIndex].Cells[0].Value.ToString());


                entidad = _mantenimiento.EnlistarPorId(id);
                IdGrupoEntidad = entidad.IdGrupoEntidad;
                IdTipoEntidad = entidad.IdTipoEntidad;
                Telefonos = entidad.Teléfonos;
                TxtDescripcion.Text = entidad.Descripcion;
                TxtPass.Text = entidad.PasswordEntidad;
                TxtPaginaWeb.Text = entidad.URLPaginaWeb;
                TxtTwitter.Text = entidad.URLTwitter;
                TxtFacebook.Text = entidad.URLFacebook;
                TxtInstagram.Text = entidad.URLInstagram;
                TxtTikTok.Text = entidad.URLTikTok;
                TxtComentarios.Text = entidad.Comentario;
                TxtDireccion.Text = entidad.Direccion;
                TxtLocalidad.Text = entidad.Localidad;
                CmbEntidad.SelectedIndex = entidad.TipoEntidad == "Física" ? 0 : 1;
                CmbTipoDoc.SelectedIndex = entidad.TipoDocumento == "RNC" ? 0 : (entidad.TipoDocumento == "Cedula" ? 1 : 2);
                TxtNumDoc.Text = entidad.NumeroDocumento;
                TxtUsuario.Text = entidad.UserNameEntidad;
                TxtLimite.Text = Convert.ToString(entidad.LimiteCredito);
                CmbRol.SelectedIndex = entidad.RolUserEntidad == "Admin" ? 0 : (entidad.RolUserEntidad == "Supervisor" ? 1 : 2);
                CmbStatus.SelectedIndex = entidad.Status == "Activa" ? 0 : 1;
                if (entidad.NoEliminable == 0)
                {
                    CkbNo.Checked = true;
                }
                else
                {
                    CkbYes.Checked = true;
                }
            }
        }

        private void CkbYes_CheckedChanged(object sender, EventArgs e)
        {
            CkbNo.Checked = false;
            Eliminable = 1;
        }

        private void CkbNo_CheckedChanged(object sender, EventArgs e)
        {
            CkbYes.Checked = false;
            Eliminable = 0;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                DialogResult dialogo = MessageBox.Show("Estas seguro de que deseas borrar?", "Advertencia", MessageBoxButtons.YesNo);

                if (dialogo == DialogResult.Yes)
                {
                    if (_mantenimiento.Eliminar(id))
                    {
                        MessageBox.Show("Eliminado", "notificacion");
                        LimpiarCampos();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error inesperado. Intentalo de nuevo", "advertencia");
                    }
                }
            }
        }
        private void LimpiarCampos()
        {
            IdGrupoEntidad = 0;
            IdTipoEntidad = 0;
            Telefonos = "";
            TxtDescripcion.Text = "";
            TxtPass.Text = "";
            TxtPaginaWeb.Text = "";
            TxtTwitter.Text = "";
            TxtFacebook.Text = "";
            TxtInstagram.Text = "";
            TxtTikTok.Text = "";
            TxtComentarios.Text = "";
            TxtDireccion.Text = "";
            TxtLocalidad.Text = "";
            CmbEntidad.SelectedIndex = 0;
            CmbTipoDoc.SelectedIndex = 0;
            TxtNumDoc.Text = "";
            TxtUsuario.Text = "";
            TxtLimite.Text = "";
            CmbRol.SelectedIndex = 0;
            CmbStatus.SelectedIndex = 0;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (id >= 0)
            {
                if (_mantenimiento.Editar(_mantenimiento.CrearObjeto(
                    1,
                TxtDescripcion.Text,
                TxtComentarios.Text,
                TxtDireccion.Text,
                TxtLocalidad.Text,
                CmbEntidad.Text,
                CmbTipoDoc.Text,
                TxtNumDoc.Text,
                Telefonos,
                TxtFacebook.Text,
                TxtTwitter.Text,
                TxtInstagram.Text,
                TxtTikTok.Text,
                TxtPaginaWeb.Text,
                IdGrupoEntidad,
                IdTipoEntidad,
                Convert.ToInt32(TxtLimite.Text),
                TxtUsuario.Text,
                TxtPass.Text,
                CmbRol.Text,
                CmbStatus.Text,
                0,
                DateTime.Now)))
                {
                    MessageBox.Show("Editado con exito", "notificacion");
                    LoadData();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error inesperado. Intentalo de nuevo", "advertencia");
                }
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
