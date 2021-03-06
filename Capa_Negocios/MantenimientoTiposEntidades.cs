using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Datos.Modelos;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Negocios
{
    public class MantenimientoTiposEntidades
    {
        private RepositorioTiposEntidades repo;

        public MantenimientoTiposEntidades(SqlConnection conexion)
        {
            repo = new RepositorioTiposEntidades(conexion);
        }
        public TiposEntidades CrearObjeto(int id, string descripcion, int Grupo, string Comentario, string Status, int eliminable, DateTime fecha)
        {
            return new TiposEntidades
            {
                IdTipoEntidad = id,
                Descripcion = descripcion,
                IdGrupoEntidad = Grupo,
                Comentario = Comentario,
                Status = Status,
                NoEliminable = eliminable,
                FechaRegistro = DateTime.Now,
            };
        }

        public bool Agregar(TiposEntidades item)
        {
            return repo.Agregar(item);
        }

        public DataTable Listar()
        {
            return repo.Listar();
        }
        public bool Editar(TiposEntidades entidad)
        {
            return repo.Editar(entidad);
        }

        public TiposEntidades EnlistarPorId(int id)
        {
            return repo.EnlistarPorId(id);
        }
        public bool Eliminar(int id)
        {
            return repo.Eliminar(id);
        }

    }
}
