using BiblioDataInfo.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace BiblioDataInfo.IRepository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<UsuarioVO>> FindAll();
        Task<UsuarioVO> FindById(long id);
        Task<UsuarioVO> Create(UsuarioVO vo);
        Task<UsuarioVO> Update(UsuarioVO vo);
        Task<bool> Delete(long id);
    }
}
