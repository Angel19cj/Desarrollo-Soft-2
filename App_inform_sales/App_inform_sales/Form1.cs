using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_inform_sales
{
    public partial class Form1 : Form
    {
        private decimal grossSales = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;

            if (string.IsNullOrWhiteSpace(item))
            {
                MessageBox.Show("Ingrese el nombre del Item");
                return;
            }

            decimal monday = ventas(txtMonday.Text);
            decimal tuesday = ventas(txtTuesday.Text);
            decimal wednesday = ventas(txtWednesday.Text);
            decimal thursday = ventas(txtThusday.Text);
            decimal friday = ventas(txtFriday.Text);

            decimal totalWeeklySales = monday + tuesday + wednesday + thursday + friday;

            grossSales += totalWeeklySales;

            listBox1.Items.Add($"{item} \t {monday} \t {tuesday} \t {wednesday} \t \t {thursday} \t \t {friday} \t {totalWeeklySales}");

            txtGrossSales.Text = grossSales.ToString("C");

            Limpiar();
        }

        private decimal ventas(string input)
        {
            try
            {
                decimal value = Convert.ToDecimal(input);

                if (value < 0)
                    return 0;

                return value;
            }
            catch
            {
                return 0;
            }
        
        }

        private void Limpiar()
        {
            txtItem.Clear();
            txtMonday.Clear();
            txtTuesday.Clear();
            txtWednesday.Clear();
            txtThusday.Clear();
            txtFriday.Clear();
            txtItem.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add($"Item \t Monday  \t Tuesday \t Wednesday \t Thursday \t Friday \t  Total");
        }
    }
 }

