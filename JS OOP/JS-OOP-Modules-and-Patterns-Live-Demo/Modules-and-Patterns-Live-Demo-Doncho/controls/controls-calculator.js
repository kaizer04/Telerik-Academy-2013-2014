var controls = controls || {};
(function (scope) {
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

   
    //exposed - public
    scope.getCalculator = function () {
        return new Calculator();
    };
}(controls));
