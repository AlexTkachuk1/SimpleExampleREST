using InnoGotchi.DAL.EF;
using InnoGotchi.DAL.Entities.Base;
using InnoGotchi.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoGotchi.DAL.Repositories.Base
{
    public sealed class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly InnoGotchiDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(InnoGotchiDbContext context)
        {
            _context = context;
            _entities = _context.Set<T>();
        }

        public IEnumerable<T> GetAll() => _entities;

        public T Get(int id) => _entities.SingleOrDefault(user => user.Id == id);

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Insert entity exception");
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Update entity exception");
            _entities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null) throw new ArgumentNullException("Delete entity exception");
            _entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
