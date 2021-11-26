
/* Declaração de váriaveis*/

var enderecoProduto = "https://localhost:5001/Produtos/Produto/";
var produto;
/* */

/* Funções */
function preencherFormulario(dadosProduto) {
    $("#campoNome").val(dadosProduto.nome);
    $("#campoCategoria").val(dadosProduto.categoria.nome)
    $("#campoFornecedor").val(dadosProduto.fornecedor.nome)
    $("#campoPreco").val(dadosProduto.precoDeVenda);
    
}
/* */
$("#pesquisar").click(function() {
    var codProduto = $("#codProduto").val();
    var enderecoTemporario = enderecoProduto + codProduto;
    $.post(enderecoTemporario, function(dados, status) {
        produto = dados;
        console.log(produto)
        preencherFormulario(produto);
    }).fail(function(){
        alert("Produto inválido");
    })
})