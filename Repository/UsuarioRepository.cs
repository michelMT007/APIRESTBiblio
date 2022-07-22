using AutoMapper;
using BiblioDataInfo.Context;
using BiblioDataInfo.IRepository;
using BiblioDataInfo.Model;
using BiblioDataInfo.VO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Threading.Tasks;
namespace BiblioDataInfo.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AplicacaoContext _context;
        private IMapper _mapper;
        public UsuarioRepository(AplicacaoContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<IEnumerable<UsuarioVO>> FindAll()
        {
            List<Usuario> usuarios = await _context.Usuarios.ToListAsync();
            return _mapper.Map<List<UsuarioVO>>(usuarios);
        }
        public async Task<UsuarioVO> FindById(long id)
        {
            Usuario usuario = await _context.Usuarios.Where(p => p.Id == id)
                .FirstOrDefaultAsync();
            return _mapper.Map<UsuarioVO>(usuario);
        }
        public async Task<UsuarioVO> Create(UsuarioVO vo)
        {
            Usuario usuario = _mapper.Map<Usuario>(vo);
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return _mapper.Map<UsuarioVO>(usuario);
        }

        public async Task<bool> Delete(long id)
        {
            try
            {
                var usuario = await _context.Usuarios.Where(u => u.Id == id).FirstOrDefaultAsync();
                if (usuario ==null) {
                    return false;
                }
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
                
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public async Task<UsuarioVO> Update(UsuarioVO vo)
        {
            Usuario usuario= _mapper.Map<Usuario>(vo);
            _context.Usuarios.Update(usuario);
            await _context.SaveChangesAsync();
            return _mapper.Map<UsuarioVO>(usuario);
        }
    }
}
