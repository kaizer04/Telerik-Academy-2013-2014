// 01. Write a function that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine"

function readDigitName(digit) {
    var digitNames = ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"];
    var digitName = digitNames[digit];
    return digitName;
}

function returnsLastDigitName(number) {
    var lastDigit = Math.abs(number % 10);
    console.log(number + " -> " + readDigitName(lastDigit));
}

var number = -985;
returnsLastDigitName(number);
