
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BiblioDataInfo.VO;
using Microsoft.AspNetCore.Mvc;
using BiblioDataInfo.IRepository;

namespace BiblioDataInfo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private IUsuarioRepository _repository;
        public UsuarioController(IUsuarioRepository irepository)
        {
            _repository = irepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioVO>>> FindAll()
        {
            var usuarios = await _repository.FindAll();
            if (usuarios == null) return NotFound();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioVO>> FindById(long id)
        {
            var usuario = await _repository.FindById(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }


        [HttpPost]
        public async Task<ActionResult<UsuarioVO?>> Create(UsuarioVO vo)
        {
            if (vo == null) return BadRequest();
            
            return Ok(await _repository.Create(vo));
        }
        [HttpPut]
        public async Task<ActionResult<UsuarioVO>> Update([FromBody] UsuarioVO vo)
        {
            if(vo ==null) return BadRequest();
            var usuario = await _repository.Update(vo);
            return Ok(usuario);
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
