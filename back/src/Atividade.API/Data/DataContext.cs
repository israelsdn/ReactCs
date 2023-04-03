using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Atividade.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<apiModels> Atividades { get; set; }
    }
}