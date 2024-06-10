
namespace HerarquiaOOP.Classes
{
    public abstract class MiembroDeLaComunidad
    {
        public string?  NombreCompleto { get; set; }
        public int Edad { get; set; }
        public abstract void MostrarInformacion();
        
    }
}
