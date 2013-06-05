function onClick(event, arguments) {
    var browseWindow = window;
    var browserName = browseWindow.navigator.appCodeName;
    var isMozilla = browserName == "Mozilla";
    if (isMozilla) {
        alert("Yes");
    } else {
        alert("No");
    }
}