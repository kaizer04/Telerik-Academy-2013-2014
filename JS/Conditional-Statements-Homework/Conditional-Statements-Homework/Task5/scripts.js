// 05. Write script that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

function digitName() {

    var digit = parseInt(document.getElementById('digit').value);
    var result;

    switch (digit) {
        case 0:
            result = "zero";
            break;
        case 1:
            result = "one";
            break;
        case 2:
            result = "two";
            break;
        case 3:
            result = "three";
            break;
        case 4:
            result = "four";
            break;
        case 5:
            result = "five";
            break;
        case 6:
            result = "six";
            break;
        case 7:
            result = "seven";
            break;
        case 8:
            result = "eight";
            break;
        case 9:
            result = "nine";
            break;
        default:
            result = "You did not enter a digit!";
            break;
    }

    document.getElementById('result').innerHTML = result;

}