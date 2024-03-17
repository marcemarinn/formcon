using Formcon.net.Dato;
using Formcon.net.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formcon.net
{
    public partial class Form1 : Form
    {

        DataTable table;
        Usuario dato = new Usuario();

        
        public Form1()
        {
            InitializeComponent();
            iniciar();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            save();
            iniciar();
            limpiar();
            Consultar();
            
            
        }

        private void lblHelloWorld_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        
        }
           private void iniciar()
        {
            table = new DataTable();
            table.Columns.Add("Nombre");
            table.Columns.Add("Edad");
            grilla.DataSource = table;
         

        }

        private void save()
        {

            try { 
            UsuarioModel model = new UsuarioModel()

            
            {
                Name = txtnombre.Text,
                Age = int.Parse(txtedad.Text)
            };
            dato.save(model);
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


    }

        private void Consultar()
        {
            foreach(var item in dato.consultar())
            {
                DataRow fila = table.NewRow();
                fila["Nombre"] = item.Name;
                fila["Edad"]=item.Age;
                table.Rows.Add(fila);
            }
        }

        private void limpiar ()
        {
            txtnombre.Text = string.Empty;
            txtedad.Text = "";


        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }

        
    }



