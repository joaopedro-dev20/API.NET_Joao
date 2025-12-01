using ControleProdutosPedidos.Models;

namespace ControleProdutosPedidos.Repositories;

// responsável por armazenar os pedidos em memória
public static class PedidoRepository
{
    // Lista estática que armazena os pedidos criados durante a execução da API.
    private static List<Pedido> pedidos = new();
    private static int proximoId = 1;

    // Retorna todos os pedidos cadastrados.
    public static List<Pedido> GetAll() => pedidos;

    // Adiciona um pedido já validado à lista
    public static Pedido Add(Pedido pedido)
    {
        pedido.Id = proximoId++;
        pedidos.Add(pedido);
        return pedido;
    }
}
