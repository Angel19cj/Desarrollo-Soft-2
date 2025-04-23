using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microondas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //variable para almacenar la entrada via el teclado por el usuario
        private string tiempo = "";
        Tiempo objTiempo;


        //metodo para mostrar el tiempo en el display
        public void DisplayTime()
        {
        
            int horas, minutos,segundos;

            //nos aseguramos que el tiempo sea de 5 digitos
            if (tiempo.Length > 5)
            {
                tiempo = tiempo.Substring(0, 5);
            }
            //si el usuario dijito menos de 5 digitos, completamos con 0
            string display;
            display= tiempo.PadLeft(5, '0');

            //ahora descomponemos el tiempo en horas, minutos y segundos
            horas = Convert.ToInt32(display.Substring(0, 1));
            minutos = Convert.ToInt32(display.Substring(1, 2));
            segundos = Convert.ToInt32(display.Substring(3, 2));

            if (minutos > 59)
            {
                minutos = 59;
            }
            if (segundos > 59)
            {
                segundos = 59;
            }

            //mostramos el tiempo en el display
            lblPantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", horas, minutos, segundos);


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tiempo += btn1.Text;
            DisplayTime();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tiempo += btn6.Text;
            DisplayTime();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tiempo += btn7.Text;
            DisplayTime();

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // descomporner el tiempo en horas, minutos y segundos
            int horas, minutos, segundos;

            tiempo = tiempo.PadLeft(5, '0');

            horas = Convert.ToInt32(tiempo.Substring(0, 1));
            minutos = Convert.ToInt32(tiempo.Substring(1, 2));
            segundos = Convert.ToInt32(tiempo.Substring(3, 2));

            //crear un objeto tiempo

            objTiempo = new Tiempo(horas,minutos,segundos);

            // mosntar el tiempo en el display
            lblPantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", objTiempo.Horas,objTiempo.Minutos,objTiempo.Segundos);

            //iniciar el temporizador
            timer1.Enabled = true;
            // simular que la pantalla esta encendida
            pnlPantalla.BackColor = Color.Yellow;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //disminuir un segundo al tiempo
            if (objTiempo.Segundos > 0)
            {
                objTiempo.Segundos--;
            }
            else if (objTiempo.Minutos > 0)
            {
                objTiempo.Minutos--;
                objTiempo.Segundos = 59;
            }
            else if (objTiempo.Horas > 0)
            {
                objTiempo.Horas--;
                objTiempo.Minutos = 59;
                objTiempo.Segundos = 59;
            }
            else
            {
                timer1.Enabled = false;
                tiempo = "";
                pnlPantalla.BackColor = SystemColors.Control;
            }

            if (objTiempo.Minutos ==0 && objTiempo.Horas ==0 && objTiempo.Segundos==0)
            {
                lblPantalla.Text="Fin";
            }

            //mostrar el tiempo en el display
            lblPantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", objTiempo.Horas, objTiempo.Minutos, objTiempo.Segundos);
        }

       

        private void btn2_Click(object sender, EventArgs e)
        {
            tiempo += btn2.Text;
            DisplayTime();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tiempo += btn3.Text;
            DisplayTime();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tiempo += btn4.Text;
            DisplayTime();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tiempo += btn5.Text;
            DisplayTime();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tiempo += btn8.Text;
            DisplayTime();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tiempo += btn9.Text;
            DisplayTime();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tiempo += btn0.Text;
            DisplayTime();
        }
        int a = 0;
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnIniciar.Visible = false;
            btnContinuar.Visible = true;
            a+=1;
            if (a == 2)
            {
                btnContinuar.Visible = false;
                btnIniciar.Visible = true;
                a = 0;
                objTiempo = new Tiempo(0, 0, 0);
                lblPantalla.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", objTiempo.Horas, objTiempo.Minutos, objTiempo.Segundos);
                pnlPantalla.BackColor = SystemColors.Control;
            }

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnIniciar.Visible = true;
            btnContinuar.Visible = false;
            a = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnContinuar.Visible = false;
        }
    }
        
}
