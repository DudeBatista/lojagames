using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lojagames.Models
{
    public class Jogo
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public ushort JogoCod { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string JogoNome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string JogoVersao { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string JogoDesen { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime JogoGen { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string JogoFaixa { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string JogoPlataforma { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string JogoAno { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string JogoSinopse { get; set; }
    }
}