// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


var allowScroll = true;
var menuOpen = false;
Write your JavaScript code.
function toggleMobileMenu(menu) {
    menu.classList.toggle('open');

    if (allowScroll) {
        menuOpen = true;
        disableScroll();

    } else {
        menuOpen = false;
        enableScroll();
    }
}

function disableScroll() {

    // Get the current page scroll position
    scrollTop = window.pageYOffset || document.documentElement.scrollTop;
    scrollLeft = window.pageXOffset || document.documentElement.scrollLeft,

        // if any scroll is attempted, set this to the previous value
        window.onscroll = function () {
            window.scrollTo(scrollLeft, scrollTop);
        };
    allowScroll = false;

}

function enableScroll() {
    window.onscroll = function () { };
    allowScroll = true;
}