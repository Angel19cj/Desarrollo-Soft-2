using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //DEclaramos un arreglo bidemiencional para almacenar 
        //los nobres y promedios de los estudiantes

        string[,] estudiantes = new string[20, 2];

        //cosntantes para nombrr las columenas del arreglo

        const int nombre = 0;
        const int promedio = 1;

        // como necesitamos calcular el promedio totoal de la clase,
        //vamos a declarar un a vaible s que contenga el numero de  estudiantes introducidos

        int contadorEstudiante = 0;

        // metodo para clacular el promedio de los estudantes

        public double CalcularPromedioEstudante(double test1, double test2, double test3) 
        {
        return (test1+ test2+ test3)/3.0;
        }

        //metodo para convertir un pormedio numerico a su equivalente a letras

        public string ConvertirPromedioALetras(double promedio) 
        {
            
            switch ((int)promedio / 10) 
            {
                case 10:
                case 9:
                    return "A";
                case 8:
                    return "B";
                case 7:
                    return "C";
                default:
                    return "F";
            }
        
        }

        // Metodo para Mostrar en el listbost el nombre y pormedio del estudiante  como nuemro

        public void MostrarNombreYPromedioNumerio() 
        {
            lstResutls.Items.Clear();

            // varible par ausmar los pormedio de lo setudiste s momntrados en la lista

            double total=0.0;
            // vamos a recorrer el areeglo ed los estudiantes

            for (int i = 0; i < contadorEstudiante; i++) {

                //Mostrar el nombre y el promedio en el arreglo
                lstResutls.Items.Add(estudiantes[i, nombre] + "\t" + estudiantes[i, promedio]);

                //acumular el pormedio

                total = total + Convert.ToDouble(estudiantes[i,promedio]);

            }
            //caclulo u muestto el promedio de la clase

            lblClassAverage.Text = (total / contadorEstudiante).ToString("F2");
        
        }

        // MEtodo para mostra el nombre y promedio como letras

        public void MostrarNombreYPromedioLetras() 
        {
            lstResutls.Items.Clear();

            // varible par ausmar los pormedio de lo setudiste s momntrados en la lista

            double total = 0.0;

           


            // vamos a recorrer el areeglo ed los estudiantes

            for (int i = 0; i < contadorEstudiante; i++)
            {

                //Mostrar el nombre y el promedio en el arreglo
                lstResutls.Items.Add(estudiantes[i, nombre] + "\t" + ConvertirPromedioALetras(Convert.ToDouble(estudiantes[i,promedio])));

                //acumular el pormedio

                total = total + Convert.ToDouble(estudiantes[i, promedio]);

            }
            //caclulo u muestto el promedio de la clase

            lblClassAverage.Text = ConvertirPromedioALetras(total / contadorEstudiante);

        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            //if (txtStudentName.Text == string.Empty)
            //{
            //    errorProvider1.SetError(txtStudentName, "Intoduzca un nombre");
            //}
            //else { errorProvider1.Clear(); }

            try
            {
                //obtene r los valores de l las calsas de test
                double test1 = Convert.ToDouble(txtTest1.Text);
                double test2 = Convert.ToDouble(txtTest2.Text);
                double test3 = Convert.ToDouble(txtTest3.Text);

                //anadir el estudiante al arreglo

                estudiantes[contadorEstudiante, nombre] = txtStudentName.Text;
                estudiantes[contadorEstudiante,promedio] = CalcularPromedioEstudante(test1, test2, test3).ToString("F2");

                contadorEstudiante++;

                if (rbnLetter.Checked)
                {
                    MostrarNombreYPromedioLetras();
                }
                else 
                {
                    MostrarNombreYPromedioNumerio();
                }
                //limpiamos
                txtStudentName.Clear();
                txtTest1.Clear();
                txtTest2.Clear();
                txtTest3.Clear();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Please Complete all required fields");
            }
        }

        private void rbnNumeric_CheckedChanged(object sender, EventArgs e)
        {
            MostrarNombreYPromedioNumerio();
        }

        private void rbnLetter_CheckedChanged(object sender, EventArgs e)
        {
            MostrarNombreYPromedioLetras();
        }
    }
}
