namespace ControleProdutosPedidos.Models;

// Representa um produto no catálogo da loja
public class Produto
{
    public int Id { get; set; }  // Identificador único
    public string Nome { get; set; } = string.Empty; // Nome do produto
    public string Descricao { get; set; } = string.Empty; // Descrição do produto
    public decimal Preco { get; set; } // Preço do produto
    public int Estoque { get; set; } 
}
