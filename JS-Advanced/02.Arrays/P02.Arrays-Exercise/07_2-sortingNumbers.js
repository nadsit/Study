function sortingNumbers(arr) {
  let n = arr.length;
  // Sorting the array elements
  arr.sort((a, b) => a - b);

  // To store modified array
  let tempArr = new Array(n);

  // Adding numbers from sorted array
  // to new array accordingly
  let arrIndex = 0;

  // Traverse from begin and end simultaneously
  for (let i = 0, j = n - 1; i <= n / 2 
    || j > n / 2; i++, j--) {

    if (arrIndex < n) {
      tempArr[arrIndex] = arr[i];
      arrIndex++;
    }

    if (arrIndex < n) {
      tempArr[arrIndex] = arr[j];
      arrIndex++;
    }
  }

  // Modifying original array
  for (let i = 0; i < n; i++) arr[i] = tempArr[i];

  return arr;
}

console.log(sortingNumbers([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));
