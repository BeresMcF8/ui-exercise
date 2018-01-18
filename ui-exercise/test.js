$(function ($) {
    var hideSidebar = false;
    $('.body-content .navbar-collapse ul li.sidebar').click(function (e) {
        e.preventDefault();
        if (!hideSidebar) {
            $('.sidebar-container').hide();
            hideSidebar = true;
        } else {
            $('.sidebar-container').show();
            hideSidebar = false;
        }
    });
})(jQuery)