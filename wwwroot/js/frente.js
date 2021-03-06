
/* Declaração de váriaveis*/

var enderecoProduto = "https://localhost:5001/Produtos/Produto/";
var enderecoGerarVenda = "https://localhost:5001/Produtos/gerarvenda/"
var produto;
var  compra = [];
var __totalVenda__ = 0.00;
/* */

/*Inicio*/




/* */ 
function atualizarTotal() {
    $("#totalVenda").html(__totalVenda__);
}

/* Funções */
function modalConfirmed() {
    $("#posvenda").show();
    $("#prevenda").hide();
    $("#valorTroco").prop("disabled", true);
    $("#valorPago").prop("disabled", true);
}

function restaurandoModal() {
    setTimeout(() => {
        $("#posvenda").hide();
        $("#prevenda").show();
        $("#valorTroco").prop("disabled", false);
        $("#valorPago").prop("disabled", false);
        $("#valorTroco").val("");
        $("#valorPago").val("");
    }, 1000);
    
}
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

function processaItensCompra() {
    compra.forEach(element =>{
        element.produto = element.produto.id
    })

    
}

function enviandoVenda(dataSend){
    $.ajax({
        type: "POST",
        url: enderecoGerarVenda,
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(dataSend),
        success: function(data) {
            console.log("Dados envados com sucesso");
            console.log(data);
        }
    })
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
    atualizarTotal();
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
    
    var _valorPago =  0.00;
    _valorPago = $("#valorPago").val()

    if(!isNaN(_valorPago)) { // isNan() -> Válida se existe um número, por mais que seja do tipo string ele valida se existe um número / Se não for um numero retorna verdadeiro se for um numero retorna falso.
        _valorPago = parseFloat(_valorPago);
        if(_valorPago >= __totalVenda__) {

            modalConfirmed();
            var _troco  = _valorPago - __totalVenda__;
            $("#valorTroco").val(_troco.toFixed(2));


            //Processar o meu array de compra
            processaItensCompra();

            // Preparando um novo objeto
            var _venda = {total: __totalVenda__, troco: _troco, produtos: compra}


            console.log("Antes de enviar")
            console.log(_venda)
            
            //Enviar dador par ao backend
            enviandoVenda(_venda);

        } else {
            alert("Valor pago inferior ao total da venda.")
            return;
        }
    } else {
        alert("Valor pago inválido.")
        return;
    }
})

/* Fechando Modal */
$("#fecharModal").click(function(){
    restaurandoModal();
})
