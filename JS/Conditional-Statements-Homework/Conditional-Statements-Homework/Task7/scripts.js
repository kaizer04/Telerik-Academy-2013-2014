// 07. Write a script that finds the greatest of given 5 variables.

var a = 5;
var b = 0;
var c = -9;
var d = 0.9;
var e = 58;

var max = a;
if (b > max) {
    max = b;
}
if (c > max) {
    max = c;
}
if (d > max) {
    max = d;
}
if (e > max) {
    max = e;
}

console.log("The greatest variable is: " + max);
