
namespace HerarquiaOOP.Classes
{
    public class Maestro : Docente
    {
        public string? NivelEducativo { get; set; } = "Primaria / Secundaria";

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();

            Console.WriteLine($"Nivel Educativo: { NivelEducativo}");
        }
    }
}
