// 02. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var number = 36;

console.log(((number % 7 == 0) && (number % 5 == 0)) ? "The number divides by 7 and 5" : "The number is not divide by 7 and 5");