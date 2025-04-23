using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_calculadora_de_temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal celcius = 0M;
        decimal farengeith = 0M;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cacular_Click(object sender, EventArgs e)
        {
            decimal Final_celcius = 0M; 
            decimal Final_farengeith = 0M; 


            try
            {
                // si el usuario ingreso un valor en celsius, se convierte a fahrenheit
                if (!string.IsNullOrWhiteSpace(txt_celsius.Text))
                {
                    celcius = Convert.ToDecimal(txt_celsius.Text);
                    Final_farengeith = (celcius * 9.0m / 5.0m) + 32;
                    txt_farengeith.Text = Final_farengeith.ToString("0.##");
                }

                // si el usuario ingreso un valor en faren, se convierte a celsius
                if (!string.IsNullOrWhiteSpace(txt_farengeith.Text))
                {
                    farengeith = Convert.ToDecimal(txt_farengeith.Text);
                    Final_celcius = (farengeith - 32) * 5.0m / 9.0m;
                    txt_celsius.Text = Final_celcius.ToString("0.##");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }



        }
    }
}

