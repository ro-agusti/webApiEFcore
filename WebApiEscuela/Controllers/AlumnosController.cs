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
    public class AlumnosController : ControllerBase
    {
        private readonly ProfesorDbContext context;
        public AlumnosController(ProfesorDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Alumno> Get()
        {
            return context.Alumnos.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Alumno> Get(int id)
        {
            return context.Alumnos.Find(id);
        }

        [HttpPost]
        public ActionResult Post(Alumno alumno)
        {
            context.Alumnos.Add(alumno);
            context.SaveChanges();
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, Alumno alumno)
        {
            if (id != alumno.ID)
            {
                return BadRequest();
            }
            context.Entry(alumno).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult<Alumno> Delete(int id)
        {
            Alumno alumno = context.Alumnos.Find(id);
            if (alumno == null)
            {
                return NotFound();
            }
            context.Alumnos.Remove(alumno);
            context.SaveChanges();
            return alumno;
        }

        [HttpGet("GetByEnrolment/{matricula}")]
        public IEnumerable<Alumno> GetByEnrolment(int matricula)
        {
            var alumnos = (from a in context.Alumnos
                           where a.Matricula == matricula
                           select a).ToList();
            return alumnos;
        }

        [HttpGet("GetByCity/{ciudad}")]
        public IEnumerable<Alumno> GetByEnrolment(string ciudad)
        {
            var alumnos = (from a in context.Alumnos
                           where a.Ciudad == ciudad
                           select a).ToList();
            return alumnos;
        }

    }
}
