using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaCarros.Models
{
    [Table("Cidades")]
    public class Cidade
    {
        [Key()]
        public int CidadeId { get; set; }        
        [Column(TypeName ="Varchar(50)")]
        public string Nome { get; set; }
        [Display(Name ="Ano de Fundação")]
        [Column(TypeName ="Integer")]
        public int AnoFundacao { get; set; }
        [NotMapped]
        public int Idade 
        {            
            get 
            { 
                DateTime Data = DateTime.Now;
                return Data.Year - this.AnoFundacao; 
            } 
        }
    }
}
