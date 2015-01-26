var controls = (function () {
    'use strict';

    //hidden members - private
    //method for the calculator function constructor


    var Calculator = (function () {
        var lastCalculatorId = 0;
        //var PI = Math.PI;
        function Calculator() {
            this._result = 0;
            this._id = ++lastCalculatorId;
        }


        //Prototype Pattern
        Calculator.prototype = (function() {
            //hidden
            function hiddenMethod() {
                console.log('I am hidden');
            }

            return {
                add: function (value) {
                    hiddenMethod();
                    this._result += value;
                    return this;
                },
                multiply: function (value) {
                    this._result *= value;
                    return this;
                },
                showResult: function (value) {
                    return this._result;
                }
            };
        }());

        //kogato imame nasledqvane zakachame edin po edin
        Calculator.prototype = new Thing();

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
           


        //Calculator.prototype = {
        //    add: function (value) {
        //        this._result += value;
        //    },
        //    multiply: function (value) {
        //        this._result *= value;
        //    },
        //    showResult: function (value) {
        //        return this._result;
        //    }
        //};

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
        Calculator: Calculator
        //Button: Buttonl
    };
}());

var calculator = new controls.Calculator().add(5).add(7).multiply(6).add(8);


console.log(calculator.showResult());

console.log('---');