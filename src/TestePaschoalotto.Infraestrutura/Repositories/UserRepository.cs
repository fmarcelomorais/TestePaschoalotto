using Microsoft.EntityFrameworkCore;
using TestePaschoalotto.Domain.Interface;
using TestePaschoalotto.Domain.Model;
using TestePaschoalotto.Infraestrutura.Context;

namespace TestePaschoalotto.Infraestrutura.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<User> Create(User entity)
        {
            await _context.Users.AddAsync(entity);
            var ok = _context.SaveChanges();
            if(ok > 0)
            {
                var user = _context.Users.AsNoTracking().FirstOrDefault(u => u.FirstName.Equals(entity.FirstName));
                return user;
            }
            throw new Exception(message: "Erro ao Cadastrar Usuário");
        }

        public async Task<List<User>> GetAll()
        {
            return await _context.Users.AsNoTracking()
                .Include(nav => nav.Login)
                .Include(nav => nav.Contacts)
                .Include(nav => nav.Location)
                .Include(nav => nav.Naturalization)
                .Include(nav => nav.Picture)
                .ToListAsync();
        }

        public async Task<User> Update(User entity)
        {
           _context.Entry(entity).State = EntityState.Modified;
            var user = _context.Users.FirstOrDefault(u => u.FirstName.Equals(entity.FirstName));
            return user;
        }
    }
}
