// 03. Write a script that finds the biggest of three integers using nested if statements.

var firstNumber = 28;
var secondNumber = -9;
var thirdNumber = 11;

var biggestNumber = firstNumber;

if (secondNumber > biggestNumber) {
    biggestNumber = secondNumber;
    if (thirdNumber > biggestNumber) {
        biggestNumber = thirdNumber;
    }
}

console.log("The biggest number is " + biggestNumber);