using System;
using Problem11.Model;

namespace Problem11.Repositories
{
    public interface IInscriereRepository : ICrudRepository<int,Inscriere>
    {
        int FindMaxId();
    }
}
