$(document).ready(function () {

    var sel = $("select")
   

    sel.on('change', function (e) {
        e.stopPropagation();
        e.preventDefault();
        var quantiteJS = this.value;
        var sel1 = $(this);
        var uri = sel1.attr("data-url");
        $.ajax({
            type: "post",
            url: uri,
            data: { "quantite": quantiteJS },
            dataType: 'json',
            success: function (result) {
                var cible = sel1.parentsUntil("table").find("td");

                $(".nbProduit").html(result.quantiteTotal);
                cible.find("span#ssTotal").html(result.ssTotal);
                cible.find("#date").html(result.date);
                $("#totalPanier").html(result.total);


            },
            error: function (jqxhr, textstatus, Error) {
                alert("Status : " + textstatus + "\nError : " + Error);
            }
        });//Ajax
    });//sekect quantite produit


});//document