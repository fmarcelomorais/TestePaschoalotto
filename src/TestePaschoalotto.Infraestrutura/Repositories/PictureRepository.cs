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
    public class PictureRepository : IPictureRepository
    {
        private readonly ApplicationContext _context;
        public PictureRepository(ApplicationContext context)
        {
            _context = context;   
        }
        public async Task<Picture> Create(Picture entity)
        {
            await _context.Pictures.AddAsync(entity);
            var ok = _context.SaveChanges();
            if (ok > 0)
            {
                var picture = await _context.Pictures.FirstOrDefaultAsync(pic => pic.Thumbnail.Equals(entity.Thumbnail));
                return picture;
            }
            throw new Exception(message: "Erro ao Cadastrar Imagem");
        }

        public async Task<List<Picture>> GetAll()
        {
            return await _context.Pictures.AsNoTracking().ToListAsync();
        }

        public async Task<Picture> Update(Picture entity)
        {
            _context.Entry<Picture>(entity).State = EntityState.Modified;
            var ok = _context.SaveChanges();
            if (ok > 0)
            {
                var picture = await _context.Pictures.FirstOrDefaultAsync(pic => pic.Thumbnail.Equals(entity.Thumbnail)); ;
                return picture;
            }
            throw new Exception(message: "Erro ao Cadastrar Imagem");
        }
    }
}
