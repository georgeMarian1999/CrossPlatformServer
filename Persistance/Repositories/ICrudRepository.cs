using System;
namespace Problem11.Repositories
{
    public interface ICrudRepository<ID, E>
    {
        //int size();
        E findOne(ID id);
        void save(E entity);
        void delete(ID id);

    }
}
