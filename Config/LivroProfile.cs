using AutoMapper;
using BiblioDataInfo.Model;
using BiblioDataInfo.VO;

namespace BiblioDataInfo.Config
{
    public class LivroProfile : Profile
    {
        public LivroProfile()
        {
            CreateMap<Livro, LivroVO>();
            CreateMap<LivroVO, Livro>();
        }
    }
}
