using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Loja.Models;

namespace Loja.Banco
{
    public class BancoDados : DbContext
    {
        public BancoDados(DbContextOptions<BancoDados> options) : base(options)
        {            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseInMemoryDatabase(databaseName :"BancoDados");
        public DbSet<Cliente> Clientes{get;set;} 
    }

}