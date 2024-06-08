
namespace HerarquiaOOP.Classes
{
    public class Administrativo : Empleado
    {
        public string? Puesto { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();

            Console.WriteLine($"Puesto: { Puesto}");
        }
    }
}
