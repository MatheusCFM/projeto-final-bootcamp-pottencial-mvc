using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tech_test_payment_api.Context;
using tech_test_payment_MVC.Models;

namespace tech_test_payment_MVC.Controllers
{
    //INÍCIO DA API CONTROLLER E SUA ROTA DE OPERAÇÕES
    [ApiController]
    [Route("[controller]")]
    public class VendaController : Controller
    {
        private readonly OrganizadorVendaMvcContext _context;

        public VendaController(OrganizadorVendaMvcContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var vendas = _context.Vendas.ToList();
            return View(vendas);
        }
        public IActionResult RegistrarVenda()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarVenda(Venda venda)
        {
            if (ModelState.IsValid)
            {
                _context.Vendas.Add(venda);
                _context.SaveChanges();
                return View(venda);
            }
            return View(venda);
        }

        // 1ª OPERAÇÃO - OBTER VENDA POR ID
        // [HttpGet("ObterVendaPorId")]
        // public IActionResult ObterVendaPorId(int id)
        // {
        //     var venda = _context.Vendas.Find(id);

        //     if (venda == null)
        //         return RedirectToAction(nameof(Index));
        //     return View(venda);
        // }

        // // 1ª OPERAÇÃO - OBTER VENDA POR ID
        // [HttpGet("ObterVendaPorId")]        
        // public async Task<Venda> GetVendasAsync(int id)
        // {
        //     return await _context.Vendas
        //         .Include(p => p.ItemVendido)
        //         .Include(p => p.Vendedor)
        //         .SingleOrDefaultAsync(p => p.Id == id);
        // //É IMPORTANTE USAR O Include PARA QUE APAREÇAM OS ITENS VENDIDOS
        // //                      E OS DADOS DO VENDEDOR NA CONSULTA POR ID
        // }

        // 2ª OPERAÇÃO - REGISTRAR VENDA
        //         [HttpPost("RegistrarVenda")]
        //         public  IActionResult RegistrarVenda(Venda venda)
        //         {
        //             //ATUALIZA OS VALORES NO BANCO DE DADOS
        //             _context.Add(venda);
        //             _context.SaveChanges();
        //             return View(venda);
        //         }


        //         // 3ª OPERAÇÃO - REGISTRAR VENDA
        //         [HttpPut("AtualizarStatusVenda")]
        //         public IActionResult AtualizarVenda(int id, StatusVenda novoStatus)
        //         {
        //             var vendaAtualizacao = _context.Vendas.Find(id);
        //             if (vendaAtualizacao == null)
        //                 return NotFound();
        //             var statusVenda = vendaAtualizacao.Status;

        //             if (statusVenda == StatusVenda.Entregue)
        //                 return BadRequest(new { Erro = "Venda já finalizada e produtos entregues" });

        //             else if (statusVenda == StatusVenda.Cancelada)
        //                 return BadRequest(new { Erro = "Venda já cancelada" });

        //             //JÁ VERIFICADO SE O STATUS ATUAL É CANCELADO OU ENTREGUE, O QUE IMPOSSIBILITARIA A ATUALIZAÇÃO

        //             else
        //             {
        //                 //RESPEITANDO AS CONDIÇÕES INFORMADAS NO README.md PARA REALIZAR A ATUALIZAÇÃO DO STATUS

        //                 if (statusVenda == StatusVenda.Aguardando_Pagamento)
        //                 {
        //                     if (novoStatus == StatusVenda.Pagamento_Aprovado || novoStatus == StatusVenda.Cancelada)
        //                     {
        //                         statusVenda = novoStatus;
        //                     }
        //                     else
        //                         return Ok("Atualização impossível no momento");
        //                 }
        //                 else if (statusVenda == StatusVenda.Pagamento_Aprovado)
        //                 {
        //                     if (novoStatus == StatusVenda.Enviado_Para_Transportadora || novoStatus == StatusVenda.Cancelada)
        //                     {
        //                         statusVenda = novoStatus;
        //                     }
        //                     else
        //                         return Ok("Atualização impossível no momento");
        //                 }

        //                 else if (statusVenda == StatusVenda.Enviado_Para_Transportadora)
        //                 {
        //                     if (novoStatus == StatusVenda.Entregue)
        //                     {
        //                         statusVenda = novoStatus;
        //                     }
        //                     else
        //                         return Ok("Atualização impossível no momento");
        //                 }

        //             //ATUALIZANDO O BANCO DE DADOS E RETORNANDO O NOVO STATUS
        //             vendaAtualizacao.Status = statusVenda;
        //             _context.Vendas.Update(vendaAtualizacao);
        //             _context.SaveChanges();
        //             return View($"Status atualizado: {statusVenda}");
        //             }
        //         }
    }	}
