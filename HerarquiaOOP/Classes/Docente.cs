
namespace HerarquiaOOP.Classes
{
    public class Docente : Empleado
    {
        public string? Asigantura { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();

            Console.WriteLine($"Asignatura: { Asigantura}");
        }
    }
}
