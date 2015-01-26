// 05. Write a function that replaces non breaking white-spaces in a text with &nbsp

function replaceSpaceInText(text) {
    var nbsp = '&nbsp;';

    var result = "";

    for (var i = 0; i < text.length; i++) {
        if (text[i] == ' ') {
            result += nbsp;
        }
        else {
            result += text[i];
        }
    }

    return result;
}

var text = 'Write a function that replaces non breaking white-spaces in a text.';

console.log(replaceSpaceInText(text));

