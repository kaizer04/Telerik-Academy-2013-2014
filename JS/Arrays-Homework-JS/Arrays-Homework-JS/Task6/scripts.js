// 06. Write a program that finds the most frequent number in an array. Example:
//{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

var array = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
result = "{" + array.join(", ") + "} -> ";

function orderBy(a, b) {
    return (a == b) ? 0 : (a > b) ? 1 : -1;
};
array.sort(orderBy);

var count = 1;
var tempCount = 1;
var mostFrequentNumber = array[0];

for (var i = 0; i < array.length - 1; i++) {
    if (array[i] === array[i + 1]) {
        tempCount++;
        if (tempCount > count) {
            count = tempCount;
            mostFrequentNumber = array[i];
        }
    }
    else {
        tempCount = 1;
    }       
}

console.log(result + mostFrequentNumber + " (" + count + " times)");
