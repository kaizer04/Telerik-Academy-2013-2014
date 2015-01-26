// 04. Write a script that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

var array = [3, 2, 3, 5, 2, 2, 4];
var equalElements = [];

var tempIndex = 0;
var tempCount = 1;
var count = 1;
var indexFirstElement = 0;

for (var i = 0; i < array.length - 1; i++) {
    if (array[i] === array[i + 1] - 1) {
        tempCount++;
        if (tempCount > count) {
            count = tempCount;
            indexFirstElement = tempIndex;
        }
    }
    else {
        tempCount = 1;
        tempIndex = i + 1;
    }
}

for (var i = indexFirstElement; i < indexFirstElement + count; i++) {
    equalElements.push(array[i]);
}


console.log("{" + array.join(", ") + "} -> {" + equalElements.join(", ") + "}");