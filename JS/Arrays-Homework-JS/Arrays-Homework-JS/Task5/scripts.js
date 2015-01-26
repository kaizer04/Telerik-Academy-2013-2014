// 05. Sorting an array means to arrange its elements in increasing order. Write a script to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.Hint: Use a second array

var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 100, -6, 0, 5.6];

for (var j = 0; j < array.length; j++) {
    var tempMaxElement = array[j];
    for (var i = j + 1; i < array.length; i++) {
        if (array[i] < tempMaxElement) {        
            tempMaxElement = array[i];
            array[i] = array[j];
            array[j] = tempMaxElement;
        }
    }
}

console.log(array.join(", "));
