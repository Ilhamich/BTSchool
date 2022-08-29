let cookie = getCookie("ac");

if (cookie) {

}

function getCookie(name) {
    let cookie = document.cookie;
    let pos = cookie.indexOf(name + '=');

    if (pos != -1) {
        let start = pos + name.length + 1;
        let end = cookie.indexOf(";", start);

        if (end == -1) {
            end = cookie.length;
        }

        let value = cookie.substring(start, end);

        return value;
    }
}