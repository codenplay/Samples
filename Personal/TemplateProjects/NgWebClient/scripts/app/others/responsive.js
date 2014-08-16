
/* adjust map-canvas size */
function jqUpdateSize() {
    // Get the dimensions of the viewport
    var width = $(window).width();
    var windowHeight = $(window).height();
    var bodyHeight = $("body").height();
    var headerHeight = $("#map-header").outerHeight(true);

    var newHeight = windowHeight - headerHeight;
    $('#map-canvas').height(newHeight);
    $('#map-canvas').css('margin-top', headerHeight);
};
$(document).ready(jqUpdateSize);    // When the page first loads
$(window).resize(jqUpdateSize);     // When the browser changes size
/* adjust map-canvas size - end*/



$(document).ready(function (e) {
    $("#btn-get-started").click(function (e) {
        e.preventDefault();
        $("#curtains").fadeOut(100);
    });

    $("#showResponsiveNav").click(function (e) {
        e.preventDefault();
        toggleResponsiveMenu();
    });

    $("#btn-hide-filters").click(function (e) {
        e.preventDefault();
        toggleResponsiveMenu();
    });

    function toggleResponsiveMenu() {
        var getDisplay = $("#map-filters").css("display");
        if (getDisplay == "none") {
            $("#map-filters").fadeIn(200);
            $("#map-filters").css("display", "block");
        } else {
            $("#map-filters").fadeOut(200);
            $("#map-filters").css("display", "none");
        }
    }
});