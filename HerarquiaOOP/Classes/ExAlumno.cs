
namespace HerarquiaOOP.Classes
{
    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AnioGraduacion { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();

            Console.WriteLine($"Anio de Graduacion: { AnioGraduacion}");
        }
    }
}
