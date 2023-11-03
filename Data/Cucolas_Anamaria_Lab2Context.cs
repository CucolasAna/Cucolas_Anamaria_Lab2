using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cucolas_Anamaria_Lab2.Models;

namespace Cucolas_Anamaria_Lab2.Data
{
    public class Cucolas_Anamaria_Lab2Context : DbContext
    {
        public Cucolas_Anamaria_Lab2Context (DbContextOptions<Cucolas_Anamaria_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cucolas_Anamaria_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cucolas_Anamaria_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
