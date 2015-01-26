(function () {
    var input1 = document.getElementById('1');
    var input2 = document.getElementById('2');
    var input3 = document.getElementById('3');
    var input4 = document.getElementById('4');

    //var lineWidth = document.getElementById('lineWidth');
    //var strokeColor = document.getElementById('strokeColor');
    //var fillColor = document.getElementById('fillColor');

    var button = document.getElementById('btnLine')

    document.getElementById('line').onchange = function () {
        input1.placeholder = 'X1';
        input2.placeholder = 'Y1';
        input3.placeholder = 'X2';
        input4.placeholder = 'Y2';

        input4.disabled = false;
       

        button.onclick = drawLine;
    }

    document.getElementById('rect').onchange = function () {
        input1.placeholder = 'X';
        input2.placeholder = 'Y';
        input3.placeholder = 'Width';
        input4.placeholder = 'Height';

        input4.disabled = false;
        

        button.onclick = drawRect;
    }

    document.getElementById('circle').onchange = function () {
        input1.placeholder = 'X';
        input2.placeholder = 'Y';
        input3.placeholder = 'Radius';
        input4.placeholder = '';

        input4.disabled = true;
        

        button.onclick = drawCircle;
    }

    var drawer = new Drawer('the-canvas');

    button.onclick = drawLine;

    // 0 data validation - not the subject of the exercise
    function drawLine() {
        drawer.line(input1.value, input2.value, input3.value, input4.value, 2, '#000');
    }

    function drawRect() {
        drawer.rect(input1.value, input2.value, input3.value, input4.value, 2, '#000', '#01FF13');
    }

    function drawCircle() {
        drawer.circle(input1.value, input2.value, input3.value, 2, '#000', '#01FF13');
    }
}())