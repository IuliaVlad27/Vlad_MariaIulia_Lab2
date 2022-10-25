using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vlad_MariaIulia_Lab2.Models;

namespace Vlad_MariaIulia_Lab2.Data
{
    public class Vlad_MariaIulia_Lab2Context : DbContext
    {
        public Vlad_MariaIulia_Lab2Context (DbContextOptions<Vlad_MariaIulia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Vlad_MariaIulia_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
