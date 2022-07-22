using AutoMapper;
using BiblioDataInfo.Model;
using BiblioDataInfo.VO;

namespace BiblioDataInfo.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<Usuario, UsuarioVO>();
                config.CreateMap<UsuarioVO, Usuario>();

            });
            return mappingConfig;
        }
    }
}
