using System;
namespace Problem11.Repositories
{
    public interface IAngajatRepository : ICrudRepository<int, Angajat>
    {
        bool LocalLogin(String username, String password);
    }
}
