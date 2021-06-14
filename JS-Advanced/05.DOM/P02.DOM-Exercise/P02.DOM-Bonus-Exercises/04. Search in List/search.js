function search() {
  let searchElement = document.getElementById("searchText");
  let allLiElements = Array.from(document.querySelectorAll("#towns li")); // Without NodeList for Judge

  let searchText = searchElement.value;

  allLiElements.forEach((el) => {
    el.style["font-weight"] = "normal";
    el.style["text-decoration"] = "none";
  });

  let targetLis = allLiElements.filter((el) =>
    el.textContent.includes(searchText)
  );

  let transformedLis = targetLis.forEach((el) => {
    el.style.fontWeight = "bold";
    el.style.textDecoration = "underline";
  });

  let resultDiv = document.getElementById("result");
  resultDiv.textContent = `${targetLis.length} matches found`;
}