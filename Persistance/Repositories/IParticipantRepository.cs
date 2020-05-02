using System;
using Problem11.Model;

namespace Problem11.Repositories
{
    public interface IParticipantRepository : ICrudRepository<int, Participant>
    {
        int FindMaxId();
    }
}
