function toggle() {
    let button = document.getElementsByClassName("button")[0];
    let textDiv = document.getElementById("extra");

    button.textContent = button.textContent === "More" ? "Less" : "More";
    textDiv.style.display = textDiv.style.display === "block" ? "none" : "block";
}