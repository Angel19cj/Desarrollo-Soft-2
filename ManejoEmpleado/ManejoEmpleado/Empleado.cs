using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoEmpleado
{
    internal class Empleado
    {
        // variables de instacia o atributos del objeto
        private int id;
        private string name;
        private string apellido;
        private decimal tasaSalarial;
        private uint horasMaximasTrabajadas;

        //para permitir los accesos a una clase, utilizamos los metodos get y set
        public int Id
        {
            // si queremos que la varialbe sea solo de lectura, solo se coloca el get
            get { return id; }
            // si queremos que la variable sea de escritura, solo se coloca el set
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public decimal TasaSalarial
        {
            get { return tasaSalarial; }
            set { tasaSalarial = value; }
        }
        public uint HorasMaximasTrabajadas
        {
            get { return horasMaximasTrabajadas; }
            set {
                if (value < 0)
                {
                    Console.WriteLine("El valor de horas trabajadas no puede ser negativo");
                }
                else
                {
                    horasMaximasTrabajadas = value;
                }
            }
        }
        // constructores
        public Empleado()
        {
            Console.WriteLine("Se ha creado un Empleado");
        }
        public Empleado(int id, string name, string apellido, decimal tasaSalarial, uint horasMaximasTrabajadas)
        {
            Id = id;
            Name = name;
            Apellido = apellido;
            TasaSalarial = tasaSalarial;
            HorasMaximasTrabajadas = horasMaximasTrabajadas;
            Console.WriteLine("Se ha creado un Empleado con parametros");
        }

        // metodos personalizados
        public void agregarEmpleado()
        {
            Console.WriteLine("Ingrese el Id del empleado: ");
            Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el Nombre del empleado: ");
            Name = Console.ReadLine();
            
            Console.WriteLine("Ingrese el Apellido del empleado: ");
            Apellido = Console.ReadLine();
            
            Console.WriteLine("Ingrese la Tasa Salarial del empleado: ");
            TasaSalarial = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Ingrese las Horas Maximas Trabajadas del empleado: ");
            HorasMaximasTrabajadas = Convert.ToUInt32(Console.ReadLine());
        }
        public void agregarEmpleado(int id, string name, string apellido, decimal tasaSalarial, uint horasMaximasTrabajadas)
        {
            Id = id;
            Name = name;
            Apellido = apellido;
            TasaSalarial = tasaSalarial;
            HorasMaximasTrabajadas = horasMaximasTrabajadas;
        }

        public void modificarEmpleado()
        {
            Console.WriteLine("Ingrese el Nombre del empleado: ");
            Name = Console.ReadLine();

            Console.WriteLine("Ingrese el Apellido del empleado: ");
            Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese la Tasa Salarial del empleado: ");
            TasaSalarial = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Ingrese las Horas Maximas Trabajadas del empleado: ");
            HorasMaximasTrabajadas = Convert.ToUInt32(Console.ReadLine());
        }

        public void mostrarEmpleado()
        {

            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Nombre: " + Name);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Tasa Salarial: " + TasaSalarial);
            Console.WriteLine($"Horas Maximas Trabajadas: " + HorasMaximasTrabajadas);
            Console.WriteLine();
        }

        public void eliminarEmpleado()
        {
            Id = 0;
            Name = "";
            Apellido = "";
            TasaSalarial = 0;
            HorasMaximasTrabajadas = 0;
        }




    }
}
