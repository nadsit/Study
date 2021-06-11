function parseInstructions(arr) {
  let operands = [];
  let wasWrong = false;

  for (let index = 0; index < arr.length; index++) {
    if (typeof arr[index] === "number") {
      operands.push(arr[index]);
    } else {
      let operator = arr[index];

      if (operands.length < 2) {
        console.log("Error: not enough operands!");
        wasWrong = true;
        break;
      }

      let operand2 = operands.pop();
      let operand1 = operands.pop();

      let result = applyOperation(operand1, operand2, operator);
      operands.push(result);
    }
  }

  if (operands.length > 1 && wasWrong === false) {
    console.log("Error: too many operands!");
  } else if (wasWrong === false) {
    console.log(operands[0]);
  }

  function applyOperation(operand1, operand2, operator) {
    const arithmeticOperator = {
      "+": () => operand1 + operand2,
      "-": () => operand1 - operand2,
      "*": () => operand1 * operand2,
      "/": () => operand1 / operand2,
    };

    return arithmeticOperator[operator]();
  }
}

parseInstructions([3, 4, "+"]);
parseInstructions([5, 3, 4, "*", "-"]);
parseInstructions([7, 33, 8, "-"]);
parseInstructions([15, "/"]);
