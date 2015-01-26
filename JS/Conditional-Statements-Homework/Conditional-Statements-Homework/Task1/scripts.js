// 01. Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

var firstNumber = 3;
var secondNumber = 4;
if (firstNumber > secondNumber) {
    var tempNumber = secondNumber;
    secondNumber = firstNumber;
    firstNumber = tempNumber;
}

console.log("firstNumber = " + firstNumber);
console.log("secondNumber = " + secondNumber);