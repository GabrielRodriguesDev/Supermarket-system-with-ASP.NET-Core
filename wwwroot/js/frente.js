
/* Declaração de váriaveis*/

var enderecoProduto = "https://localhost:5001/Produtos/Produto/";
var produto;
var compra = [];
/* */

/* Funções */
function preencherFormulario(dadosProduto) {
    $("#campoNome").val(dadosProduto.nome);
    $("#campoCategoria").val(dadosProduto.categoria.nome)
    $("#campoFornecedor").val(dadosProduto.fornecedor.nome)
    $("#campoPreco").val(dadosProduto.precoDeVenda);
    
}

function zerarFormulario () {
    $("#codProduto").val("")
    $("#campoNome").val("");
    $("#campoCategoria").val("")
    $("#campoFornecedor").val("")
    $("#campoPreco").val("");
    $("#campoQuantidade").val("");
}


function adicionarNaTabela(p,q) {
    var produtoTemp = {}; // Criando um variavel que vai receber um Objeto (clonado)
    Object.assign(produtoTemp, produto);// Clonando o objeto em uma instancia nova
    compra.push(produtoTemp) // Adicionando no array
    $("#compras").append(`
    <tr>
    <td>${p.id}</td>
    <td>${p.nome}</td>
    <td>${q}</td>
    <td>${p.precoDeVenda}</td>
    <td>${p.medicao}</td>
    <td>${p.precoDeVenda * q}</td>
    <td><button class="btn btn-danger"> Remover </button></td>
</tr>
    `);
}

$("#produtoForm").on("submit", function(event){
    event.preventDefault();
    console.log("Antes");
    console.log(produto);
    var produtoParaTabela = produto;

    var qtd = $("#campoQuantidade").val();
    if(qtd <= 0) {
        alert("Informe a quantidade.")
    } else {
        //produto = undefined;
        adicionarNaTabela(produtoParaTabela,qtd);
        zerarFormulario();
    }
});


/*Ajax */
$("#pesquisar").click(function() {
    var codProduto = $("#codProduto").val();
    var enderecoTemporario = enderecoProduto + codProduto;
    $.post(enderecoTemporario, function(dados, status) {
        produto = dados;
        var med = "";
        switch (produto.medicao) {
            case 0:
                med = "LT";
                break;
            case 1:
                med = "KG";
                break;
            case 2:
                med = "UND";
                break;
            default:
                med = "UND";
                break;
        }
        produto.medicao = med;
        preencherFormulario(produto);
    }).fail(function(){
        alert("Produto inválido");
        $("#codProduto").val("")
    })
})