using Microsoft.AspNetCore.Mvc;
using ControleProdutosPedidos.Models;

namespace ControleProdutosPedidos.Controllers;

// Define que este arquivo é um controller de API
[ApiController]
[Route("products")]
public class ProductsController : ControllerBase
{
    // Lista que simula um banco de dados (memória)
    private static List<Produto> _produtos = new();
    private static int _ultimoId = 1; // Controla os IDs automáticos

    // -------------------------------------------------------------
    // POST /products -> cadastra um novo produto
    // -------------------------------------------------------------
    [HttpPost]
    public ActionResult<Produto> CriarProduto(Produto produto)
    {
        produto.Id = _ultimoId++; // Gera ID automático
        _produtos.Add(produto);   // Salva o produto na lista

        return CreatedAtAction(nameof(ObterProdutoPorId), new { id = produto.Id }, produto);
    }

    // -------------------------------------------------------------
    // GET /products -> lista todos os produtos
    // -------------------------------------------------------------
    [HttpGet]
    public ActionResult<List<Produto>> ListarProdutos()
    {
        return Ok(_produtos);
    }

    // -------------------------------------------------------------
    // GET /products/{id} -> busca um produto específico
    // -------------------------------------------------------------
    [HttpGet("{id}")]
    public ActionResult<Produto> ObterProdutoPorId(int id)
    {
        var produto = _produtos.FirstOrDefault(p => p.Id == id);

        if (produto == null)
            return NotFound("Produto não encontrado.");

        return Ok(produto);
    }

    // -------------------------------------------------------------
    // Método auxiliar usado pelo OrdersController
    // -------------------------------------------------------------
    public static Produto? BuscarProduto(int id)
    {
        return _produtos.FirstOrDefault(p => p.Id == id);
    }

    // Atualiza estoque após pedidos
    public static void AtualizarEstoque(int produtoId, int quantidade)
    {
        var produto = BuscarProduto(produtoId);
        if (produto != null)
        {
            produto.Estoque -= quantidade;
        }
    }
}
