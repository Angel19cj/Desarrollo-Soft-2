using ManejoEmpleado;



    Empleado empleado = new Empleado();



while (true)
{
    Console.WriteLine("\n--- Menú de Gestión de Empleados ---");
    Console.WriteLine("1. Agregar un empleado");
    Console.WriteLine("2. Modificar datos del empleado");
    Console.WriteLine("3. Eliminar un empleado");
    Console.WriteLine("4. Mostrar empleados");
    Console.WriteLine("5. Salir \n");
    Console.Write("Seleccione una opción: ");

    int opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {

        case 1:
            empleado.agregarEmpleado();
            break;
        case 2:
            empleado.modificarEmpleado();
            break;
        case 3:
            empleado.eliminarEmpleado();
            break;
        case 4:
            empleado.mostrarEmpleado();
            break;
        case 5:
            Console.WriteLine("Gracias por utilizar nuestro sistema");
            return;

    }
}
  

