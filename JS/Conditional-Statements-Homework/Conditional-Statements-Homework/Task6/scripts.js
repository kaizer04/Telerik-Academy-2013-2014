/*06. Write a script that enters the coefficients a, b and c of a quadratic equation
a*x2 + b*x + c = 0
and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.*/

function calculate() {
    var a = parseFloat(document.getElementById('coefficientA').value);
    var b = parseFloat(document.getElementById('coefficientB').value);
    var c = parseFloat(document.getElementById('coefficientC').value);
    var result;

    if ((b * b - 4 * a * c) > 0) {
        var x1 = (-b + Math.sqrt(b * b - 4 * a * c)) / (2 * a);
        var x2 = (-b - Math.sqrt(b * b - 4 * a * c)) / (2 * a);
        result = "x1 = " + x1 + "; x2 = " + x2;
    }
    else {
        if ((b * b - 4 * a * c) === 0) {
            var x1 = (-b + Math.sqrt(b * b - 4 * a * c)) / (2 * a);
            result = "x1 = " + x1;
        }
        else {
            result = "The quadratic equation has not real roots";
        }
    }

    document.getElementById('result').innerHTML = result;
}