using AutoMapper;
using BiblioDataInfo.Model;
using BiblioDataInfo.VO;

namespace BiblioDataInfo.Config
{
    public class EmprestimoProfile : Profile
    {
        public EmprestimoProfile()
        {
            CreateMap<Emprestimo, EmprestimoVO>();
            CreateMap<EmprestimoVO, Emprestimo>();
        }
    }
}
