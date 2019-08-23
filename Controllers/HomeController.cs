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
    public class HomeController : ControllerBase
    {
        //private AnimalShelterContext _db = new AnimalShelterContext();
        
        
        // GET api/animals
        [HttpGet]
        public ActionResult<int[]> Get()
        {
            int[] arr = new int[]{4, 2, 5,4 };
            return arr;
        }

        // POST api/values
        // [HttpPost]
        // public void Post([FromBody] Animal animal)
        // {
        //     _db.Animals.Add(animal);
        //     _db.SaveChanges();
        // }
    }
}