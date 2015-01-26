var calculators = (function () {
    var lastCalculatorId = 0;

    function Calculator() {
        this._id = ++lastCalculatorId;
    }

    //var calculator = new Calculator();
    var calculator;

    return {
        getCalculator: function () {
            if (!calculator){
                calculator = new Calculator();
            }

            return calculator;
        }
    };
}());


console.log(calculators.getCalculator()._id);
console.log(calculators.getCalculator()._id);
console.log(calculators.getCalculator()._id);