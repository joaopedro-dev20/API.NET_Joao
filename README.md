📦 API de Controle de Produtos e Pedidos

API feita em .NET 8 para gerenciar produtos e registrar pedidos, com atualização automática de estoque.

🚀 Como executar o projeto
1. Instale o .NET 8

Download oficial: https://dotnet.microsoft.com/

2. Entre na pasta do projeto
cd SeuProjeto

3. Execute a aplicação
dotnet run

4. Acesse o Swagger

Depois de rodar, abra no navegador:

https://localhost:7004/swagger


É por lá que você pode testar todos os endpoints de forma fácil.

📘 Endpoints da API
🛒 Produtos (/products)
➤ Criar produto

POST /products

Exemplo (JSON):

{
  "nome": "Coca-Cola",
  "preco": 8.50,
  "estoque": 50
}

➤ Listar todos os produtos

GET /products

➤ Buscar produto por ID

GET /products/{id}

📦 Pedidos (/orders)
➤ Criar pedido

POST /orders

Exemplo (JSON):

{
  "nomeCliente": "João Pedro",
  "itens": [
    {
      "produtoId": 1,
      "quantidade": 2
    }
  ]
}


A API:

valida se o produto existe

valida estoque

reduz o estoque após o pedido

➤ Listar todos os pedidos

GET /orders

🧪 Exemplos de uso com cURL
Criar um produto
curl -X POST "https://localhost:7004/products" \
-H "Content-Type: application/json" \
-d "{\"nome\":\"Coca-Cola\",\"preco\":8.50,\"estoque\":50}"

Criar um pedido
curl -X POST "https://localhost:7004/orders" \
-H "Content-Type: application/json" \
-d "{\"nomeCliente\":\"João\",\"itens\":[{\"produtoId\":1,\"quantidade\":2}]}"

🗂 Tecnologias utilizadas

.NET 8

ASP.NET Core Web API

Swagger (Swashbuckle)

✔ Sobre o projeto

Esse projeto foi desenvolvido para fins de estudo e para atender um teste técnico simples de API REST usando armazenamento em memória, CRUD de produtos e criação de pedidos com validação de estoque.
