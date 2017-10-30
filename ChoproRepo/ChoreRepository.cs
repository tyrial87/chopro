using ChoproDat;
using ChoproDat.Entities;
using ChoproRepo.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public async Task<Chore> GetChore(int ID)
        {
            return await _context.Chores.SingleOrDefaultAsync(chore => chore.ID == ID);
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
