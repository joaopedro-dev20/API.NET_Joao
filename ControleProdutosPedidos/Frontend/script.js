const apiUrl = "https://localhost:5001/api/produtos"; // altere para a URL da sua API

// Função para listar produtos
async function listarProdutos() {
    const response = await fetch(apiUrl);
    const produtos = await response.json();

    const lista = document.getElementById("listaProdutos");
    lista.innerHTML = "";

    produtos.forEach(produto => {
        const li = document.createElement("li");
        li.textContent = `${produto.nome} - R$ ${produto.preco}`;
        li.onclick = () => deletarProduto(produto.id); // clique para deletar
        lista.appendChild(li);
    });
}

// Função para adicionar produto
async function adicionarProduto() {
    const nome = document.getElementById("nome").value;
    const preco = parseFloat(document.getElementById("preco").value);

    await fetch(apiUrl, {
        method: "POST",
        headers: { "Content-Type": "application/json" },
        body: JSON.stringify({ nome, preco })
    });

    listarProdutos();
}

// Função para deletar produto
async function deletarProduto(id) {
    await fetch(`${apiUrl}/${id}`, { method: "DELETE" });
    listarProdutos();
}

// Inicializa lista
listarProdutos();
