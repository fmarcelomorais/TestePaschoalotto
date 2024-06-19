using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestePaschoalotto.Domain.Interface;
using TestePaschoalotto.Domain.Model;
using TestePaschoalotto.Infraestrutura.Context;

namespace TestePaschoalotto.Infraestrutura.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        private readonly ApplicationContext _context;
        public LoginRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Login> Create(Login entity)
        {
            await _context.Logins.AddAsync(entity);
            var ok = _context.SaveChanges();
            if (ok > 0)
            {
                var login = _context.Logins.FirstOrDefault(log => log.Email.Equals(entity.Email));
                return login;
            }
            throw new Exception(message: "Erro ao Cadastrar Login");
        }

        public async Task<List<Login>> GetAll()
        {
            return await _context.Logins.AsNoTracking().ToListAsync();
        }

        public async Task<Login> Update(Login entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            var ok = _context.SaveChanges();
            if (ok > 0)
            {
                var login = await _context.Logins.FirstOrDefaultAsync(log => log.Email.Equals(entity.Email));
                return login;
            }
            throw new Exception(message: "Erro ao Cadastrar Login");
        }
    }
}
