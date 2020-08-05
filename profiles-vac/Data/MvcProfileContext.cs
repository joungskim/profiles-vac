using Microsoft.EntityFrameworkCore;
using profiles_vac.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace profiles_vac.Data
{
    public class MvcProfileContext : DbContext
    {
        public MvcProfileContext(DbContextOptions<MvcProfileContext> options)
            : base(options)
        {
        }

        public DbSet<Profile> Profile { get; set; }
    }
}
