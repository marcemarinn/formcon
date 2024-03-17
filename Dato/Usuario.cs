using Formcon.net.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formcon.net.Dato
{
    public class Usuario
    {
        List<modelo.UsuarioModel> listView = new List<modelo.UsuarioModel> ();
        /// <summary>
        /// Guarda usuarios
        /// </summary>
        /// <param name="model">Datos del usuario</param>
        public void save(modelo.UsuarioModel model)
        {
            listView.Add (model);
        }

        /// <summary>
        /// Consulta los usuarios 
        /// </summary>
        /// <returns> datos del usuario</returns>
        public List<UsuarioModel> consultar()
        {
            return listView;
        }

    }
}
