/* 04. Write a function that checks if a given object contains a given property */

function hasProperty(obj, property) {
    if (obj.hasOwnProperty(property)) {
        return true;
    }
    return false;
}

var arr = new Array(1, 2, 1, 3, 2, 4); //array is object
var point = { X: 0, Y: 3 };

var property = "length";
var hasProp = hasProperty(arr, property); //check if array has length
console.log("Array has property " + property + ": " + hasProp);

hasProp = hasProperty(point, property);//check if point has length
console.log("Point has property " + property + ": " + hasProp);

property = "X";
hasProp = hasProperty(arr, property); //check if array has property X
console.log("Array has property " + property + ": " + hasProp);

hasProp = hasProperty(point, property); //check if array has property X
console.log("Point has property " + property + ": " + hasProp);

