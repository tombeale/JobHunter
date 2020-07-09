var currentPageTitle = "... Let the Job Hunt Begin!"

function handleInterop() {
    DotNet.invokeMethodAsync('BlueSite', 'callServer')
    .then(message => {
        alert(message);
    });
}

function setTitle(title) {
    currentPageTitle = title;
    var element = document.getElementById("masthead-title")
    element.innerHTML = currentPageTitle;
}

function locateElementBelowParent(elementIds) {
    var ids = elementIds.split("|");
    var element = document.getElementById(ids[0]);
    var parent  = document.getElementById(ids[1]);
    if (element && parent) {
        var p = $(parent).offset();
        var w = $(parent).width();
        var h = $(parent).height();

        var top = p.top + (h - 2)
        var left = p.left + 20;

        element.style.top = top + "px";
        element.style.left = left + "px";
        $(element).fadeIn(300);
    }
    else {
        console.log("bluesite.LocateElementBelowParent Error: Elements not found for the Ids passed (" + elementIds + ")");
    }
}

function hideElement(elementId) {
    $("#" + elementId).fadeOut(300);
}

function setIconImage(element, img) {
    element.src = "images/icons/" + img;
}
