namespace BunnyCraft.Services.Controllers
{
    using BunnyCraft.Data.Repositories;
    using BunnyCraft.Models;
    using BunnyCraft.Services.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public class AirCraftsController : ApiController
    {
        private IRepository<AirCraft> airCrafts;
        private IRepository<Bunny> bunnies;

        public AirCraftsController()
            : this(new Repository<AirCraft>(), new Repository<Bunny>())
        { 
        }

        public AirCraftsController(IRepository<AirCraft> aircrafts, IRepository<Bunny> bunnies)
        {
            this.airCrafts = aircrafts;
            this.bunnies = bunnies;
        }

        [HttpGet]
        public IHttpActionResult All()
        {
            var aircrafts = this.airCrafts.All().Select(AirCraftModel.FromAirCraft);
            
            return Ok(aircrafts);
        }

        [HttpPost]
        public IHttpActionResult Create(AirCraftModel airCraft)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newAirCraft = new AirCraft
            {
                Model = airCraft.Model
            };

            this.airCrafts.Add(newAirCraft);
            this.airCrafts.SaveChanges();

            airCraft.Id = newAirCraft.Id;

            return Ok(airCraft);
        }

        [HttpPut]
        public IHttpActionResult Update(int id, AirCraftModel airCraft)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existingAirCraft = this.airCrafts.All().FirstOrDefault(a => a.Id == id);
            if (existingAirCraft == null)
            {
                return BadRequest("Such aircraft does not exists!");
            }

            existingAirCraft.Model = airCraft.Model;
            this.airCrafts.SaveChanges();

            airCraft.Id = existingAirCraft.Id;
            return Ok(airCraft);
        }

        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var existingAirCraft = this.airCrafts.All().FirstOrDefault(a => a.Id == id);
            if (existingAirCraft == null)
            {
                return BadRequest("Such aircraft does not exists!");
            }

            this.airCrafts.Delete(existingAirCraft);
            this.airCrafts.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult AddBunny(int id, int bunnyId)
        {
            //var airCraft = this.airCrafts.All().FirstOrDefault(a => a.Id == id);
            //if (airCraft == null)
            //{
            //    return BadRequest("Such aircraft does not exists - invalid id!");
            //}

            var bunny = this.bunnies.All().FirstOrDefault(b => b.Id == bunnyId);
            if (bunny == null)
            {
                return BadRequest("Such bunny does not exists - invalid id!");
            }

            bunny.AirCraftId = id;
            this.bunnies.SaveChanges();

            return Ok();
        }
    }
}
