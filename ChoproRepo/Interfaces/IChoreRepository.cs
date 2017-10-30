using ChoproDat.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChoproRepo.Interfaces
{
    public interface IChoreRepository
    {
        List<Chore> GetAll();
        Task<Chore> GetChore(int ID);
        bool AddChore(Chore chore);
    }
}
