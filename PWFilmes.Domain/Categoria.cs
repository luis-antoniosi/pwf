using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PWFilmes.Domain
{
    [Table("TB_Categoria")]
    public class Categoria
    {
        [Key]
        [Required(ErrorMessage = "O Código deve ser informado.")]
        public int Codigo { get; set; }


        [Required(ErrorMessage = "A Descrição deve ser informada.")]
        [MaxLength(100, ErrorMessage = "A Descrição deve conter no " +
            "máximo 100 caracteres.")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A Cor deve ser informada.")]
        [MaxLength(50, ErrorMessage = "A Cor deve conter no " +
            "máximo 50 caracteres.")]
        public string Cor { get; set; }
    }
}
