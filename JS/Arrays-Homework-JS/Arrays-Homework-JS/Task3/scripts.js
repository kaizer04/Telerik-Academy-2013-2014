// 03. Write a script that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

var array = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
var equalElements = [];

var tempIndex = 0;
var tempCount = 1;
var count = 1;
var indexFirstElement = 0;

for (var i = 0; i < array.length - 1; i++) {
    if (array[i] === array[i + 1]) {
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