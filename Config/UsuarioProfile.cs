using AutoMapper;
using BiblioDataInfo.Model;
using BiblioDataInfo.VO;


namespace BiblioDataInfo.Config
{
    public class UsuarioProfile:Profile
    {
        public UsuarioProfile()
        {
            CreateMap<Usuario, UsuarioVO>();
            CreateMap<UsuarioVO, Usuario>();
        }
    }
}
