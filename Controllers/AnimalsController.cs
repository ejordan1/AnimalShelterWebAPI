using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private AnimalShelterContext _db = new AnimalShelterContext();
        
        
        // GET api/animals
        [HttpGet]
        public ActionResult<IEnumerable<Animal>> Get()
        {
            return _db.Animals.ToList();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {
            _db.Animals.Add(animal);
            _db.SaveChanges();
        }
    }
}