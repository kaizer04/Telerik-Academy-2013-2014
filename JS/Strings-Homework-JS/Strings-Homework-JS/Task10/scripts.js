/* 10. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
*/

function extractsPalindromes(str) {
    var replacedStr = str.replace(/\W+/g, ' ');
    console.log(replacedStr);
    var text = replacedStr.split(' ');
    console.log(text);
    var palindromes = false;
    for (var i = 0; i < text.length; i++) {
        for (var j = 0; j < text[i].length; j++) {
            if (text[i][j] === text[i][text[i].length - 1 - j]) {
                palindromes = true;
            }
            else {
                palindromes = false;
                break;
            }   
        }

        if (palindromes) {
            console.log(text[i]);
        }
    }
}

var text = 'Nice blue sky. No exe or lamal flying in the sky. ABBA. will  come in Bulgaria soon';
extractsPalindromes(text);