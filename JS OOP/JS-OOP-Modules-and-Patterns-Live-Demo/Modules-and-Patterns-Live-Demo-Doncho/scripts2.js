var controls = (function () {
    'use strict';

    //hidden members - private
    //method for the calculator function constructor
    var calculatorAdd = function (value) {
        this._result += value;
        return this;
    };
    var calculatorMultiply = function (value) {
        this._result *= value;
        return this;
    }
    var calculatorShowResult = function () {
        return this._result;
    }

    //Revealing Module PatternReveal
    var Calculator = (function () {
        function Calculator () {
            this._result = 0;
            //this.add = function (value) {
            //    this.result += value;
            //};
            this.add = calculatorAdd;
            //this.multiply = function (value) {
            //    this.result *= value;
            //}
            this.multiply = calculatorMultiply;
            this.showResult = calculatorShowResult;
        }

        return Calculator;
    }());

    var Form = (function () {
        function Form() {
            this.calculator = new Calculator();
        }
        return Form;
    });

    function Button() {

    }

    //exposed - public
    return {
        Calculator: Calculator,
        Button: Buttonl
    };
}());

var calculator = new controls.Calculator().add(5).add(7).multiply(6).add(8);


console.log(calculator.showResult());

console.log('---');