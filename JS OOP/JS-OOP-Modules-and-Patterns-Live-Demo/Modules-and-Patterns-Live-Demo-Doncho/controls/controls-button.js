var controls = controls || {};
(function (scope) {
    var Button = (function () {
        function Button(text) {
            this._text = text;
        }

        return Button;
    }());

    scope.getButton = function (text) {
        return new Button(text);
    }
}(controls));