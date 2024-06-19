
using Microsoft.EntityFrameworkCore;
using TestePaschoalotto.Domain.Interface;
using TestePaschoalotto.Domain.Model;
using TestePaschoalotto.Infraestrutura.Context;

namespace TestePaschoalotto.Infraestrutura.Repositories
{
    public class UsuarioRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        public UsuarioRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Usuario> Create(Usuario entity)
        {
            await _context.Users.AddAsync(entity); 
            return entity;
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await _context.Users.ToListAsync();
        }

        public Task<Usuario> Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
