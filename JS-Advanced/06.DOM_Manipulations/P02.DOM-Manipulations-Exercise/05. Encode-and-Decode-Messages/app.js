function encodeAndDecodeMessages() {
  document.getElementById("main").addEventListener("click", (e) => {
    if (e.target.tagName !== "BUTTON") {
      return;
    }

    let decodedMessage = document.getElementsByTagName("textarea")[0];
    let encodedMessage = document.getElementsByTagName("textarea")[1];

    if (e.target.textContent.includes("Encode")) {
      let message = decodedMessage.value;
      let encoded = [];

      for (let i = 0; i < message.length; i++) {
        let currSymbol = message.charCodeAt(i);
        encoded.push(String.fromCharCode(currSymbol + 1));
      }

      decodedMessage.value = "";
      encodedMessage.value = encoded.join("");
    } else if (e.target.textContent.includes("Decode")) {
      let message = encodedMessage.value;
      let decoded = [];

      for (let i = 0; i < message.length; i++) {
        let currSymbol = message.charCodeAt(i);
        decoded.push(String.fromCharCode(currSymbol - 1));
      }

      encodedMessage.value = decoded.join("");
    }
  });
}

// function encodeAndDecodeMessages() {
//     let textarea = document.getElementsByTagName('textarea');
//     [...document.getElementsByTagName('button')].forEach(b => b.addEventListener('click', message));

//     function message(btn) {
//         if (btn.target.textContent === 'Encode and send it') {
//             let encoded = [...textarea[0].value].map(e => String.fromCharCode(e.charCodeAt(0) + 1)).join('');
//             textarea[1].value = encoded;
//             textarea[0].value = '';
//         } else if (btn.target.textContent === 'Decode and read it') {
//             let decoded = [...textarea[1].value].map(e => String.fromCharCode(e.charCodeAt(0) - 1)).join('');
//             textarea[1].value = decoded;
//         }
//     }
// }
