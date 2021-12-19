// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {
    
    /* SET PARAMETERS */
    var change_img_time 	= 5000;	
    var transition_speed	= 100;
    
    var simple_slideshow	= $("#exampleSlider"),
        listItems 			= simple_slideshow.children('li'),
        listLen				= listItems.length,
        i 					= 0,

        
		
        changeList = function () {

            document.getElementById("show").innerHTML = listLen;
			listItems.eq(i).fadeOut(transition_speed, function () {
				i += 1;
				if (i === listLen) {
					i = 0;
				}
				listItems.eq(i).fadeIn(transition_speed);
			});

        };
		
    listItems.not(':first').hide();
    setInterval(changeList, change_img_time);
	
});