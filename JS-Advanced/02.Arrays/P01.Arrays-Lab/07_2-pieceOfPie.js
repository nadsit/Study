function pieceOfPie(array, firstString, secondString) {
    let startIndex = array.indexOf(firstString);
    let endIndex = array.indexOf(secondString);

    array = array.slice(startIndex, endIndex + 1);

    return array;
}

console.log(pieceOfPie(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'
));