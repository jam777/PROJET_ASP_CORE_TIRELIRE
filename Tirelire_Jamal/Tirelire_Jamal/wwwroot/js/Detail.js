$(document).ready(function () {

    var state = parseInt($("#statusPanier").text());

    if (state == 1) {

        $("#modalPanier").modal('show')
    }

});//document