var controls = (function () {
    'use strict';

    var Calculator = (function () {
        function Calculator() {
            this._result = 0;
        }

        Calculator.prototype.add = function (value) {
            hiddenMethod();
            this._result += value;
            return this;
        };
        Calculator.prototype.multiply = function (value) {
            this._result *= value;
            return this;
        };
        Calculator.prototype.showResult = function (value) {
            return this._result;
        };

        return Calculator;
    }());

    var Form = (function () {
        function Form(title) {
            this._title = title;
        }

        return Form;
    }());

    var Button = (function(){
        function Button(text) {
            this._text = text;
        }

        return Button;
    }());

    //exposed - public
    return {
        getCalculator: function(){
            return new Calculator();
        },
        getButton: function (text) {
            return new Button(text);
        },
        getForm: function (title) {
            return new Form(title);
        }
    };
}());

var calculator = new controls.Calculator().add(5).add(7).multiply(6).add(8);


console.log(calculator.showResult());

console.log('---');