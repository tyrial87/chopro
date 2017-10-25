using ChoproDat;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChoproRepo.Interfaces
{
    interface IChoreRepository
    {
        List<Chore> GetAll();
        Chore GetChore(int ID);
        bool AddChore(Chore chore);
    }
}
