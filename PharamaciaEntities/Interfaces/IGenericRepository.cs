namespace PharamaciaEntities.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        T GetT(T entity);
        void Delete(T entity);
        void Update(T entity);
        void Add(T Entity);
        void Save();
    }
}
