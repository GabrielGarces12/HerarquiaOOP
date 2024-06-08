
namespace HerarquiaOOP.Classes
{
    public class Administrador : Docente
    {
        public string? SeccionAdminstrativa { get; set; }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();

            Console.WriteLine($"Seccion Administrativa: { SeccionAdminstrativa}");
        }
    }
}
