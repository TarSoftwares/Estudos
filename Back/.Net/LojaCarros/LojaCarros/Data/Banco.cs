using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LojaCarros.Models;

    public class Banco : DbContext
    {
        public Banco (DbContextOptions<Banco> options) : base(options)
        {
        }

        public DbSet<LojaCarros.Models.Marca> Marca { get; set; }

        public DbSet<LojaCarros.Models.Carro> Carro { get; set; }

        public DbSet<LojaCarros.Models.Cliente> Cliente { get; set; }

        public DbSet<LojaCarros.Models.Cidade> Cidade { get; set; }
    }
