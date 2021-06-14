function solve() {
    const selectMenu = document.getElementById("selectMenuTo");
    const binaryOption = document.createElement("option");
    const hexadecimalOption = document.createElement("option");

    binaryOption.textContent = "Binary";
    binaryOption.value = "binary";

    hexadecimalOption.textContent = "Hexadecimal";
    hexadecimalOption.value = "hexadecimal";

    selectMenu.appendChild(binaryOption);
    selectMenu.appendChild(hexadecimalOption);

    const selectMap = {
        "binary": num => num.toString(2),
        "hexadecimal": num => num.toString(16).toUpperCase()
    }

    const convertBtn = document.querySelector("#container > button");

    convertBtn.addEventListener("click", () => {
        const inputData = document.getElementById("input");
        const outputData = document.getElementById("result");

        outputData.value = selectMap[selectMenu.value](+inputData.value);
    });
}