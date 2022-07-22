using BiblioDataInfo.VO;

namespace BiblioDataInfo.IRepository
{
    public interface ILivroRepository
    {
        Task<IEnumerable<LivroVO>> FindAll();
        Task<LivroVO> FindById(long id);
        Task<LivroVO> Create(LivroVO vo);
        Task<LivroVO> Update(LivroVO vo);
        Task<bool> Delete(long id);
    }
}
