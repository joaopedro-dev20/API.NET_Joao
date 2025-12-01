using ControleProdutosPedidos.Models;

namespace ControleProdutosPedidos.Repositories;

// Repositório responsável por armazenar e gerenciar os produtos em memória
public static class ProdutoRepository
{
    // Lista estática que irá armazenar os produtos
    // Usamos static para manter o mesmo estado em toda a aplicação enquanto ela roda.

    private static List<Produto> produtos = new();
    private static int proximoId = 1; // Controle de ID automáticos

    // Retorna todos os produtos cadastrados
    public static List<Produto> GetAll() => produtos;

    // Busca um produto pelo ID, retorna null se nao tiver
    // ? significa retorno podendo ser NULL
    public static Produto? GetById(int id) =>
        produtos.FirstOrDefault(p => p.Id == id);

    // Adiciona um novo produto ao sistema e drefine um ID único para ele
    public static Produto Add(Produto produto)
    {
        produto.Id = proximoId++;
        produtos.Add(produto);
        return produto;
    }
}
