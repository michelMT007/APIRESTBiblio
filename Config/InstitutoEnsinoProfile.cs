using AutoMapper;
using BiblioDataInfo.Model;
using BiblioDataInfo.VO;

namespace BiblioDataInfo.Config
{
    public class InstitutoEnsinoProfile : Profile
    {
        public InstitutoEnsinoProfile()
        {
            CreateMap<InstituicaoEnsino, InstituicaoEnsinoVO>();
            CreateMap<InstituicaoEnsinoVO, InstituicaoEnsino>();
        }
    }
}
