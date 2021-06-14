function lockedProfile() {
  const btns = [...document.getElementsByTagName("button")];
  btns.forEach((btn) => btn.addEventListener("click", showHide));

  function showHide(event) {
    const button = event.target;
    const profile = button.parentNode;
    const moreInformation = profile.getElementsByTagName("div")[0];
    const lockStatus = profile.querySelector('input[type="radio"]:checked').value;

    if (lockStatus === "unlock") {
      if (button.textContent === "Show more") {
        moreInformation.style.display = "inline-block";
        button.textContent = "Hide it";
      } else if (button.textContent === "Hide it") {
        moreInformation.style.display = "none";
        button.textContent = "Show more";
      }
    }
  }
}

//The HTML attribute checked means: checked by default, when the page loads.
//This won't change when the checkbox is clicked.

//<input type="checkbox" checked="checked"> <!-- The HTML attribute --></input>

//The DOM property checked is actually the current state of the checkbox and
//is either true/false. This will change when the checkbox is clicked,
//but isn't visible when you inspect the HTML.

//$('input:check')[0].checked == true;
// Whether or not the checkbox is currently checked