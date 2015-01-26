// 05. Write a function that counts how many times given number appears in given array. Write a test function to check if the function is working correctly.

function countsNumberInArray() {
    var number = 2;
    var array = [2, 3, 2, 6, -9, 0];
    var count = 0;
    for (var i = 0; i < array.Length; i++) {
        if (number === array[i]) {
            count++;
        }
    }

    console.log(number + " appears " + count + " TIME in the array");
}

countsNumberInArray();
