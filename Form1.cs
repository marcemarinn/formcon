using Formcon.net.Dato;
using Formcon.net.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formcon.net
{
    public partial class Form1 : Form
    {
        private string filePath = "C:/proyectos/formcon.txt";   

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

        private async void button1_Click(object sender, EventArgs e)
        {
            save();
            iniciar();
            limpiar();
           
            Consultar();
           

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
        private void LoadDataFromFile()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length >= 2)
                {
                    txtnombre.Text = lines[0];
                    int age;
                    if (int.TryParse(lines[1], out age))
                    {
                        txtedad.Text = age.ToString();
                    }
                }
            }

        }


        private void save()
        {

            try
            {
                UsuarioModel model = new UsuarioModel()


                {
                    Name = txtnombre.Text,
                    Age = int.Parse(txtedad.Text)


                };


                dato.save(model);


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            SaveDataToFile(Name,age:10);
            MessageBox.Show("Los datos han sido guardados correctamente.");
        



    }

        private void SaveDataToFile(string name, int age)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(name);
                writer.WriteLine(age);
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

        private void limpiarunRegistro(modelo.UsuarioModel model)
        {
           


        }

        private void txtedad_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }

        
    }



