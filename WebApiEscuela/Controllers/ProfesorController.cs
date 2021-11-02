using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using WebApiEscuela.Data;
using WebApiEscuela.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiEscuela.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly ProfesorDbContext context;
        public ProfesorController(ProfesorDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Profesor> Get()
        {
            return context.Profesores.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Profesor> Get(int id)
        {
            return context.Profesores.Find(id);
        }

        [HttpPost]
        public ActionResult Post(Profesor profesor)
        {
            context.Profesores.Add(profesor);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Profesor profesor)
        {
            if (id != profesor.Id)
            {
                return BadRequest();
            }
            context.Entry(profesor).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Profesor> Delete(int id)
        {
            Profesor profesor = context.Profesores.Find(id);
            if (profesor == null)
            {
                return NotFound();
            }
            context.Profesores.Remove(profesor);
            context.SaveChanges();
            return profesor;
        }

        [HttpGet("GetByTitle/{title}")]
        public IEnumerable<Profesor> GetByTitle(string title)
        {
            var profesores = (from p in context.Profesores
                          where p.Titulo == title
                          select p).ToList();
            return profesores;
        }
    }
}
