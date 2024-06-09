
namespace HerarquiaOOP.Classes
{
    public abstract class MiembroDeLaComunidad
    {
        public string?  Nombre { get; set; }
        public int Edad { get; set; }
        public abstract void MostrarInformacion(); 
        
    }
}
