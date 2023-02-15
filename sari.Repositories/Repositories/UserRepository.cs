using Microsoft.EntityFrameworkCore;
using Milgot.Repositories.Entities;
using Milgot.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Repositories.Repositories
{
    public class UserRepository:IUserRepository
    {
        private readonly IContext _context;

        public UserRepository(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User u)
        {
            //if (_context.Details.Count(u => u.Tz == tz) == 1)
            //    throw new Exception("משתמש קיים");
            _context.Users.Add(u);
            await _context.SaveChangesAsync();
            return u;
        }

        public async Task DeleteAsync(int id)
        {
            var user = await GetByIdAsync(id);
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User details)
        {
            var t = _context.Users.Update(details);
            await _context.SaveChangesAsync();
            return t.Entity;
        }



        


    }
}
