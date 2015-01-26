/* 04. You are given a text. Write a function that changes the text in all regions:
<upcase>text</upcase> to uppercase.
<lowcase>text</lowcase> to lowercase
<mixcase>text</mixcase> to mix casing(random)
 */

function getChangesTextRegions(text) {
    
    function mixCase(letter) {
        var upper = Math.random() < 0.5;
        if (upper) {
            return letter.toUpperCase();
        }
        else {
            return letter.toLowerCase();
        }
    }

    function lowCase(letter) {
        return letter.toLowerCase();
    }

    function upCase(letter) {
        return letter.toUpperCase();
    }

    var result = "";
    var cases = [];

    for (var i = 0; i < text.length; i++) {
        if (text[i] == '<') {
            i++;
            if (text[i] == "/") {
                cases.pop();
                while (text[i] != '>') {
                    i++;
                }
            }
            else if (text[i] == 'm') {
                cases.push(mixCase);
                while (text[i] != '>') {
                    i++;
                }
            }
            else if (text[i] == 'u') {
                cases.push(upCase);
                while (text[i] != '>') {
                    i++;
                }
            }
            else if (text[i] == 'l') {
                cases.push(lowCase);
                while (text[i] != '>') {
                    i++;
                }
            }
            
        }
        else {
            if (cases.length == 0) {
                result += text[i];
            }
            else {
                var currLetter = text[i];

                for (var j = cases.length - 1; j >= 0; j--) {
                    currLetter = cases[j](currLetter);
                }

                result += currLetter;
            }
        }
    }

    return result;
}

var text = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

var result = (getChangesTextRegions(text));

console.log(result);
