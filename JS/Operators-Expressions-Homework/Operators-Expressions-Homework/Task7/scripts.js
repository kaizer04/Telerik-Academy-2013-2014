// 07. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

var number = 37;
var isPrime = number + " IS a prime number";
var maxDivide = Math.sqrt(number);
for (var i = 2; i <= maxDivide; i++) {
    if (number % i === 0) {
        isPrime = number + " IS NOT a prime number";
        break;
    }
}

console.log(isPrime);
    