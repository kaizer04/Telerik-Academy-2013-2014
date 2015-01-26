// 08. Write a script that converts a number in the range [0...999] to a text corresponding to its English pronunciation.


function convert() {
    var number = parseInt(document.getElementById('number').value);
    var result = "";
    if (isNaN(number)) {
        result = "You have not entered a valid integer number!";
    }
    else {
        if (number >= 100) {
            result += GetSimpleDigits(Math.floor(number / 100));
            result += " hundred ";
            number %= 100;
        }

        if (number > 19) {
            result += GetTwentyToNineTeen(Math.floor(number / 10));
            result += " ";
            number %= 10;
        }
        else if (number > 9) {
            if (result != "") {
                result += "and ";
            }
            result += GetTeenNumbers(number);
            result += " ";
            number = 0
        }

        if (number > 0) {
            result += GetSimpleDigits(number);
            result += " ";
            number = 0;
        }

        if (number === 0) {
            if (result == "") {
                result += "zero";
            }
        }
    }

    document.getElementById('result').innerHTML = result;
}

function GetSimpleDigits(digit) {
    switch (digit) {
        case 0: return "";
        case 1: return "one";
        case 2: return "two";
        case 3: return "three";
        case 4: return "four";
        case 5: return "five";
        case 6: return "six";
        case 7: return "seven";
        case 8: return "eight";
        case 9: return "nine";
        default: return "";
    }
}

function GetTeenNumbers(number) {
    switch (number) {
        case 10: return "ten";
        case 11: return "eleven";
        case 12: return "twelve";
        case 13: return "thirteen";
        case 14: return "fourteen";
        case 15: return "fifteen";
        case 16: return "sixteen";
        case 17: return "seventeen";
        case 18: return "eighteen";
        case 19: return "nineteen";
        default: return "";
    }
}

function GetTwentyToNineTeen(digit) {
    switch (digit) {
        case 2: return "twenty";
        case 3: return "thirty";
        case 4: return "fourty";
        case 5: return "fifty";
        case 6: return "sixty";
        case 7: return "seventy";
        case 8: return "eighty";
        case 9: return "ninety";
        default: return "";
    }
}