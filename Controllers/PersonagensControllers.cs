using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projetoDBZ.data;
using projetoDBZ.models;

namespace projetoDBZ.Controllers
{
    [ApiController]
    [Route("api/[controler]")]
    public class PersonagensControllers : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public PersonagensControllers(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> AddPersonagem([FromBody] Personagem
        personagem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _appDbContext.DBZ.Add(personagem);
            await _appDbContext.SaveChangesAsync();


            return Created("PERSONGEM ADICIONADO COM SUCESSO",personagem);
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<Personagem>>> GetPersonagens()
        {
            var personagens = await _appDbContext.DBZ.ToListAsync();
            return Ok(personagens);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Personagem>> GetPersonagem(int id)
        {
            if (personagem == null)
            {
                return NotFound("Persongem nao encontrado");
            }
            var personagem = await _appDbContext.DBZ.FindAsync(id);
            return Ok(personagem);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePersonagem(int id, [FromBody] Personagem
          personagemAtualizado)
        {
            var personagemExistente = await _appDbContext.DBZ.FindAsync(id);

            if (personagemExistente == null)
            {
                return NotFound("Persongem nao encontrado");
            }
            _appDbContext.Entry(personagemExistente).CurrentValues.SetValues(personagemAtualizado);
            await _appDbContext.SaveChangesAsync();

            return StatusCode(201, personagemExistente);
        }        

            
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonagem(int id)
        {
            var personagem = await _appDbContext.DBZ.FindAsync(id);

            if (personagem == null)
            {
                return NotFound("Persongem nao encontrado");
            }
            _appDbContext.DBZ.Remove(personagem);
            await _appDbContext.SaveChangesAsync();

            return Ok("Personagem deletado com sucesso");
        }        

    }
   
}