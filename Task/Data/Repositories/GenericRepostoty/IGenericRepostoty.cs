namespace Task.Data.Repositories.GenericRepostoty
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        List<TEntity> GetAll();
        TEntity? GetById(Guid id);
        void Add(TEntity entity);
       
        void SaveChanges();
    }
}
