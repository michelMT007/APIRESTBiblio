using AutoMapper;
using BiblioDataInfo.Context;
using BiblioDataInfo.IRepository;
using BiblioDataInfo.Model;
using BiblioDataInfo.VO;
using Microsoft.EntityFrameworkCore;

namespace BiblioDataInfo.Repository
{
    public class InstituicaoEnsinoRepository : IInstituicaoEnsinoRepository
    {
        private readonly AplicacaoContext _context;
        private IMapper _mapper;
        public InstituicaoEnsinoRepository(AplicacaoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<InstituicaoEnsinoVO> Create(InstituicaoEnsinoVO vo)
        {
            InstituicaoEnsino instituicaoensino = _mapper.Map<InstituicaoEnsino>(vo);
            _context.InstituicoesEnsino.Add(instituicaoensino);
            await _context.SaveChangesAsync();
            return _mapper.Map<InstituicaoEnsinoVO>(instituicaoensino);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                var ensino = await _context.InstituicoesEnsino.FindAsync(id);
                if (ensino == null) { return false; }
                _context.InstituicoesEnsino.Remove(ensino);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<IEnumerable<InstituicaoEnsinoVO>> FindAll()
        {
            var instituicaoensinos = await _context.InstituicoesEnsino.ToListAsync();
            return _mapper.Map<List<InstituicaoEnsinoVO>>(instituicaoensinos);
        }

        public async Task<InstituicaoEnsinoVO?> FindById(long id)
        {
            var institutoensino = await _context.InstituicoesEnsino.Where(ie => ie.Id == id).FirstOrDefaultAsync();
            if (institutoensino != null) {
                return _mapper.Map<InstituicaoEnsinoVO>(institutoensino);
            }
            return null;
        }

        public async Task<InstituicaoEnsinoVO> Update(InstituicaoEnsinoVO vo)
        {
            InstituicaoEnsino ie = _mapper.Map<InstituicaoEnsino>(vo);
            _context.InstituicoesEnsino.Update(ie);
            await _context.SaveChangesAsync();
            return _mapper.Map<InstituicaoEnsinoVO>(ie);
        }
    }
}
