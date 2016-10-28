using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Fiap.Exemplo01.MVC.Web.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public decimal Credito { get; set; }

        [Display(Name = "Possui necessidades especiais?")]
        public bool NecessidadesEspeciais { get; set; }

        [Display(Name = "Estado civil")]
        public string EstadoCivil { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
