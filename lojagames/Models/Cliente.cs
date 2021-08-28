using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lojagames.Models
{
    public class Cliente
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string CliNome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string CliCPF { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime CliDataNasc { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string CliEmail { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string CliCelular { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string CliEndereco { get; set; }
    }
}