using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SWMedicos.Data;
using SWMedicos.Models;
using Microsoft.EntityFrameworkCore;

namespace SWMedicos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly MedicoDbContext context;
        public MedicoController(MedicoDbContext context)
        {
            this.context = context;
        }
       // GET: Traer todos los médicos
       [HttpGet]
       public IEnumerable<Medico> Get()
        {
            return context.Medicos.ToList();
        }

        //GET: Traer por Id
        [HttpGet("{id}")]
        public ActionResult<Medico> Get(int id)
        {
            return context.Medicos.Find(id);
        }

        //POST: Guardar un médico
        [HttpPost]
        public ActionResult Post(Medico medico)
        {
            context.Medicos.Add(medico);
            context.SaveChanges();
            return Ok();
        }

        //PUT: Modificar Médico
        [HttpPut("{id}")]
        public ActionResult Put(int id, Medico medico)
        {
            if (id != medico.ID)
            {
                return BadRequest();
            }
            context.Entry(medico).State = EntityState.Modified;
            context.SaveChanges();
            return Ok();
        }

        // DELETE: Eliminar Médico
        [HttpDelete("{id}")]
        public ActionResult<Medico> Delete(int id)
        {
            Medico medico = context.Medicos.Find(id);
            if (medico == null)
            {
                return NotFound();
            }
            context.Medicos.Remove(medico);
            context.SaveChanges();
            return medico;
        }

        //GET: Traer médicos por Especialidad
        [HttpGet("GetByspeciality/{speciality}")]//endpoint
        public IEnumerable<Medico> GetByEspeciality(string speciality)
        {
            var medicos = (from m in context.Medicos
                          where m.Especialidad == speciality
                           select m).ToList();
            return medicos;
        }
    }
}
