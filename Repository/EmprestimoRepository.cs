
using Microsoft.EntityFrameworkCore;
using BiblioDataInfo.Context;
using BiblioDataInfo.IRepository;
using BiblioDataInfo.Model;
using BiblioDataInfo.VO;
using AutoMapper;

namespace BiblioDataInfo.Repository 
{
    public class EmprestimoRepository : IEmprestimoRepository
    {
        private readonly AplicacaoContext _context;
        private IMapper _mapper;

        public EmprestimoRepository(AplicacaoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }
        public async Task<IEnumerable<EmprestimoVO>> FindAll()
        {
            var emprestimos = await _context.Emprestimos.ToListAsync();
            return _mapper.Map<List<EmprestimoVO>>(emprestimos);
        }

        public async Task<EmprestimoVO> FindById(long id)
        {
            Emprestimo emprestimo = await _context.Emprestimos.Where(l => l.Id == id).FirstOrDefaultAsync();
            var RretornoEmprestimo = _mapper.Map<EmprestimoVO>(emprestimo);
            return RretornoEmprestimo;
        }
        public async Task<EmprestimoVO> Create(EmprestimoVO vo)
        {
            Emprestimo emprestimo = _mapper.Map<Emprestimo>(vo);
            _context.Emprestimos.Add(emprestimo);
            await _context.SaveChangesAsync();

            return _mapper.Map<EmprestimoVO>(emprestimo);
        }
        public async Task<EmprestimoVO> EmprestimoLivros(EmprestimoVO vo)
        {
            Emprestimo emprestimo = _mapper.Map<Emprestimo>(vo);
            _context.Emprestimos.Add(emprestimo);
            await _context.SaveChangesAsync();

            return _mapper.Map<EmprestimoVO>(emprestimo);
        }
        public async Task<bool> Delete(long id)
        {
            try
            {
                var emprestimo = await _context.Emprestimos.FindAsync(id);
                if (emprestimo == null) { return false; }
                _context.Emprestimos.Remove(emprestimo);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<EmprestimoVO> Update(EmprestimoVO vo)
        {
            Emprestimo emprestimo = _mapper.Map<Emprestimo>(vo);
            _context.Emprestimos.Update(emprestimo);
            await _context.SaveChangesAsync();
            return _mapper.Map<EmprestimoVO>(emprestimo);
        }

        
    }
}
