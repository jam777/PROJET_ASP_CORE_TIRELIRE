/*
 * Permettre un effet accordeon sur un text
 * Element à cliquer aura id="slide"
 * Le texte un id="texteSlide"
 * Dans Tirelire.css  : 2 classes 
 * #slide.up:after  : fleche haute
 * #slide.down:after :fleche basse
 */

$(document).ready(function () {

    $(".slide").click(function (e) {
        e.preventDefault();
        $(this).parent().next().slideToggle();
        $(this).toggleClass('up down');
    });//slide

}); //document