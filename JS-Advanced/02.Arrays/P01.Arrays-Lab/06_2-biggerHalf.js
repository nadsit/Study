function biggerHalf(array) {
    let newArray = array.sort((a, b) => a - b);
    let halfLength = Math.ceil(newArray.length / 2);
    newArray = newArray.slice(newArray.length - halfLength, newArray.length)

    return newArray;
}

console.log(biggerHalf([4, 7, 2, 5]));
console.log(biggerHalf([3, 19, 14, 7, 2, 19, 6]));