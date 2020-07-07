function BS_Dialog() {

}

BS_Dialog.prototype.CenterElement = function (elementId) {
    var screenWidth  = $(window).width();
    var screenHeight = $(window).height();
    var top = 100;
    var e = document.getElementById(elementId);
    if (e) {
        var w = $(e).width();
        var left = (screenWidth - w) / 2;
        $(e).css("left", left);
        $(e).css("top", top);
    }

    var nv = document.getElementById("note-viewer");
    if (nv) {
        var nvdh = $(e).height();
        var t = 227;
        if (nvdh + top + t + 30 > screenHeight - 10) {
            var h = screenHeight - (top + t + 30);
            h = (h > 50) ? h : 50;
            $(nv).height(h);
        }
    }
    
    return true;
}

window.dialog = new BS_Dialog();