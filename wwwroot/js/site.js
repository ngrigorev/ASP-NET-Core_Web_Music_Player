
function DarkFunction() {
    var checkBox = document.getElementById("darkSwitch");
    var link = document.createElement('link');

    if (checkBox.checked == true) {
        link.id = 'id2';
        link.rel = 'stylesheet';
        link.href = '/lib/bootstrap/dist/css/bootstrap-darkly.min.css';
        document.head.appendChild(link);
        sessionStorage.setItem("darkSwitch", darkSwitch.checked = true);
    } else {
        link.id = 'id1';
        link.rel = 'stylesheet';
        link.href = '/lib/bootstrap/dist/css/bootstrap.css';
        document.head.appendChild(link);
        sessionStorage.setItem("darkSwitch", darkSwitch.checked = false);
    }
}

var check = JSON.parse(sessionStorage.getItem("darkSwitch"));
document.getElementById("darkSwitch").checked = check;
DarkFunction()
