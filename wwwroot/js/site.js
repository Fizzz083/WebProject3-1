// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



$(function () {
    var slideIndex = 0;
    showSlides();

    function showSlides() {
        var i;
        var slides = document.getElementsByClassName("mySlides");
        document.getElementById("show").innerHTML = slideIndex;
        var dots = document.getElementsByClassName("dot");
        for (i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        slideIndex++;
        for (i = 0; i < dots.length; i++) {
            dots[i].className = dots[i].className.replace(" active", "");
          }
          
        if (slideIndex >= slides.length) { slideIndex = 0 }
        slides[slideIndex].style.display = "block";
        dots[slideIndex].className += " active";
        setTimeout(showSlides, 3000); // Change image every 2 seconds
    }
});