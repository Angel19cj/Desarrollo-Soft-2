/*Construya una clase llamada Estudiante consistente de un número entero de identificación del estudiante, un arreglo de cinco calificaciones 
 * en número de precisión doble y un número entero que represente el número total de calificaciones introducidas. 
 * El constructor para esta clase deberá inicializar todos los miembros de datos de Estudiante en cero. Deberán incluirse en la clase funciones miembro para:

Introducir un número de identificación del estudiante.
Introducir una sola calificación de prueba y actualizar el número total de calificaciones introducidas.
Calcular una calificación promedio y desplegar la identificación del estudiante seguida por la calificación promedio.
Utilice la clase en un programa funcional.*/

using System;
using System.Security.Principal;


class Estudiante
{

    int id_estudiante;
    double[] calificaciones;
    int total_calificaciones;

    public Estudiante()
    {

        id_estudiante = 0;
        calificaciones = new double[5];
        total_calificaciones = 0;
    }

    public void intro_id(int id)
    {
        id_estudiante = id;

    }

    public void intro_calif(double calif)
    {
        calificaciones[total_calificaciones] = calif;
        total_calificaciones++;
    }
    public void promedio()
    {
        if (total_calificaciones == 0)
        {
            Console.WriteLine("No hay calificaciones introducidas.");
            return;
        }

        double a = 0;
        for (int i = 0; i < total_calificaciones; i++)
        {
            a += calificaciones[i];
        }
        double promedio = a/total_calificaciones;

        Console.WriteLine($"Estudiante ID: {id_estudiante}, Promedio: {promedio:F2}");
    }
}

    class Program
    {
        static void Main()
        {
            Estudiante estudiante = new Estudiante();

            Console.Write("Ingrese el número de identificación del estudiante: ");
            int id = int.Parse(Console.ReadLine());
            estudiante.intro_id(id);

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Ingrese la calificación {i}: ");
                double calificacion = double.Parse(Console.ReadLine());
                estudiante.intro_calif(calificacion);
            }

            estudiante.promedio();
        }


    }