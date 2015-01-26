// 02. Write a function that reverses the digits of given decimal number. Example: 256  652

function reverseNumberDigits(number) {
    var result = number + ' -> ';
    while (number != 0) {
        result += number % 10;
        number = (number / 10) | 0;
    }
    return result;
}

var number = 256;
console.log(reverseNumberDigits(number));
