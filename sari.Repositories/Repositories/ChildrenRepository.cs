using Microsoft.EntityFrameworkCore;
using Milgot.Repositories.Entities;
using Milgot.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Repositories.Repositories
{
    public class ChildrenRepository:IChildrenRepository
    {
        readonly IContext _context;

        public ChildrenRepository(IContext context)
        {
            _context = context;
        }

        public async Task<Children> AddAsync(Children c)
        {
            //var temp = new Children {Name=name,BirthDate=date,Tz=tz,Idparent=idParent};
            _context.Childrens.Add(c);
            await _context.SaveChangesAsync();
            return c;
        }

        public async Task DeleteAsync(int id)
        {
            var user = await GetByIdAsync(id);
            _context.Childrens.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Children>> GetAllAsync()
        {
            return await _context.Childrens.Include(p => p.Parent).ToListAsync();

            //return await _context.Childrens.ToListAsync();
        }

        public async Task<Children> GetByIdAsync(int id)
        {
            //return await _context.Childrens.Include(p => p.Idparent).FirstOrDefaultAsync(p => p.ChildId == childId);

            return await _context.Childrens.FindAsync(id);
        }

        public async Task<Children> UpdateAsync(Children children)
        {
            var t = _context.Childrens.Update(children);
            await _context.SaveChangesAsync();
            return t.Entity;
        }
    }
}
