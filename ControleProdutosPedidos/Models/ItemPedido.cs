namespace ControleProdutosPedidos.Models;

// Representa um item em um pedido
public class ItemPedido 
{
    public int ProdutoId { get; set; }  // Identificador do produto
    public int Quantidade { get; set; } // Quantidade do produto no pedido
}
