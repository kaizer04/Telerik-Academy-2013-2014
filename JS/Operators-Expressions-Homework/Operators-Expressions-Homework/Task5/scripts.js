//05. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

var number = 333;

var mask = 1 << 3;

console.log("The third bit of " + number + " is: " + ((number & mask) != 0 ? 1 : 0));