// 02. Write a script that compares two char arrays lexicographically (letter by letter).

function onCompareTwoArrays() {
    var array1 = document.getElementById('a').value;
    var array2 = document.getElementById('b').value;

    var maxLength = array1.length;
    if (maxLength > array2.length) {
        maxLength = array2.length;
    }

    var result = 0;

    for (var i = 0; i < maxLength; i++) {
        
        if (array1[i] < array2[i]) {
            result = "Array 1 is before Array 2";
            break;
        }
        else if (array1[i] > array2[i]) {
            result = "Array 2 is before Array 1";
            break;
        }
    }

    // правя тази проверка, за да мога да обхвана случаите, когато всички елементи на двата масива са еднакви, но този с по-малка дължина (с по малко елементи) ще бъде по напред
    if (!result) {
        if (array1.length > array2.length) {
            result = "Array 2 is before Array 1";    
        }
        else if (array1.length < array2.length) {
            result = "Array 1 is before Array 2";    
        }
        else {
            result = "The arrays are equal";
        }
    }

    document.getElementById('result').innerHTML = result;
}