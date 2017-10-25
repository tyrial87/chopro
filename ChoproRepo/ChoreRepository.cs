using ChoproDat;
using ChoproRepo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChoproRepo
{
    public class ChoreRepository : IChoreRepository
    {
        private DataContext _context;

        public ChoreRepository(DataContext context)
        {
            _context = context;
        }

        public List<Chore> GetAll()
        {
            return _context.Chores.ToList();
        }

        public Chore GetChore(int ID)
        {
            return _context.Chores.FirstOrDefault(chore => chore.ID == ID);
        }

        public bool AddChore(Chore chore)
        {
            _context.Chores.Add(chore);

            try
            {
                _context.SaveChanges();
                return true;
            }
            catch
            {
                // TODO: Maybe some logging
                return false;
            }
        }
    }
}
