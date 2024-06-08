
namespace HerarquiaOOP.Classes
{
    public class Empleado : MiembroDeLaComunidad
    {
        public string? Departamento { get; set; }

        public override void MostrarInformacion()
        {
            
            Console.WriteLine($"Departamento: { Departamento}");
        }
    }
}
