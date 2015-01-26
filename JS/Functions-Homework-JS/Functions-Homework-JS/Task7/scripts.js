// 07. Write a function that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
// Use the function from the previous exercise.
    
function returnIndexBiggerElement() {
    var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, -3];
    var index = -1;
    for (var i = 1; i < array.length - 1; i++) {
        if (array[i] > array[i - 1] && array[i] > array[i + 1]) {
            index = i;
            break;
        }
    }
    return index;
}

console.log(returnIndexBiggerElement());
