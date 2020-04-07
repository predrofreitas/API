using System;
using System.Collections.Generic;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FundoCapitalController: Controller
    {
        [HttpGet("/v1/fundocapital")]
        public IActionResult ListarFundos()
        {
            return Ok(
                new List<FundoCapital>{
                    new FundoCapital(){
                        Nome = "Viagem de Férias",
                        ValorNecessario = 5000,
                        ValorAtual = 2000,
                        DataResgate = new DateTime(2020, 12, 01)
                    },

                    new FundoCapital(){
                        Nome = "Comprar Moto",
                        ValorNecessario = 12000,
                        ValorAtual = 300,
                        DataResgate = new DateTime(2021, 01, 10)
                    },

                    new FundoCapital(){
                        Nome = "Ir para Comic Con",
                        ValorNecessario = 2000,
                        ValorAtual = 300,
                        DataResgate = new DateTime(2020, 12, 09)
                    }
                }
            );
        }

        [HttpPost("v1/fundocapital")]
        public IActionResult AdicionarFundo([FromBody]FundoCapital fundo)
        {
            return Ok();
        }

        [HttpPut("v1/fundocapital/{id}")]
        public IActionResult AlterarFundo([FromBody]FundoCapital fundo, Guid id)
        {
            return Ok();
        }

        [HttpGet("v1/fundocapital/{id}")]
        public IActionResult ObterFundo(Guid id)
        {
            return Ok(
                new FundoCapital(){
                    Nome = "Viagem de Férias",
                    ValorNecessario = 5000,
                    ValorAtual = 2000,
                    DataResgate = new DateTime(2020, 12, 01)
                }
            );
        }

        [HttpDelete("v1/fundocapital/{id}")]
        public IActionResult DeletarFundo(Guid id)
        {
            return Ok();
        }
    }
}