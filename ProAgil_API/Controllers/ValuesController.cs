using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProAgil_API.Data;
using ProAgil_API.Model;

namespace ProAgil_API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase {

        #region HEADERS

        public readonly DataContext _context;

        public ValuesController(DataContext context) {
            _context = context;
        }

        #endregion

        #region GET ALL

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get() {
            try {
                var results = await _context.Eventos.ToListAsync();
                return Ok(results);
            }
            catch (Exception) {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao buscar dados!");
            }
            
        }

        #endregion

        #region GET

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Evento>> Get(int id) {
            try {
                var result = await _context.Eventos.FirstOrDefaultAsync(x => x.EventoId == id);
                return Ok(result);
            }
            catch (Exception) {

                return StatusCode(StatusCodes.Status500InternalServerError, "dados não encontrados!");
            }            
        }

        #endregion

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
