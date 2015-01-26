// 04. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

var number = -1700;
var numberIn = number;

if (number < 0) {
    number = number * -1;
}

var isSeven = (((number / 100) | 0) % 10 === 7);

console.log("The third digit of " + numberIn + " is 7 --> " + isSeven);

