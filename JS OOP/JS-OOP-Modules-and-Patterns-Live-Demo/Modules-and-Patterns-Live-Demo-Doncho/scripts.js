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

    //exposed - public
    return {
        //constructor
        Calculator: function () {
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
    };
}()); 

var calculator = new controls.Calculator().add(5).add(7).multiply(6).add(8);


console.log(calculator.showResult());

console.log('---');