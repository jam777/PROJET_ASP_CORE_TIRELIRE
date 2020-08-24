$(document).ready(function () {

    var state = parseInt($("#statusPanier").text());

    if (state == 1) {

        $("#modalPanier").modal('show')
    }















    /* var frm = $("form"); 
     frm.submit(function (e) {
         e.preventDefault();
         $.ajax({
             type: frm.attr("method"),
             url: frm.attr("action"),
             contentType: 'text/plain-text',
             dataType: 'html',
             success: function (result) {
                 alert("ok");
                 console.log('ok');
             },
             error: function (jqxhr, textstatus) {
                 alert(jqxhr.responseText);
                 console.log("erreur")
             }
         });//Ajax
     });//click ajout panier*/


});//document