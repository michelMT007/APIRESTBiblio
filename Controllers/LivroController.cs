using BiblioDataInfo.VO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using BiblioDataInfo.IRepository;

namespace BiblioDataInfo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private ILivroRepository _repository;
        public LivroController(ILivroRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<LivroVO>>> FindAll()
        {
            var livros = await _repository.FindAll();
            if (livros == null) return NotFound();
            return Ok(livros);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<LivroVO>> FindById(long id)
        {
            var livro = await _repository.FindById(id);
            if (livro == null) return NotFound();
            return Ok(livro);
        }

        [HttpPost]
        public async Task<ActionResult<LivroVO>> Create([FromBody] LivroVO vo)
        {
            if (vo == null) return BadRequest();

            return Ok(await _repository.Create(vo));
        }
        [HttpPut]
        public async Task<ActionResult<LivroVO>> Update([FromBody] LivroVO vo)
        {
            if (vo == null) return BadRequest();
            var livro = await _repository.Update(vo);
            return Ok(livro);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }

        
    }
}
