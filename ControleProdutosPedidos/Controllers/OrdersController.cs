using Microsoft.AspNetCore.Mvc;
using ControleProdutosPedidos.Models;

namespace ControleProdutosPedidos.Controllers;

[ApiController]
[Route("orders")]
public class OrdersController : ControllerBase
{
    // Lista que guarda todos os pedidos feitos
    private static List<Pedido> _pedidos = new();
    private static int _ultimoId = 1;

    // -------------------------------------------------------------
    // POST /orders -> cria um pedido
    // -------------------------------------------------------------
    [HttpPost]
    public ActionResult<Pedido> CriarPedido(Pedido pedido)
    {
        // Valida estoque para todos os itens do pedido
        foreach (var item in pedido.Itens)
        {
            var produto = ProductsController.BuscarProduto(item.ProdutoId);

            if (produto == null)
                return BadRequest($"Produto com ID {item.ProdutoId} não existe.");

            if (produto.Estoque < item.Quantidade)
                return BadRequest($"Estoque insuficiente para o produto: {produto.Nome}.");
        }

        // Se passou da validação, diminui o estoque
        foreach (var item in pedido.Itens)
        {
            ProductsController.AtualizarEstoque(item.ProdutoId, item.Quantidade);
        }

        pedido.Id = _ultimoId++;
        pedido.Data = DateTime.Now;

        _pedidos.Add(pedido);

        return Ok(pedido);
    }
}
