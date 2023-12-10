using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Notificacoes;

namespace Entities.Entidades
{
    // a classe base agora possui todas as caracteristicas do notifica com a lista de mensagens
    public class Base : Notifica
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
