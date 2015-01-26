/* 02. Write a function that removes all elements with a given value

Attach it to the array type
Read about prototype and how to attach methods*/

var arr = [1, 2, 1, 4,1,1,1, 1, 3, 4, 1,1, 111, 3, 2, 1, "1"];

console.log(arr);

Array.prototype.remove = function (number) {
    for (var i = 0; i < this.length; i++) {
        if (this[i] === number) {
            this.splice(i, 1);
            i--;
        }
    }
}

arr.remove(1);
console.log(array);
