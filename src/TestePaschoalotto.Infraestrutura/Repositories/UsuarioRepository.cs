﻿
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
            _context.SaveChanges();
            return entity;
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await _context.Users
                .AsNoTracking()
                .Include(name => name.Name)
                .Include(location => location.Location)
                .Include(coordinates => coordinates.Location.Coordinates)
                .Include(street => street.Location.Street)
                .Include(timezone => timezone.Location.Timezone)
                .Include(login => login.Login)
                .Include(dob => dob.Dob)
                .Include(registered => registered.Registered)
                .Include(picture => picture.Picture)
                .Include(id => id.Identity)
                .ToListAsync();
        }

        public Task<Usuario> Update(Usuario entity)
        {
            throw new NotImplementedException();
        }
    }
}
