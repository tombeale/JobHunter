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
        $(element).hide();
        var p    = $(parent);
        var pos  = $(parent).offset();
        let top  = pos.top;
        let left = pos.left;


        let w = $(parent).width();
        let h = $(parent).height();

        console.log("------------------------");
        console.log($(parent).position());
        console.log($(element).position());
        console.log($(parent).offset());
        element.style.top  = 0;
        element.style.left = 0;

        //top = $(parent).offset().top  - $(element).offset().top;
        //top = $(parent).offset().left - $(element).offset().left;

        top  =  top + h + 1
        left = left + 20;

        let offset = { top: top, left: left };

        console.log(offset);

        $(element).offset(offset);
        console.log("After...");
        console.log($(element).position());
        console.log($(element).offset());
        $(element).fadeIn(300);
    }
    else {
        console.log("bluesite.LocateElementBelowParent Error: Elements not found for the Ids passed (" + elementIds + ")");
    }
}

function toggleExpand(elementId) {
    var id = "#" + elementId
    $(id).toggle(300);
}

function hideElement(elementId) {
    $("#" + elementId).fadeOut(300);
}

function hideElementsWithClass(elementClass) {
    $("." + elementClass).fadeOut(300);
}

function setIconImage(element, img) {
    element.src = "images/icons/" + img;
}

function triggerChangeOnEnter(evt, elem) {
    if (evt.keyCode === 13) {
        elem.blur();
    }
}
