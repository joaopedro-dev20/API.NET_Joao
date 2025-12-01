using ControleProdutosPedidos.Models;


var builder = WebApplication.CreateBuilder(args);

// Adiciona os serviços necessários para usar controllers
builder.Services.AddControllers();

/* Adiciona o Swagger/OpenAPI para documentação automática. 

Eu tentei utilizar, mas há um erro de compatibilidadecom a versão .NET 9, o que eu estou usando.


*/

var app = builder.Build();

/* 

Eu tentei utilizar, mas há um erro de compatibilidadecom a versão .NET 9, o que eu estou usando.

// Ativa o swagger apenas no ambiente de desenvolvimento
*/

// Reconduz requisições HTTP para HTTPS 
app.UseHttpsRedirection();

// Habilita o roteamento dos Controllers
app.MapControllers();

// Inicia o servidor
app.Run();
