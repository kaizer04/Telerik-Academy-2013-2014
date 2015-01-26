// 03. Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

function findsHowManyTimesSubstrContained(str, subStr) {
    var count = 0;
    for (var i = 0; i < str.length; i++) {
        var find = str.toLowerCase().indexOf(subStr.toLowerCase(), i);
        if (find != -1) {
            count++;
            i = find;
        }
    }

    return count;
}

var text = 'We are living in an yellow submarine. We don\'t have anything else. Inside the submarine is very tight. So we are drinking all the day. We              will move out of it in 5 days.';
var subStr = 'in';

var result = findsHowManyTimesSubstrContained(text, subStr);
console.log('The result is ' + result);