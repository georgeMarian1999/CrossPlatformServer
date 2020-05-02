using System;
using System.Collections.Generic;
using Problem11.Model;

namespace Problem11.Repositories
{
    public interface IEchipaRepository : ICrudRepository<int, Echipa>
    {
        int FindIdByName(String nume);
        List<DTOBJPart> cautare(String numeEchipa);
    }
}
