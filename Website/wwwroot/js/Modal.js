window.loadModal = function () {
    var modal = document.getElementById("modal");

    var btns = document.querySelectorAll(".modalBtn");

    btns.forEach(btn => btn.onclick = function () {
        modal.style.display = "block";
    })

    window.hideModal = function () {
        modal.style.display = "none";
    }
    window.showModal = function () {
        modal.style.display = "block";
    }
};