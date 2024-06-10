using HerarquiaOOP.Classes;

List<Maestro> maestros = new List<Maestro>();

Maestro maestro = new Maestro();

Console.WriteLine("Ingrese el Nombre Completo: ");
maestro.NombreCompleto = Console.ReadLine();

Console.WriteLine("Ingrese la edad: ");
maestro.Edad = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el deparatmaneto en el que trabaja:");
maestro.Departamento = Console.ReadLine();

Console.WriteLine("Ingrese la Asignatura: ");
maestro.Asigantura = Console.ReadLine();

Console.WriteLine("Ingrese el nivel educativo: ");
maestro.NivelEducativo = Console.ReadLine();

maestro.MostrarInformacion();




