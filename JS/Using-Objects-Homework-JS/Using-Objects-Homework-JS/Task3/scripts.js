/* 03. Write a function that makes a deep copy of an object
The function should work for both primitive and reference types*/

var obj = {num: 1, rank: 2, person: {fname: "Ivan", lname: "Todorov"}, rate: 3, say: 'hi'};

console.log(obj);

function makeDeepCopy(obj) {
    return JSON.parse(JSON.stringify(obj));
}

var copyObj = makeDeepCopy(obj);
console.log(copyObj);

//function makeDeepCopy(obj) {
//    var copyObj = new Object();//new empty object
//    for (var key in obj) {
//        copyObj[key] = obj[key];
//        if ((typeof obj[key]) == "object") {
//            copyObj[key] = makeDeepCopy(obj[key]); //recursion if we have to copy object in object call the same function again
//        }
//    }
//    return copyObj;
//}