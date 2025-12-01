namespace ControleProdutosPedidos.Models;

// Representa um pedido feito por um cliente
public class Pedido
{
    public int Id { get; set; } // Identificador único do pedido
    public string NomeCliente { get; set; } = string.Empty; // Nome do cliente que fez o pedido
    public List<ItemPedido> Itens { get; set; } = new(); // Lista de itens no pedido
    public DateTime Data { get; set; } = DateTime.Now; // Data do pedido
}
