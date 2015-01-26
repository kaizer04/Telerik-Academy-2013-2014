// 03. Write a script that finds the max and min number from a sequence of numbers

var array = [4, 5, 6, 0, 2, 100.01, -9];

var maxNumber = array[0];
var minNumber = array[0];

for (var i = 0; i < array.length; i++) {
    if (array[i] <= minNumber) {
            minNumber = array[i];
    }
    if (array[i] >= maxNumber) {
        maxNumber = array[i];
    }
}

console.log("The the minimal number of the sequence is: " + minNumber);
console.log("The the maximal number of the sequence is: " + maxNumber);