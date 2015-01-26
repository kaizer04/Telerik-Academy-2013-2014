namespace BunnyCraft.Services.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Description;
    using BunnyCraft.Data;
    using BunnyCraft.Models;

    public class BunniesController : ApiController
    {
        private BunnyDbContext db = new BunnyDbContext();

        // GET: api/Bunnies
        public IQueryable<Bunny> GetBunnies()
        {
            return db.Bunnies;
        }

        // GET: api/Bunnies/5
        [ResponseType(typeof(Bunny))]
        public IHttpActionResult GetBunny(int id)
        {
            Bunny bunny = db.Bunnies.Find(id);
            if (bunny == null)
            {
                return NotFound();
            }

            return Ok(bunny);
        }

        // PUT: api/Bunnies/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutBunny(int id, Bunny bunny)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != bunny.Id)
            {
                return BadRequest();
            }

            db.Entry(bunny).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BunnyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Bunnies
        [ResponseType(typeof(Bunny))]
        public IHttpActionResult PostBunny(Bunny bunny)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Bunnies.Add(bunny);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = bunny.Id }, bunny);
        }

        // DELETE: api/Bunnies/5
        [ResponseType(typeof(Bunny))]
        public IHttpActionResult DeleteBunny(int id)
        {
            Bunny bunny = db.Bunnies.Find(id);
            if (bunny == null)
            {
                return NotFound();
            }

            db.Bunnies.Remove(bunny);
            db.SaveChanges();

            return Ok(bunny);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool BunnyExists(int id)
        {
            return db.Bunnies.Count(e => e.Id == id) > 0;
        }
    }
}