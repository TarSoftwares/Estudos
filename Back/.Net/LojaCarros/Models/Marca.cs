using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaCarros.Models
{
    [Table("Marcas")]
    public class Marca
    {
        [Key()]
        public int MarcaId { get; set; }
        [Display(Name ="Nome")]
        [MaxLength(50)]
        [Column("Nome",TypeName ="Varchar")]
        public string Nome { get; set; }
        public virtual List<Carro> Carros { get; set; }
    }
}
