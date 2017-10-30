using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChoproDat.Entities;
using ChoproRepo.Interfaces;

namespace Chopro.Controllers
{
    [Produces("application/json")]
    [Route("api/Chores")]
    public class ChoresController : Controller
    {
        private readonly IChoreRepository _choreRepo;

        public ChoresController(IChoreRepository choreRepository)
        {
            _choreRepo = choreRepository;
        }

        // GET: api/Chores
        [HttpGet]
        public IEnumerable<Chore> GetChores()
        {
            return _choreRepo.GetAll();
        }

        // GET: api/Chores/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChore([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var chore = await _choreRepo.GetChore(id);

            if (chore == null)
            {
                return NotFound();
            }

            return Ok(chore);
        }

        //// PUT: api/Chores/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutChore([FromRoute] int id, [FromBody] Chore chore)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != chore.ID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(chore).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ChoreExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Chores
        //[HttpPost]
        //public async Task<IActionResult> PostChore([FromBody] Chore chore)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.Chores.Add(chore);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetChore", new { id = chore.ID }, chore);
        //}

        //// DELETE: api/Chores/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteChore([FromRoute] int id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var chore = await _context.Chores.SingleOrDefaultAsync(m => m.ID == id);
        //    if (chore == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Chores.Remove(chore);
        //    await _context.SaveChangesAsync();

        //    return Ok(chore);
        //}

        //private bool ChoreExists(int id)
        //{
        //    return _context.Chores.Any(e => e.ID == id);
        //}
    }
}