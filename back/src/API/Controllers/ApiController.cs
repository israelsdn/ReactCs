using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public Atividade get(){
            return new Atividade();
        }

        [HttpGet("{id}")]
        public string get(int id){
            return $"Meu get com id: {id}";
        }

        [HttpPost]
        public Atividade post(Atividade atividade){
            atividade.id = 10;
            return atividade;
        }

        [HttpPut]
        public string put(){
            return "Meu put";
        }

        [HttpDelete]
        public string delete(){
            return "Meu delete";
        }

    }
}