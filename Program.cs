using Dapper;
using Formcon.net.Dato;
using Formcon.net.modelo;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formcon.net

{
   
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
           
            


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           
        }
    }
}
