using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Atividade.API.Models;
using Atividade.API.Data;

namespace Atividade.API.Controllers
{
    [Route("[controller]")]
    public class atividadeApi : Controller
    {
        private readonly DataContext context;

        public atividadeApi(DataContext context) { this.context = context; }

        [HttpGet]        
        public IEnumerable<apiModels> get()
        {
            return context.Atividades;
        }

        [HttpGet("{id}")]        
        public apiModels get(int id)
        {
            return context.Atividades.FirstOrDefault(ati => ati.id == id);
        }

        [HttpPost]        
        public IEnumerable<apiModels> Post(apiModels Atividade)
        {
            context.Atividades.Add(Atividade);
            if(context.SaveChanges() > 0)
                return context.Atividades;
            else
                throw new Exception("Você não conseguiu adicionar a atividade");

        }        
        
        [HttpPut("{id}")]        
        public apiModels Put(int id, apiModels atividade)
        {
            if (atividade.id != id)
                throw new Exception("Você está tentando atualizar a atividade errada");
            context.Update(atividade);
            if(context.SaveChanges() > 0)
                return context.Atividades.FirstOrDefault(ativ => ativ.id == id);
            else
                return new apiModels();

        }

        [HttpDelete("{id}")]        
        public bool Delete(int id)
        {
            var atividade = context.Atividades.FirstOrDefault(ativ => ativ.id == id);
            if (atividade == null)
                throw new Exception("Atividade não existe");
            context.Remove(atividade);

            return context.SaveChanges() > 0;
        }
    }
}