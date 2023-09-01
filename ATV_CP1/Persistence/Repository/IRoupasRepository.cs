using ATV_CP1.Models;

namespace ATV_CP1.Persistence.Repository
{
    public interface IRoupasRepository
    {
        Roupas GetById(int id);
        IEnumerable<Roupas> GetAll();
        void Add(Roupas entity);
        void Update(Roupas entity);
        void Delete(Roupas entity);
    }
}
