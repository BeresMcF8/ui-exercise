"use strict";

$(function ($) {
    var hideSidebar = false;
    var transitionInterval = 3000;
    $('.body-content .navbar-collapse ul li.sidebar').click(function (e) {
        e.preventDefault();
        if (!hideSidebar) {
            $('.sidebar-container').fadeOut(transitionInterval);
            hideSidebar = true;
        } else {
            $('.sidebar-container').fadeIn(transitionInterval);
            hideSidebar = false;
        }
    });
})(jQuery)