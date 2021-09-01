$(function (){
    $("li>a").click(function (e) {
        e.preventDefault();
        $(".punecontent").load($(this).attr("href"));
});
});
document.addEventListener('DOMContentLoaded', function () {
    let stars = document.querySelectorAll('.star');
    stars.forEach(function (star) {
        star.addEventListener('click', setRating);
    });

    let rating = parseInt(document.querySelector('.stars').getAttribute('data-rating'));
    let target = stars[rating - 1];
    target.dispatchEvent(new MouseEvent('click'));
});

function setRating(ev) {
    let span = ev.currentTarget;
    let stars = document.querySelectorAll('.star');
    let match = false;
    let num = 0;
    stars.forEach(function (star, index) {
        if (match) {
            star.classList.remove('rated');
        } else {
            star.classList.add('rated');
        }
        //are we currently looking at the span that was clicked
        if (star === span) {
            match = true;
            num = index + 1;
        }
    });
    document.querySelector('.stars').setAttribute('data-rating', num);
}

$(document).ready(function () {
    $("#sidebarCollapse").on("click", function () {
        $("#sidebar").addClass("active");
    });

    $("#sidebarCollapseX").on("click", function () {
        $("#sidebar").removeClass("active");
    });

    $("#sidebarCollapse").on("click", function () {
        if ($("#sidebar").hasClass("active")) {
            $(".overlay").addClass("visible");
            console.log("it's working!");
        }
    });

    $("#sidebarCollapseX").on("click", function () {
        $(".overlay").removeClass("visible");
    });
});
