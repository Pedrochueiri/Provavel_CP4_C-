using ATV_CP1.Models;
using Microsoft.EntityFrameworkCore;

namespace ATV_CP1.Persistence.Repository
{
    public class RoupasRepository
    {
        private readonly OracleDbContext _dbContext;

        public RoupasRepository(OracleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Roupas GetById(int id)
        {
            return _dbContext.Roupas.Find(id);
        }

        public IEnumerable<Roupas> GetAll()
        {
            return _dbContext.Roupas.ToList();
        }

        public void Add(Roupas entity)
        {
            _dbContext.Roupas.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Update(Roupas entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(Roupas entity)
        {
            _dbContext.Roupas.Remove(entity);
            _dbContext.SaveChanges();
        }



    }
}
