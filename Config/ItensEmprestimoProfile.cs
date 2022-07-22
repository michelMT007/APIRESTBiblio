using AutoMapper;
using BiblioDataInfo.Model;
using BiblioDataInfo.VO;

namespace BiblioDataInfo.Config
{
    public class ItensEmprestimoProfile:Profile
    {
        public ItensEmprestimoProfile()
        {
            CreateMap<ItensEmprestimo, ItensEmprestimoVO>();
            CreateMap<ItensEmprestimoVO, ItensEmprestimo>();
        }
    }
}
