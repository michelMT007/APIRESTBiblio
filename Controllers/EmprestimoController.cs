using AutoMapper;
using BiblioDataInfo.Context;
using BiblioDataInfo.IRepository;
using BiblioDataInfo.VO;
using Microsoft.AspNetCore.Mvc;

namespace BiblioDataInfo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmprestimoController : ControllerBase
    {
        private readonly AplicacaoContext _context;
        private IMapper _mapper;
        private IEmprestimoRepository _repository;

        [HttpPost]
        public async Task<ActionResult<EmprestimoVO>> Create([FromBody] EmprestimoVO vo)
        {
            //if (lista == null) return BadRequest();
            if (vo == null) return BadRequest();
            return Ok(await _repository.EmprestimoLivros(vo));

            //return Ok(await _repository.Create(vo));
        }
    }
}
