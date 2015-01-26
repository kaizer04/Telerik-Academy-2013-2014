// 07. Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm (find it in Wikipedia).

var element = 1;
var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, -3];

function orderBy(a, b) {
    return (a == b) ? 0 : (a > b) ? 1 : -1;
};
array.sort(orderBy);

var start = 0;
var end = array.length - 1;
        
for (var i = start; i <= end; i++) {
    var middle = Math.floor((start + end) / 2);
    if (element === array[middle]) {
        console.log("The index of " + element + " is " + middle);
        break;
    }
    if (element > array[middle]) {
        start = middle + 1;
    }
    else {
        end = middle - 1;
    }
}