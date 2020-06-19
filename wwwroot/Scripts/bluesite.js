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
