// 04. Sort 3 real values in descending order using nested if statements.

var firstNumber = -28;
var secondNumber = -9;
var thirdNumber = 0;

if (firstNumber > secondNumber) {

    if (firstNumber > thirdNumber) {

        if (secondNumber > thirdNumber) {
            console.log("Sorted in descending order: " + firstNumber, secondNumber, thirdNumber);
        }

        else {

            console.log("Sorted in descending order: " + firstNumber, thirdNumber, secondNumber);

        }

    }

    else {

        console.log("Sorted in descending order: " + thirdNumber, firstNumber, secondNumber);

    }

}

else {

    if (secondNumber > thirdNumber) {

        if (thirdNumber > firstNumber) {
            console.log("Sorted in descending order: " + secondNumber, thirdNumber, firstNumber);
        }

        else {
            console.log("Sorted in descending order: " + secondNumber, firstNumber, thirdNumber);
        }

    }

    else {

        console.log("Sorted in descending order: " + thirdNumber, secondNumber, firstNumber);

    }
}


