function SelectList(raw, target) {
    if (!target) target = "select-list-sec"
    this.target = (typeof target === "string") ? document.getElementById(target) : target;
    this.list = [];
    this.currentIndex = -1;
    var l = raw.split(",");
    for (var a = 0; a < l.length; a++) {
        this.list.push(new SelectListItem(l[a]));
    }
    console.log(this);
}

SelectList.prototype.show = function (obj, index) {
    var p = $(obj).offset();
    var w = $(obj).width();
    var h = $(obj).height();

    this.currentIndex = index;

    var top = p.top + (h -2)
    var left = p.left + 20;

    var t = this.target;
    t.style.top = top + "px";
    t.style.left = left + "px";
    t.innerHTML = this.draw();
    $(t).fadeIn(300);
}

SelectList.prototype.close = function () {
    $(this.target).fadeOut(300);
    this.target.innerHTML = "";
}

SelectList.prototype.draw = function () {
    var buffer = ["<table cellspacing='0' cellpadding='0' border='0'>"]
    for (let a = 0; a < this.list.length; a++) {
        buffer.push(this.list[a].draw(this.currentIndex))
    }
    buffer.push("</table>");
    return buffer.join("");
}

function SelectListItem(raw) {
    var item = raw.split(":")
    this.key = item[0];
    this.value = item[1];
}

SelectListItem.prototype.draw = function (index) {
    return "<tr><td class='list-item' onclick=\"setActionStatus(" + index + ", '" + this.key + "')\">" + this.value + "</td></tr>";
}

/* ========================================
 *    Handlers
 * ===================================== */

function setActionStatus(index, status) {
    actionStatusList.close();
    alert(index + ": " + status);
    dotnetHelper.invokeMethod('JobHunter', 'UpdateActionStatus')
}
