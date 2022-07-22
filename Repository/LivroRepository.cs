using AutoMapper;
using BiblioDataInfo.Context;
using BiblioDataInfo.IRepository;
using BiblioDataInfo.Model;
using BiblioDataInfo.VO;
using Microsoft.EntityFrameworkCore;

namespace BiblioDataInfo.Repository
{
    public class LivroRepository : ILivroRepository
    {
        private readonly AplicacaoContext _context;
        private IMapper _mapper;
        public LivroRepository(AplicacaoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<LivroVO> Create(LivroVO vo)
        {
            Livro livro = _mapper.Map<Livro>(vo);
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();
            return _mapper.Map<LivroVO>(livro);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                var livro = await _context.Livros.FindAsync(id);
                if(livro == null) { return false; }
                _context.Livros.Remove(livro);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<IEnumerable<LivroVO>> FindAll()
        {
            var livros = await _context.Livros.ToListAsync();
            return _mapper.Map<List<LivroVO>>(livros);
        }

        public async Task<LivroVO> FindById(long id)
        {
            var livro = await _context.Livros.Where(l => l.Id == id)
            .FirstOrDefaultAsync();
            return _mapper.Map<LivroVO>(livro);
        }

        public async Task<LivroVO> Update(LivroVO vo)
        {
            Livro livro= _mapper.Map<Livro>(vo);
            _context.Livros.Update(livro);
            await _context.SaveChangesAsync();
            return _mapper.Map<LivroVO>(livro);
        }
    }
}
