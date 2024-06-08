using HerarquiaOOP.Classes;

List<Empleado> empleados = new List<Empleado>();

Empleado empleado = new Empleado();


Console.WriteLine("Ingrese el nombre: ");
empleado.Nombre = Console.ReadLine();

Console.WriteLine("Ingrese la edad: ");
empleado.Edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el deparatmaneto en el que trabaja:");
empleado.Departamento = Console.ReadLine();

empleado.MostrarInformacion();



