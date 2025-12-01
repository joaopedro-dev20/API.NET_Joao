using ControleProdutosPedidos.Models;

namespace ControleProdutosPedidos.Repositories;

// Repositório responsável por armazenar e gerenciar os produtos em memória
public static class ProdutoRepository
{
    // Lista estática que funciona como "banco de dados" de produtos
    private static List<Produto> produtos = new();
    private static int proximoId = 1; // Controle de IDs automáticos

    // Retorna todos os produtos cadastrados
    public static List<Produto> GetAll() => produtos;

    // Busca um produto pelo ID
    public static Produto? GetById(int id) =>
        produtos.FirstOrDefault(p => p.Id == id);

    // Adiciona um novo produto ao sistema
    public static Produto Add(Produto produto)
    {
        produto.Id = proximoId++;
        produtos.Add(produto);
        return produto;
    }
}
