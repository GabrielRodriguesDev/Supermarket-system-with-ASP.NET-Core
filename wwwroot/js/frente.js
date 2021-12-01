
/* Declaração de váriaveis*/

var enderecoProduto = "https://localhost:5001/Produtos/Produto/";
var produto;
var compra = [];
var __totalVenda__ = 0.00;
/* */

/*Inicio*/
atualizarTotal();


/* */ 
function atualizarTotal() {
    $("#totalVenda").html(__totalVenda__);
}

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

    var venda = {produto: produtoTemp, quantidade: q, subtotal: produtoTemp.precoDeVenda * q}
    compra.push(venda) // Adicionando no array

    __totalVenda__ += venda.subtotal;
    atualizarTotal()
    
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

$('#finalizarCompra').click(function () {
    $('#myModal').modal('toggle');
})




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

/* Finalizar venda */
$("#finalizarVendaBtn").click( function(){

    if (__totalVenda__ <= 0) {
        alert("Compra inválida, nenhum produto adicionado.")
        return;
    }

    var _valorPago = $("#valorPago").val()

    if(!isNaN(_valorPago)) { // isNan() -> Válida se existe um número, por mais que seja do tipo string ele valida se existe um número / Se não for um numero retorna verdadeiro se for um numero retorna falso.
        _valorPago = parseFloat(_valorPago);
        if(_valorPago >= __totalVenda__) {
            console.log(_valorPago);
            console.log("Salve")
        } else {
            alert("Valor pago inferior ao total da venda.")
            return;
        }
    } else {
        alert("Valor pago inválido.")
        return;
    }
})
