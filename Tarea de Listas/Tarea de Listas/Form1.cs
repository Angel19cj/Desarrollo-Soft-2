using Amazon.OpsWorks.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_de_Listas
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly string[] arreglo;

        private void Form1_Load(object sender, EventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.Items.AddRange(arreglo);
            this.Controls.Add(listBox);
        }

        private void btn_anadir_sinorden_Click(object sender, EventArgs e)
        {
            string nombre = ShowInputDialog("Ingrese algo");
            listBox1.Items.Add(nombre);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                MessageBox.Show("Has seleccionado: " + selectedItem);
            }
        }

        private void btn_anadir_orden_Click(object sender, EventArgs e)
        {
            string nombre = ShowInputDialog("Ingrese algo");
            listBox2.Items.Add(nombre);
            listBox2.Sorted = true;
        }

        private static string ShowInputDialog(string text)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Input",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void btn_borrrar_sinorden_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("No hay nada seleccionado");
            }
        }

        private void btn_borrarList_sinorden_Click(object sender, EventArgs e)
        {


            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay nada que borrar");
            }
        }

        private void btn_borrar_orden_Click(object sender, EventArgs e)
        {

            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
                listBox2.Sorted = true;
            }
            else
            {
                MessageBox.Show("No hay nada seleccionado");
            }
        }

        private void btn_borrarlist_orden_Click(object sender, EventArgs e)
        {

            if (listBox2.Items.Count > 0)
            {
                listBox2.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay nada que borrar");
            }
        }

        private void btn_para_desordenar_Click(object sender, EventArgs e)
        {
            //este boton se pasa de la lista 2 a la lista 1 el elemento seleccionado
            if (listBox2.SelectedItem != null)
            {
                string selectedItem = listBox2.SelectedItem.ToString();
                listBox1.Items.Add(selectedItem);
                listBox2.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("No hay nada seleccionado");
            }

        }

        private void btn_para_ordenar_Click(object sender, EventArgs e)
        {

            //este boton se pasa de la lista 1 a la lista 2 el elemento seleccionado
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(selectedItem);
                listBox1.Items.Remove(selectedItem);
            }
            else
            {
                MessageBox.Show("No hay nada seleccionado");
            }

        }
    }
}
