using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade.API.Models
{
    public class apiModels
    {
        public int id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public prioridade Prioridade { get; set; }
    }
}