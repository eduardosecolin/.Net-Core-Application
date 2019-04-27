using Microsoft.EntityFrameworkCore;
using ProAgil_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProAgil_API.Data {

    public class DataContext : DbContext {

        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Evento> Eventos { get; set; }
    }
}
