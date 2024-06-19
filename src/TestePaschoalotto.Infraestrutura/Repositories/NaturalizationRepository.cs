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
    public class NaturalizationRepository : INaturalizationRepository
    {
        private readonly ApplicationContext _context;
        public NaturalizationRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Naturalization> Create(Naturalization entity)
        {
            await _context.Naturalizations.AddAsync(entity);
            var ok = _context.SaveChanges();
            if (ok > 0)
            {
                var naturalization = _context.Naturalizations.FirstOrDefault(nat => nat.Nat.Equals(entity.Nat));
                return naturalization;
            }
            throw new Exception(message: "Erro ao Cadastrar Naturalização");
        }

        public async Task<List<Naturalization>> GetAll()
        {
            return await _context.Naturalizations.AsNoTracking().ToListAsync();
        }

        public async Task<Naturalization> Update(Naturalization entity)
        {
            _context.Entry<Naturalization>(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            var naturalization = await _context.Naturalizations.FirstOrDefaultAsync(nat => nat.Nat.Equals(entity.Nat));
            return naturalization;
        }
    }
}
