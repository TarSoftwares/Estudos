using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaCarros.Models
{
    [Table("Carros")]
    public class Carro
    {
        //Teste de Versionamento
        [Key()] 
        public int CarroId { get; set; }
        [MaxLength(50)]
        [Column("Nome",TypeName="Varchar")]
        public string Nome { get; set; }
        [Display(Name = "Ano de Fabricação")]
        [Column("Ano",TypeName="Integer")]
        public int Ano { get; set; }
        [ForeignKey("MarcaId")]
        public int MarcaId {  get; set; }
        public virtual Marca Marca { get; set; }
    }
}
