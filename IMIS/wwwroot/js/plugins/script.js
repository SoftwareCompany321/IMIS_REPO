<!-- Menu Toggle Script -->


$(document).ready(function() {
    var toggle = true;

    $(".menu-toggler").click(function() {

        if (toggle) {
            $('body').addClass("menu-collapsed");
        } else {
            $('body').removeClass("menu-collapsed");
        }
        toggle = !toggle;
    });

    // Bootstrap tabs
    $("ul.nav-tabs a").click(function (e) {
      e.preventDefault();
      $(this).tab('show');
    });

    //Tree Menu

    $('.tree-menu li i.trigger').click(function (e) {
        e.preventDefault();
        var ullist = $(this).parent().children('ul:first');
        if(ullist.is(':visible')){
            ullist.hide('slow');
            ullist.parent("li").removeClass();
        } else {
            ullist.show('slow');
            ullist.parent("li").addClass("active");
        }
    });

});
