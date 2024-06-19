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
    public class ContactRepository : IContactRepository
    {
        private readonly ApplicationContext _context;
        public ContactRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Contact> Create(Contact entity)
        {
            await _context.Contacts.AddAsync(entity);
            var ok = _context.SaveChanges();
            if (ok > 0)
            {
                var contact = await _context.Contacts
                    .AsNoTracking()
                    .FirstOrDefaultAsync(c => c.Cell .Equals(entity.Cell));
                return contact;
            }
            throw new Exception(message: "Erro ao Cadastrar Contato");
        }

        public async Task<List<Contact>> GetAll()
        {
            return await _context.Contacts
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Contact> Update(Contact entity)
        {
            _context.Entry<Contact>(entity).State = EntityState.Modified;
            var contact = await _context.Contacts.FirstOrDefaultAsync(u => u.Cell.Equals(entity.Cell));
            return contact;
        }
    }
}
