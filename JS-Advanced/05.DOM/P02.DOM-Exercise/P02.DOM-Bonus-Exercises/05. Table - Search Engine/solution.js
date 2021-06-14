function solve() {
  document.querySelector("#searchBtn").addEventListener("click", onClick);

  function onClick() {
    let searchElement = document.getElementById("searchField");
    let rowElements = Array.from(document.querySelectorAll("tbody tr"));

    let searchText = searchElement.value;

    rowElements.forEach((el) => {
      el.className = "";
    });

    let filteredRows = rowElements.filter((el) => {
      let tdElements = Array.from(el.children);

      if (tdElements.some((el) => el.textContent.includes(searchText))) {
        el.className = "select";
      }
    });

    searchElement.value = "";
  }
}
