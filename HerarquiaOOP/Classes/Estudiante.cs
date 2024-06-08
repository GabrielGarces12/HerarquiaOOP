
namespace HerarquiaOOP.Classes
{
    public class Estudiante : MiembroDeLaComunidad
    {
        public string? Carrera { get; set; }

        public override void MostrarInformacion()
        {
            Console.WriteLine($"Carrera: { Carrera}");
        }
    }
}
