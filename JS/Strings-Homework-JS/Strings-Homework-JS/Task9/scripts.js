/* 09. Write a function for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails. Return the emails as array of strings.
*/

function extractingEmailAddresses(text) {
    var str = ' ' + text + ' ';
    console.log(str);
    var chars = [' ', ',', '.', '!', '?'];
    var subStr = '';
    var result = [];
    for (var i = 0; i < str.length; i++) {
        var indexAt = str.indexOf('@', i);
        //console.log(indexAt);
        if (indexAt != -1) {
            var leftSpace = str.lastIndexOf(' ', indexAt);
            //console.log(leftSpace);
            var rightSpace = str.indexOf(' ', indexAt); 
            subStr = str.substring(leftSpace, rightSpace).trim(chars);   
            if (leftSpace < indexAt - 1 && indexAt + 3 < rightSpace && subStr.lastIndexOf(".", subStr.length - 3) != -1) {
                result.push(subStr);
                //console.log(subStr);
            }
            i = rightSpace;
        }
    }
    return result;
}

var text = 'ivan@abv.bg gosho pesho. Pepi ima mail: pesho@gmail.com ';
//extractingEmailAddresses(text);
console.log(extractingEmailAddresses(text));
