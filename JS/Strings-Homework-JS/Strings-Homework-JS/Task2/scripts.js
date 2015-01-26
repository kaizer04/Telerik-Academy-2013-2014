// 02. Write a JavaScript function to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).

function checkBracketsCorrectly(str) {
    var brackets = 0; 
        
    for (var i = 0; i < str.length; i++) {
        if (str[i] === '(') {
            brackets++;
        }
        if (str[i] === ')') {
            brackets--;
        }
        if (brackets < 0) {
            //console.log('The brackets ARE NOT put correctly.');
            break;
        }
    }

    if (brackets === 0) {
        console.log('The brackets ARE put correctly.');
    }
    else {
        console.log('The brackets ARE NOT put correctly.');
    }
}

var expression = '((a+b)/5-d))';
checkBracketsCorrectly(expression);