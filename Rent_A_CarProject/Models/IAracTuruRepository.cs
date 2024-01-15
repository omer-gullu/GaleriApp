namespace GaleriApp.Models
{
    public interface IAracTuruRepository : IRepository<AracTuru>
    {
        void Guncelle(AracTuru aracTuru);
        void Kaydet();
    }
}
