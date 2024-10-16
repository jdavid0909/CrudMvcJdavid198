
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CnUsuarios
    {

        private CD_Usuarios objCapaDato =  new CD_Usuarios();

        public List<Usuario> ListaUSuarios()
        {
            return objCapaDato.Listar();
        }

        public void saveUser(Usuario usuario)
        {
            objCapaDato.SaveUser(usuario);
        }

        public void editUsuario(Usuario usuario, int idUsuario)
        {
            objCapaDato.EditUser(usuario, idUsuario);
        }

        public Usuario editUser(int id)
        {
            return objCapaDato.EditUser(id);
        }




        public void deleteUser(int id)
        {
            objCapaDato.DeleteUser(id);
        }


    }
}
