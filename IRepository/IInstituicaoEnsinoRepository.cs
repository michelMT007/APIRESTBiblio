using BiblioDataInfo.VO;

namespace BiblioDataInfo.IRepository
{
    public interface IInstituicaoEnsinoRepository
    {
        Task<IEnumerable<InstituicaoEnsinoVO>> FindAll();
        Task<InstituicaoEnsinoVO> FindById(long id);
        Task<InstituicaoEnsinoVO> Create(InstituicaoEnsinoVO vo);
        Task<InstituicaoEnsinoVO> Update(InstituicaoEnsinoVO vo);
        Task<bool> Delete(long id);
    }
}
