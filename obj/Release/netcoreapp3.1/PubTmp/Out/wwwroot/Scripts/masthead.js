var menuActive = false;
var menuThreshold = 90;
var mastheadLogo = "<img class='mast-logo' src='images/masthead-logo.png' />";

$(document).ready(function () {
    genMenu("menu-bar");
    $(document).on("mousemove", handleMouseMove);
})

function handleMouseMove(e) {
    if (e.clientY < menuThreshold && !menuActive) {
        $("#menu-bar").show(200, function () {
            menuActive = true;
        });
    }

    if (e.clientY > menuThreshold && menuActive) {
        $("#menu-bar").hide(200, function () {
            menuActive = false;
        });
    }
}

function genMenu(id) {
    var content = [
        "<span class='link' onclick=\"handleMenu('home')\">Home</span>",
        "<span class='link' onclick=\"handleMenu('todo')\">Todo List</span>",
        "<span class='link' onclick=\"handleMenu('dev')\">Develop</span>",
        "<span class='link' onclick=\"handleMenu('guitars')\">Guitars</span>"
    ].join("&nbsp;&nbsp;|&nbsp;&nbsp;");
    var obj = document.getElementById(id);
    if (obj) obj.innerHTML = content;
}

function handleMenu(key) {
    switch (key) {
        case "home":
            self.location = "./";
            break;
        case "todo":
            self.location = "todo.php";
            break;
        case "dev":
            self.location = "glyphs.php";
            break;
        case "guitars":
            self.location = "guitars.php";
            break;
    }
}

function echo(s) {
    $("#message").html(s + "<br>");
}
