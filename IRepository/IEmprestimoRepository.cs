using BiblioDataInfo.Model;
using BiblioDataInfo.VO;

namespace BiblioDataInfo.IRepository
{
    public interface IEmprestimoRepository
    {
        Task<IEnumerable<EmprestimoVO>> FindAll();
        Task<EmprestimoVO> FindById(long id);
        Task<EmprestimoVO> Create(EmprestimoVO vo);
        Task<EmprestimoVO> Update(EmprestimoVO vo);
        Task<bool> Delete(long id);
        Task<EmprestimoVO> EmprestimoLivros(EmprestimoVO vo);
    }
}

