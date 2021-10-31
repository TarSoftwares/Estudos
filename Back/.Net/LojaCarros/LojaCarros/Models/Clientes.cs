using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaCarros.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key()]
        public int ClientesId { get; set; }
        [Required]
        [Display(Name ="Nome")]
        [Column("Nome",TypeName ="Varchar(50)")]
        public string Nome { get; set; }
        [Display(Name = "Data de Nascimento")]
        [Column("DataNascimento",TypeName ="DateTime")]
        public DateTime DataNascimento { get; set; }
        [Column("Telefone",TypeName ="Varchar(20)")]
        public string Telefone { get; set; }
        [NotMapped]
        public int Idade
        {
            get { 
              DateTime Data = DateTime.Now;             
              return  Convert.ToInt32(Data.Subtract(this.DataNascimento).TotalDays) / 365;
            }
        }
    }
}
