using GaleriApp.Context;

namespace GaleriApp.Models
{
    public class AracTuruRepository : Repository<AracTuru>, IAracTuruRepository
    {
        private DataContext _context;
        public AracTuruRepository(DataContext dataContext) : base(dataContext)
        {
            _context = dataContext;
        }

        public void Guncelle(AracTuru aracTuru)
        {
           _context.Update(aracTuru);
        }

        public void Kaydet()
        {
            _context.SaveChanges();
        }
    }
}
