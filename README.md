README.md
Controle de Produtos e Pedidos – João Pedro Campos

API simples para gestão de produtos e pedidos, utilizando armazenamento em memória (sem banco de dados) e com suporte integrado a Swagger.

Tecnologias Utilizadas

.NET 8

ASP.NET Core Web API

Swagger / Swashbuckle

🚀 Como Executar o Projeto
1. Clonar o repositório
git clone <URL_DO_REPOSITORIO>
cd ControleProdutosPedidos

2. Restaurar dependências
dotnet restore

3. Executar a aplicação
dotnet run

4. Acessar o Swagger

Abra no navegador:

http://localhost:5097/swagger


(O número da porta pode variar; verifique no console após rodar o projeto.)

📌 Endpoints da API
Produtos
Método	Rota	Descrição
GET	/products	Lista todos os produtos
GET	/products/{id}	Busca produto por ID
POST	/products	Cria um novo produto
PUT	/products/{id}	Atualiza produto
DELETE	/products/{id}	Remove produto
Pedidos
Método	Rota	Descrição
GET	/orders	Lista todos os pedidos
GET	/orders/{id}	Busca pedido por ID
POST	/orders	Cria um novo pedido
📄 Exemplos de Uso (curl)
1. Criar um produto
curl -X POST http://localhost:5097/products \
-H "Content-Type: application/json" \
-d "{
  \"nome\": \"Notebook Lenovo\",
  \"preco\": 3500.00
}"

2. Listar produtos
curl http://localhost:5097/products

3. Criar um pedido
curl -X POST http://localhost:5097/orders \
-H "Content-Type: application/json" \
-d "{
  \"nomeCliente\": \"João Pedro\",
  \"itens\": [
    { \"produtoId\": 1, \"quantidade\": 2 },
    { \"produtoId\": 3, \"quantidade\": 1 }
  ]
}"

4. Listar pedidos
curl http://localhost:5097/orders

📚 Usando a API via Swagger

Execute:

dotnet run


Vá para:

http://localhost:5097/swagger


Escolha um endpoint

Clique em Try it out

Preencha os dados

Clique em Execute

O Swagger mostrará:

requisição enviada

resposta da API

código HTTP

📝 Observações

Os dados são armazenados somente em memória, então se reiniciar a aplicação, tudo é apagado.
