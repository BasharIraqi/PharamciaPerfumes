using PharamaciaEntities.Interfaces;

namespace PharamaciaEntities.Repositories
{
    public class GenericRepository<T> : IDisposable,IGenericRepository<T> where T : class
    {
        private  PharamaciaPerfumesContext _context;

        public GenericRepository()
        {
            _context=new PharamaciaPerfumesContext();
        }

        public void Add(T Entity)
        {
           _context.Set<T>().Add(Entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IEnumerable<T> GetAll()
        {
           return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
