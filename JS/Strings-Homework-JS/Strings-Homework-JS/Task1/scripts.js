// 01. Write a JavaScript function reverses string and returns itExample: "sample"  "elpmas".

function reversesString(str) {
    var reversedStr = '';
    for (var i = str.length - 1; i >= 0; i--) {
        reversedStr += str[i];
    }
    
    return reversedStr;
}

var str = 'sample';

console.log(str + ' -> ' + reversesString(str));
