function calorieObject(array) {
  let calorieObject = {};
   
  for (let i = 0; i < array.length; i += 2) {    
      calorieObject[array[i]] = +array[i + 1];
  }

  return calorieObject;
}

console.log(calorieObject(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']));
console.log(calorieObject(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']));