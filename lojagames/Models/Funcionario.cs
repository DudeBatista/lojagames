using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lojagames.Models
{
    public class Funcionario
    {
        [Required(ErrorMessage = "Campo Obrigatório")]
        public ushort FuncCod {get;set;}
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string FuncNome { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string FuncCPF { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string FuncRG { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FuncDataNasc { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string FuncEndereco { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string FuncCelular { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string FuncEmail { get; set; }
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string FuncCargo { get; set; }

    }
}