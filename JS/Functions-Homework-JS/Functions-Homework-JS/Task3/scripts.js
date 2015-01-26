/* 03. Write a function that finds all the occurrences of word in a text
The search can case sensitive or case insensitive
Use function overloading */

function getWordOccurancesInText(text, word, sensitive) {
    var caseSens = sensitive || false;

    var str = text.replace(/\W+/g, ' '); 
    var words = str.split(' ');
    var occurrences = 0;

    if (caseSens) {
        for (var i = 0; i < words.length; i++) {
            if (words[i] === word) {
                occurrences++;
            }
        }
    }
    else {
        var lowerWord = word.toLowerCase();

        for (var i = 0; i < words.length; i++) {
            if (words[i].toLowerCase() === lowerWord) {
                occurrences++;
            }
        }
    }

    return occurrences;
}

var text = 'Write a function that finds all the occurrences of word in a text. The search can case sensitive or CAse insensitive. Use function                      overloading';
var word = 'case';
var sensitive = false; // true = case sensitive or false = case insensitive

var result = getWordOccurancesInText(text, word, sensitive);
console.log('occurrences = ' + result);