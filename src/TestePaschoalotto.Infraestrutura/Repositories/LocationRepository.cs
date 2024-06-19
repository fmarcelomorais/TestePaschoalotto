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
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationContext _context;
        public LocationRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task<Location> Create(Location entity)
        {
           await _context.Locations.AddAsync(entity);
            var ok = _context.SaveChanges();
            if (ok > 0)
            {
                var localization = _context.Locations.FirstOrDefault(loc => loc.OffSet.Equals(entity.OffSet));
                return localization;
            }
            throw new Exception(message: "Erro ao Cadastrar Localização");
        }

        public async Task<List<Location>> GetAll()
        {
            return await _context.Locations.AsNoTracking().ToListAsync();
        }

        public async Task<Location> Update(Location entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            var ok = _context.SaveChanges();
            if (ok > 0)
            {
                var localization = await _context.Locations.FirstOrDefaultAsync(loc => loc.OffSet.Equals(entity.OffSet));
                return localization;
            }
            throw new Exception(message: "Erro ao Cadastrar Localizacao");
        }
    }
}
