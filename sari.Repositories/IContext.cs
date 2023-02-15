using Microsoft.EntityFrameworkCore;
using Milgot.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milgot.Repositories
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }

        DbSet<Children> Childrens { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
